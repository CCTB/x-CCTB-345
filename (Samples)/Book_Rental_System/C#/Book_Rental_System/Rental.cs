using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Book_Rental_System
{
    public partial class Rental : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public int maxrecords;
        public int pointer;
        public Rental()
        {
            InitializeComponent();
        }
        public void fillISBNcmbo()
        {
            da = new OleDbDataAdapter("SELECT ISBN FROM Book_Master ", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbISBN.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        private void cmbISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT ISBN FROM Book_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
        }
        
        public void fillCust_Namecmbo()
        {
            da = new OleDbDataAdapter("SELECT Name FROM Customer_Master ", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbCust_Name.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        private void cmbCust_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT Name FROM Customer_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
            pointer = 0;
            filldata();
            fillISBNcmbo();
            fillCust_Namecmbo();
            btnRent.Enabled = true;
            txtTotalRent.ReadOnly = true;
        }
        
        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from Book_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            maxrecords = dt.Rows.Count;

        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            if (txtRentPrice.Text == "")
            {
                DialogResult rntpr = MessageBox.Show("The Rent Price Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtDays.Text == "")
            {
                DialogResult days = MessageBox.Show("The Days Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtTotalRent.Text == "")
            {
                DialogResult totrent = MessageBox.Show("The Total Rent Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "INSERT INTO Rent_Master VALUES('" + cmbISBN.Text + "','" + txtBook.Text + "','" + txtAuthor.Text + "','" + txtPublisher_Name.Text + "','" + txtRentPrice.Text + "','" + txtDays.Text + "','" + txtTotalRent.Text + "','" + cmbCust_Name.Text + "')";
                //string qty = 1;
                da = new OleDbDataAdapter("Select Total_Quantity from Book_Master where ISBN='" + cmbISBN.Text + "'", conn);
                ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                int total = int.Parse(dt.Rows[0].ItemArray[0].ToString()) - 1;
                string sql1 = "UPDATE Book_Master SET Total_Quantity = " + total + " WHERE ISBN = '" + cmbISBN.Text + "'";
                Execute(sql);
                Execute(sql1);
                MessageBox.Show("Record is saved Successfully.");
                this.Close();
            } 
        }
        
        public void Execute(String sql)
        {
            cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            filldata();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTotalRent_Enter(object sender, EventArgs e)
        {
            int total = int.Parse(txtRentPrice.Text) * int.Parse(txtDays.Text);
            txtTotalRent.Text = total.ToString();
            txtTotalRent.ReadOnly = true;
        }

        private void cmbISBN_SelectedValueChanged(object sender, EventArgs e)
        {
            fillAllTextBox();
        }
        public void fillAllTextBox()
        {
            string sql = "SELECT Book,Author,Publisher FROM Book_Master where ISBN='" + cmbISBN.SelectedItem.ToString() + "'";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            txtBook.ReadOnly = true;
            txtPublisher_Name.ReadOnly = true;
            txtAuthor.ReadOnly = true;
            txtTotalRent.ReadOnly = true;
            txtBook.Text = dt.Rows[0].ItemArray[0].ToString();
            txtAuthor.Text = dt.Rows[0].ItemArray[1].ToString();
            txtPublisher_Name.Text = dt.Rows[0].ItemArray[2].ToString();
        }

        private void txtRentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult num = MessageBox.Show("Only Numbers are allowed.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult num = MessageBox.Show("Only Numbers are allowed.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}