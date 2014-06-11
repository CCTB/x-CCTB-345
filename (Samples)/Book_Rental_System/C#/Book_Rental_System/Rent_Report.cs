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
    public partial class Rent_Report : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;

        public Rent_Report()
        {
            InitializeComponent();
        }

        private void Rent_Report_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();

            da = new OleDbDataAdapter("Select * from Rent_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];

            Rent_ReportCrystalReport cr5 = new Rent_ReportCrystalReport();
            crystalReportViewer1.ReportSource = cr5;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
