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
    public partial class Remove_User : Form
    {
        // Database connectivity // Variable declaration.
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        public int maxrecords;
        public int pointer;
        static public int cnt;
        Boolean inc = false;

        public Remove_User()
        {
            InitializeComponent();
        }
        // Form Load Event.
        private void Remove_User_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            pointer = 0;
            filldata();
            navigation();
            fillremoveusercmbo();

        }
        // User Define Method/Function
        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from User_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            maxrecords = dt.Rows.Count;
        }
        // User Define Method/Function
        public void navigation()
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(" There is no data available.");
            }
            else
            {
                cmbUser_Name.Text = dt.Rows[pointer].ItemArray[0].ToString();
            }
        }
        // User Define Method/Function
        public void Execute(String sql)
        {
            cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            filldata();
        }
        // Cancel Button Event.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // Combo Box for Remove User Method.
        public void fillremoveusercmbo()
        {
            da = new OleDbDataAdapter("SELECT User_Name FROM User_Master ", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbUser_Name.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
            
        // Display the ComboBox Value from Database.
        private void cmbUser_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT User_Name FROM User_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
        }
        // Remove Button Code.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            conn.Open();
            string cmdstr = "SELECT User_Name, Password FROM User_Master WHERE (User_Name = '" + cmbUser_Name.Text + "') AND (Password = '" + txtPassword.Text + "')";
            cmd = new OleDbCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                if (cmbUser_Name.Text == dr.GetValue(0).ToString() && txtPassword.Text == dr.GetValue(1).ToString())
                {
                    string User_Name = dt.Rows[pointer].ItemArray[0].ToString();
                    string sql = "DELETE User_Name,Password FROM User_Master WHERE (User_Name = '" + cmbUser_Name.Text + "') AND (Password = '"+txtPassword.Text+"')";
                    Execute(sql);
                    MessageBox.Show("User is successfully deleted.");
                    filldata();
                    navigation();
                    dr.Close();
                    this.Close();
                    inc = true;
                    break;
                }
                else
                {
                    dr.NextResult();
                }
            }
            if (inc == false)
            {
                MessageBox.Show("Invalid Password ! Please Try Again.");
                txtPassword.Clear();
            }
            dr.Close();
        }

        private void Remove_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
