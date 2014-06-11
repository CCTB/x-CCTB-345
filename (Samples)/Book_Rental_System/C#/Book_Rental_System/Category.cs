using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Book_Rental_System
{
    public partial class Category : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        public int maxrecords;
        public int pointer;
        public string catid;
        

        public Category()
        {
                InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
            pointer = 0;
            filldata();
            navigation();
            btnSave.Enabled = false;
        }
        
        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from Category_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            maxrecords = dt.Rows.Count;
            
        }

        public void navigation()
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(" There is no data available.");
            }
            else
            {
                txtCategory_ID.Text = dt.Rows[pointer].ItemArray[0].ToString();
                txtCategory.Text = dt.Rows[pointer].ItemArray[1].ToString();
                catid = dt.Rows[pointer].ItemArray[0].ToString(); 
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            txtCategory_ID.Focus();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no data, Please Insert the Record.");
            }
            txtCategory_ID.Clear();
            txtCategory.Clear();
            btnSave.Enabled = true;
        }
       
        public void btnSave_Click(object sender, EventArgs e)
        {
            Boolean inc = false;
            if (txtCategory_ID.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Category_ID Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtCategory.Text == "")
            {
                DialogResult save = MessageBox.Show("The Category Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string cmdstr = "SELECT Category_ID FROM Category_Master WHERE (Category_ID = '" + txtCategory_ID.Text + "')";
                cmd = new OleDbCommand(cmdstr, conn);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    if (txtCategory_ID.Text == dr.GetValue(0).ToString())
                    {
                        DialogResult sav = MessageBox.Show("The Record is Duplicate, Please Insert Different Record.", "Duplicate Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                    string sql = "INSERT INTO Category_Master (Category_ID,Category) VALUES('" + txtCategory_ID.Text + "','" + txtCategory.Text + "')";
                    Execute(sql);
                    MessageBox.Show("Category is saved Successfully.");
                    cleartextbox();
                }
                btnSave.Enabled = false;
            }
        }

        public void Execute(String sql)
        {
                cmd = new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
                filldata();
        }
 
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pointer < maxrecords - 1)
            {
                pointer++;
                navigation();
            }
            else
            {
                DialogResult last = MessageBox.Show("This is the Last Record.","Record",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pointer > 0)
            {
                pointer--;
                navigation();
            }
            else
            {
                DialogResult first = MessageBox.Show("This is the First Record","Record",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }

        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            pointer = maxrecords - 1;
            navigation();
        }

        private void btnFirstRecord_Click(object sender, EventArgs e)
        {
            pointer = 0;
            navigation();
        }  

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCategory_ID.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Category_ID Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtCategory.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Category Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "UPDATE Category_Master SET Category_ID = '" + txtCategory_ID.Text + "', Category = '" + txtCategory.Text + "' WHERE Category_ID = '" + catid + "'";
                Execute(sql);
                DialogResult updt = MessageBox.Show("Record is updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no record available for delete.");
                cleartextbox();
            }
            else
            {
                DialogResult des = MessageBox.Show("Are you sure want to delete this record.", "Confirm Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (des == DialogResult.Yes)
                {
                    try
                    {
                        string Category_ID = dt.Rows[pointer].ItemArray[0].ToString();
                        string sql = "DELETE Category_ID,Category FROM Category_Master WHERE Category_ID='" + catid + "'";
                        Execute(sql);
                        MessageBox.Show("Record is deleted.");
                        filldata();
                        if (pointer < maxrecords - 1)
                        {
                            pointer++;
                            navigation();
                        }
                        else if (pointer > 0)
                        {
                            pointer--;
                            navigation();
                        }
                        else
                        {
                            MessageBox.Show("There is no Record.");
                            cleartextbox();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Error");
                    }
                }

            }
        }
        public void cleartextbox()
        {
            txtCategory.Clear();
            txtCategory_ID.Clear();
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                DialogResult catkey =  MessageBox.Show("Digits are not allowed. Please Write Category in Letters.","Invalid Key Press",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
            }
        }
    }
}
