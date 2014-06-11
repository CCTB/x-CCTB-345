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
using System.Configuration;


namespace Book_Rental_System
{
    public partial class Purchase_Book : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public int maxrecords;
        public int pointer;
        
        public Purchase_Book()
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

        private void Purchase_Book_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
            pointer = 0;
            filldata();
            fillISBNcmbo();
            fillCust_Namecmbo();
           
        }
          
        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from Purchase_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            maxrecords = dt.Rows.Count;

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            
            if (txtQuantiry.Text == "")
            {
                DialogResult qty = MessageBox.Show("The Quantity Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                    string sql = "INSERT INTO Purchase_Master VALUES('" + cmbISBN.Text + "','" + txtBook.Text + "','" + txtAuthor.Text + "','" + cmbCust_Name.Text + "','" + dateTimePicker1.Text + "','" + txtPublisher_Name.Text + "','" + txtQuantiry.Text + "','" + txtBook_Price.Text + "','" + txtTotal_Price.Text + "')";
                    string qty = txtQuantiry.Text.ToString();
                    da = new OleDbDataAdapter("Select Total_Quantity from Book_Master where ISBN='" + cmbISBN.Text + "'", conn);
                    ds = new DataSet();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    int total = int.Parse(dt.Rows[0].ItemArray[0].ToString()) - int.Parse(txtQuantiry.Text);
                    string sql1 = "UPDATE Book_Master SET Total_Quantity = " + total + " WHERE ISBN = '" + cmbISBN.Text + "'";
                    Execute(sql);
                    Execute(sql1);
                    MessageBox.Show("Record is saved Successfully.");
                    this.Close();
                //}
            }
            

        }
        public void Execute(String sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                filldata();
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTotal_Price_Enter(object sender, EventArgs e)
        {
            if (txtTotal_Price.Text == "")
            {
                MessageBox.Show("Please enter the price.");
            }
                    
                int total = int.Parse(txtQuantiry.Text) * int.Parse(txtBook_Price.Text);
                txtTotal_Price.Text = total.ToString();
                txtTotal_Price.ReadOnly = true;
            
        }

        private void cmbISBN_SelectedValueChanged(object sender, EventArgs e)
        {
            fillAllTextBox();
        }
        public void fillAllTextBox()
        {
            string sql="SELECT Book,Author,Publisher,Price FROM Book_Master where ISBN='" + cmbISBN.SelectedItem.ToString() + "'";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            txtBook.ReadOnly = true;
            txtPublisher_Name.ReadOnly = true;
            txtAuthor.ReadOnly = true;
            txtBook_Price.ReadOnly = true;
            txtBook.Text = dt.Rows[0].ItemArray[0].ToString();
            txtAuthor.Text = dt.Rows[0].ItemArray[1].ToString();
            txtPublisher_Name.Text = dt.Rows[0].ItemArray[2].ToString();
            txtBook_Price.Text = dt.Rows[0].ItemArray[3].ToString();
        }

        private void txtQuantiry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult num = MessageBox.Show("Only Numbers are allowed.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtBook_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult num = MessageBox.Show("Only Numbers are allowed.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
