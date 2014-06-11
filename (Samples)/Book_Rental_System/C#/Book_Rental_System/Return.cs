using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Book_Rental_System
{
    public partial class Return : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public int maxrecords;
        public int pointer;

        public Return()
        {
            InitializeComponent();
        }
        
        public void fillISBNcmbo()
        {
            da = new OleDbDataAdapter("SELECT ISBN FROM Rent_Master ", conn);
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
            da = new OleDbDataAdapter("SELECT ISBN FROM Rent_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
        }
        
        public void fillCust_Namecmbo()
        {
            da = new OleDbDataAdapter("SELECT Customer_Name FROM Rent_Master ", conn);
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
            da = new OleDbDataAdapter("SELECT Customer_Name FROM Rent_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
        }

        private void Return_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
            pointer = 0;
            filldata();
            fillISBNcmbo();
            fillCust_Namecmbo();
            txtTotalDue.ReadOnly = true;
        }

        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from Rent_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            maxrecords = dt.Rows.Count;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtDue.Text == "")
            {
                DialogResult qty = MessageBox.Show("The Due Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtDays.Text == "")
            {
                DialogResult qty = MessageBox.Show("The Days Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
                string sql = "INSERT INTO Return_Master VALUES('" + cmbISBN.Text + "','" + txtBook.Text + "','" + txtAuthor.Text + "','" + txtPublisher_Name.Text + "','" + txtDue.Text + "','" + txtDays.Text + "','" + txtTotalDue.Text + "','" + cmbCust_Name.Text + "')";
                da = new OleDbDataAdapter("Select Total_Quantity from Book_Master where ISBN='" + cmbISBN.Text + "'", conn);
                ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                int total = int.Parse(dt.Rows[0].ItemArray[0].ToString()) + 1;
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

        private void txtTotalDue_Enter(object sender, EventArgs e)
        {
            int total = int.Parse(txtDue.Text) * int.Parse(txtDays.Text);
            txtTotalDue.Text = total.ToString();
            txtTotalDue.ReadOnly = true;
        }

        private void cmbISBN_SelectedValueChanged(object sender, EventArgs e)
        {
            fillAllTextBox();
        }

        public void fillAllTextBox()
        {
            string sql = "SELECT Book,Author,Publisher FROM Rent_Master where ISBN='" + cmbISBN.SelectedItem.ToString() + "'";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            txtBook.ReadOnly = true;
            txtPublisher_Name.ReadOnly = true;
            txtAuthor.ReadOnly = true;
            txtTotalDue.ReadOnly = true;
            txtBook.Text = dt.Rows[0].ItemArray[0].ToString();
            txtAuthor.Text = dt.Rows[0].ItemArray[1].ToString();
            txtPublisher_Name.Text = dt.Rows[0].ItemArray[2].ToString();
        }

        private void txtDue_KeyPress(object sender, KeyPressEventArgs e)
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
