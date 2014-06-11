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
    public partial class Return_Report : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;

        public Return_Report()
        {
            InitializeComponent();
        }

        private void Return_Report_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();

            da = new OleDbDataAdapter("Select * from Return_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];

            Return_CrystalReport cr6 = new Return_CrystalReport();
            crystalReportViewer6.ReportSource = cr6;
        }

        private void crystalReportViewer6_Load(object sender, EventArgs e)
        {

        }
    }
}
