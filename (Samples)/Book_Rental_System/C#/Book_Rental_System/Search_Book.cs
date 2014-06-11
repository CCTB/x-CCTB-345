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
    public partial class Search_Book : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter da;
        DataSet ds;

        public Search_Book()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT * from Book_Master WHERE ISBN='" + txtBook_ISBN.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAll_Records_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT * from Book_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search_Book_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
        }
    }
}
