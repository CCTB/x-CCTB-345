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
    public partial class Book_Report : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;

        public Book_Report()
        {
            InitializeComponent();
        }

        private void Book_Report_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();

            da = new OleDbDataAdapter("Select * from Book_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];

            Book_CrystalReport cr = new Book_CrystalReport();
            crystalReportViewer2.ReportSource = cr;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
