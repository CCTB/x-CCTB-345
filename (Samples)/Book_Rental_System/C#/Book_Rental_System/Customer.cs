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
    public partial class Customer : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataTable dt;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        public int maxrecords;
        public int pointer;
        public string custid;

        public Customer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCustomer_ID.Focus();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no data, Please Insert the Record.");
            }
            txtCustomer_ID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtProof.Clear();
            btnSave.Enabled = true;
        }

        private void Customer_Load(object sender, EventArgs e)
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
            da = new OleDbDataAdapter("Select * from Customer_Master", conn);
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
                txtCustomer_ID.Text = dt.Rows[pointer].ItemArray[0].ToString();
                txtName.Text = dt.Rows[pointer].ItemArray[1].ToString();
                txtPhone.Text = dt.Rows[pointer].ItemArray[2].ToString();
                txtAddress.Text = dt.Rows[pointer].ItemArray[3].ToString();
                txtProof.Text = dt.Rows[pointer].ItemArray[4].ToString();
                custid = dt.Rows[pointer].ItemArray[0].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean inc = false;
            if (txtCustomer_ID.Text == "")
            {
                DialogResult cust = MessageBox.Show("The Customer_ID Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtName.Text == "")
            {
                DialogResult name = MessageBox.Show("The Name Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtPhone.Text == "")
            {
                DialogResult phone = MessageBox.Show("The Phone Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtAddress.Text == "")
            {
                DialogResult add = MessageBox.Show("The Address Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtProof.Text == "")
            {
                DialogResult proof = MessageBox.Show("The Proof Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string cmdstr = "SELECT Customer_ID FROM Customer_Master WHERE (Customer_ID = '" + txtCustomer_ID.Text + "')";
                cmd = new OleDbCommand(cmdstr, conn);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    if (txtCustomer_ID.Text == dr.GetValue(0).ToString())
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
                    String sql = "INSERT INTO Customer_Master (Customer_ID,Name,Phone,Address,Proof) VALUES('" + txtCustomer_ID.Text + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + txtProof.Text + "')";
                    Execute(sql);
                    DialogResult save = MessageBox.Show("Customer is saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartextbox();
                }
                btnSave.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCustomer_ID.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Customer_ID Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            else if (txtProof.Text == "")
            {
                DialogResult sav = MessageBox.Show("The Proof Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "UPDATE Customer_Master SET Customer_ID = '" + txtCustomer_ID.Text + "', Name = '" + txtName.Text + "', Phone = '" + txtPhone.Text + "', Address = '" + txtAddress.Text + "', Proof= '" + txtProof.Text + "' WHERE Customer_ID = '" + custid + "'";
                Execute(sql);
                DialogResult updt = MessageBox.Show("Record is updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult last = MessageBox.Show("This is the Last Record.", "Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                DialogResult first = MessageBox.Show("This is the First Record", "Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                DialogResult dell = MessageBox.Show("There is no record available for delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleartextbox();
            }
            else
            {
                DialogResult del = MessageBox.Show("Are you sure want to Delete this Record.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (del == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "DELETE * FROM Customer_Master WHERE Customer_ID='" + custid + "'";
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
        public void cleartextbox()
        {
            txtAddress.Clear();
            txtCustomer_ID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtProof.Clear();
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
                DialogResult num = MessageBox.Show("Only Numbers are allowed.","Invalid Key",MessageBoxButtons.OK,MessageBoxIcon.Warning);               
            }
        }
    }
}
