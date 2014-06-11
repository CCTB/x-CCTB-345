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
    public partial class Publisher_Report : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;

        public Publisher_Report()
        {
            InitializeComponent();
        }

        private void Publisher_Report_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();

            da = new OleDbDataAdapter("Select * from Publisher_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];

            Publisher_CrystalReport cr4 = new Publisher_CrystalReport();
            crystalReportViewer4.ReportSource = cr4;
        }

        private void crystalReportViewer4_Load(object sender, EventArgs e)
        {

        }
    }
}
