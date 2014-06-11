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
    public partial class New_User : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        public DataTable dt;
        public int pointer;
        public int maxrecords;
        
        public New_User()
        {
            InitializeComponent();
        }     
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConform_Password.Text)
            {
                MessageBox.Show("Password and Conform_Password is different.");
            }
            else
            {
                String sql = "INSERT INTO User_Master VALUES('" + txtUser_Name.Text + "','" + txtPassword.Text + "')";
                Execute(sql);
                MessageBox.Show("User is Created Successfully.");
                this.Close();
            }
        }

        private void New_User_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            pointer = 0;
            filldata();
        }
        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from User_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            maxrecords = dt.Rows.Count;
            //DataGridView1.DataSource = dt;
        }
        public void Execute(String sql)
        {
                cmd = new OleDbCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                filldata();
            
        }
    }
}
