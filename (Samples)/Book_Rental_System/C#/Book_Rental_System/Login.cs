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
    public partial class Login : Form
    {
        public OleDbConnection cn;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        Boolean inc = false;
        public Login()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            cn = new OleDbConnection(Program.cnstr);
            cn.ConnectionString = Program.cnstr;
            cn.Open();
            MDI.objlogin = this;
            string cmdstr = "SELECT User_Name, Password FROM User_Master WHERE (User_Name = '" + txtUserName.Text + "') AND (Password = '" + txtPassword.Text + "')";
            cmd = new OleDbCommand(cmdstr, cn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                if (txtUserName.Text == dr.GetValue(0).ToString() && txtPassword.Text == dr.GetValue(1).ToString())
                {
                    MDI obmdi = new MDI();
                    MDI f = new MDI();
                    f.WindowState = FormWindowState.Maximized;
                    obmdi.Show();
                    this.Hide();
                    dr.Close();
                    inc = true;
                    break;
                }
                else
                {
                    dr.NextResult();
                }
            }
            
            if(inc == false)
            {
                MessageBox.Show("Invalid User Name or Password !");
                txtUserName.Clear();
                txtPassword.Clear();
            }
            dr.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkUnmask_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkUnmask.Checked == true)
            {
                this.txtPassword.PasswordChar = Convert.ToChar(0);
            }
            else
            {
                this.txtPassword.PasswordChar = '•';
            }
        }

        
    }
}
    