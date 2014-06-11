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
    public partial class Publisher : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        public int maxrecords;
        public int pointer;
        static public int cnt;
        public string pubid;

        public Publisher()
        {
            cnt++;
            InitializeComponent();
        }

        private void Publisher_Load(object sender, EventArgs e)
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
            da = new OleDbDataAdapter("Select * from Publisher_Master", conn);
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
                txtPublisher_ID.Text = dt.Rows[pointer].ItemArray[0].ToString();
                txtName.Text = dt.Rows[pointer].ItemArray[1].ToString();
                txtAddress.Text = dt.Rows[pointer].ItemArray[2].ToString();
                txtPhone.Text = dt.Rows[pointer].ItemArray[3].ToString();
                pubid = dt.Rows[pointer].ItemArray[0].ToString(); 
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtPublisher_ID.Focus();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no data, Please Insert the Record.");
            }
            txtPublisher_ID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            btnSave.Enabled = true;
       }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean inc = false;
            if (txtPublisher_ID.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Publisher_ID Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtName.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Name Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtAddress.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Address Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtPhone.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Phone Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string cmdstr = "SELECT Publisher_ID FROM Publisher_Master WHERE (Publisher_ID = '" + txtPublisher_ID.Text + "')";
                cmd = new OleDbCommand(cmdstr, conn);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    if (txtPublisher_ID.Text == dr.GetValue(0).ToString())
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
                    string sql = "INSERT INTO Publisher_Master (Publisher_ID,Name,Address,Phone) VALUES('" + txtPublisher_ID.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "')";
                    Execute(sql);
                    DialogResult save = MessageBox.Show("Publisher is saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartextbox();
                }
            }
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {    
            if (txtPublisher_ID.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Publisher_ID Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtName.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Name Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtAddress.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Address Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtPhone.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Phone Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "UPDATE Publisher_Master SET Publisher_ID = '" + txtPublisher_ID.Text + "', Name = '" + txtName.Text + "', Address = '" + txtAddress.Text + "', Phone = '" + txtPhone.Text + "' WHERE (Publisher_ID = '" + pubid + "')";
                Execute(sql);
                MessageBox.Show("Record is updated.");
            }
        }
        public void Execute(String sql)
        {
           cmd = new OleDbCommand(sql, conn);
           cmd.ExecuteNonQuery();
           filldata();
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
                        string Publisher_ID = dt.Rows[pointer].ItemArray[0].ToString();
                        string sql = "DELETE * FROM Publisher_Master WHERE Publisher_ID='" + pubid + "'";
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
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }

            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                MessageBox.Show("This is the Last Record.");
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
                MessageBox.Show("This is the First Record");
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
        public void cleartextbox()
        {
            txtPublisher_ID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                DialogResult Name = MessageBox.Show("Only Letters are allowed.", "Invalid Key", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult num = MessageBox.Show("Only Numbers are allowed.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
     }
}
