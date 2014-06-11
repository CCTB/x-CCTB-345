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

    public partial class Change_Password : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public OleDbDataReader dr;
        public OleDbCommand cmd;
        public DataSet ds;
        public DataTable dt;
        public int pointer = 0;
        public int maxrecords;
        public Boolean inc = true;
        
        
        public Change_Password()
        {
            InitializeComponent();
            
        }
        
        private void btnChange_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
            string cmdstr = "SELECT * FROM User_Master  WHERE User_Name = '" + txtUser_Name.Text + "' AND Password = '" + txtOld_Password.Text + "'";
            cmd = new OleDbCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                if (txtUser_Name.Text == dr.GetValue(0).ToString() && txtOld_Password.Text == dr.GetValue(1).ToString())
                {
                    if (txtNew_Password.Text != txtRetype_Password.Text)
                    {
                        MessageBox.Show("New Password and Retype Password is not Same.");
                        cleartextboxes();
                    }
                    else
                    {
                        string sql = "UPDATE User_Master SET [Password] = '" + txtNew_Password.Text + "' WHERE (User_Name = '" + txtUser_Name.Text + "')";
                        //"UPDATE User_Master SET Password = '1234' WHERE User_Name = 'system'";
                        MessageBox.Show(sql);
                        Execute(sql);
                        MessageBox.Show("Password is successfully changed.");
                        this.Hide();
                        dr.Close();
                        inc = true;
                        break;
                    }
                }
                else
                {
                    dr.NextResult();
                    //MessageBox.Show("User Name and Old Password is not true.");
                }
            }
            
            if (inc == false)
            {
                MessageBox.Show("Invalid User Name or Password !");
                cleartextboxes();
            }
        }
        public void Execute(String sql)
        {
           cmd = new OleDbCommand(sql, conn);
           cmd.ExecuteNonQuery();
           filldata();
        }
        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from User_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            maxrecords = dt.Rows.Count;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void cleartextboxes()
        {
            txtNew_Password.Clear();
            txtOld_Password.Clear();
            txtRetype_Password.Clear();
            txtUser_Name.Clear();
        }
    }
}
