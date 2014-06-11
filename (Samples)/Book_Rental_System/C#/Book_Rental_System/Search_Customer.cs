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
    public partial class Search_Customer : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataSet ds;

        public Search_Customer()
        {
            InitializeComponent();
        }
        
        private void Search_Customer_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT * from Customer_Master WHERE Customer_ID='" + txtCustomer_ID.Text + "' ", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAll_Records_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT * from Customer_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
