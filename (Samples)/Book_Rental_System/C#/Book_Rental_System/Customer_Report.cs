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
    public partial class Customer_Report : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public Customer_Report()
        {
            InitializeComponent();
        }

        private void Customer_Report_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();

            da = new OleDbDataAdapter("Select * from Customer_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];

            Customer_CrystalReport cr3 = new Customer_CrystalReport();
            crystalReportViewer3.ReportSource = cr3;
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {

        }
    }
}
