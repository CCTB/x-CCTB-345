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
    public partial class Book : Form
    {
        public OleDbConnection conn;
        public OleDbDataAdapter da;
        public DataSet ds;
        public DataSet ds1 = new DataSet();
        public DataTable dt;
        public OleDbCommand cmd;
        public OleDbDataReader dr;
        public int maxrecords;
        public int pointer;
        static public int cnt;
        public string isbn;

        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(Program.cnstr);
            conn.Open();
            pointer = 0;
            filldata();
            navigation();
            fillcategorycombo();
            fillpublishercombo();
            //cleartextbox();
            btnSave.Enabled = false;
        }
        public void filldata()
        {
            da = new OleDbDataAdapter("Select * from Book_Master", conn);
            ds = new DataSet();
            da.Fill(ds1);
            dt = ds1.Tables[0];
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
                txtISBN.Text = ds1.Tables[0].Rows[pointer][0].ToString();
                cboCategory.Text = ds1.Tables[0].Rows[pointer][1].ToString();
                cboPublisher.Text = ds1.Tables[0].Rows[pointer][2].ToString();
                txtBook.Text = ds1.Tables[0].Rows[pointer][3].ToString();
                //dt.Rows[pointer].ItemArray[1].ToString();
                txtAuthor.Text = ds1.Tables[0].Rows[pointer][4].ToString();
                txtPrice.Text = ds1.Tables[0].Rows[pointer][5].ToString();
                txtTotal_Quantity.Text = ds1.Tables[0].Rows[pointer][6].ToString();
                isbn = ds1.Tables[0].Rows[pointer][0].ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtISBN.Focus();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no data, Please Insert the Record.");
            }
            txtISBN.Clear();
            txtBook.Clear();
            txtAuthor.Clear();
            txtPrice.Clear();
            txtTotal_Quantity.Clear();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean inc = false;
            if (txtISBN.Text == "")
            {
                DialogResult isbn = MessageBox.Show("The ISBN Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cboCategory.Text == "")
            {
                DialogResult cat = MessageBox.Show("The Category Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cboPublisher.Text == "")
            {
                DialogResult pub = MessageBox.Show("The Publisher Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtBook.Text == "")
            {
                DialogResult book = MessageBox.Show("The Book Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtAuthor.Text == "")
            {
                DialogResult auth = MessageBox.Show("The Author Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtPrice.Text == "")
            {
                DialogResult price = MessageBox.Show("The Price Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtTotal_Quantity.Text == "")
            {
                DialogResult totqty = MessageBox.Show("The Total Quantity Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string cmdstr = "SELECT ISBN FROM Book_Master WHERE (ISBN = '" + txtISBN.Text + "')";
                cmd = new OleDbCommand(cmdstr, conn);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    if (txtISBN.Text == dr.GetValue(0).ToString())
                    {
                        DialogResult sav = MessageBox.Show("The Record is Duplicate, Please Insert Different Record.", "Duplicate Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        cleartextbox();
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
                    string sql = "INSERT INTO Book_Master (ISBN,Category,Publisher,Book,Author,Price,Total_Quantity) VALUES('" + txtISBN.Text + "','" + cboCategory.Text + "','" + cboPublisher.Text + "','" + txtBook.Text + "','" + txtAuthor.Text + "','" + txtPrice.Text + "','" + txtTotal_Quantity.Text + "')";
                    Execute(sql);
                    DialogResult save = MessageBox.Show("Book is saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartextbox();
                }
            }
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             if (txtISBN.Text == "")
            {
                DialogResult isbn = MessageBox.Show("The ISBN Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cboCategory.Text == "")
            {
                DialogResult cat = MessageBox.Show("The Category Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cboPublisher.Text == "")
            {
                DialogResult pub = MessageBox.Show("The Publisher Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtBook.Text == "")
            {
                DialogResult book = MessageBox.Show("The Book Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtAuthor.Text == "")
            {
                DialogResult auth = MessageBox.Show("The Author Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtPrice.Text == "")
            {
                DialogResult price = MessageBox.Show("The Price Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
             else if (txtTotal_Quantity.Text == "")
             {
                 DialogResult totqty = MessageBox.Show("The Total Quantity Field is Empty.", "Blank Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
             }
             else
             {
                 string sql = "UPDATE Book_Master SET ISBN = '" + txtISBN.Text + "', Category = '" + cboCategory.Text + "', Publisher = '" + cboPublisher.Text + "', Book = '" + txtBook.Text + "', Author = '" + txtAuthor.Text + "', Price = '" + txtPrice.Text + "', Total_Quantity = '" + txtTotal_Quantity.Text + "' WHERE (ISBN = '" + isbn + "')";
                 Execute(sql);
                 DialogResult updt = MessageBox.Show("Record is updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 btnSave.Enabled = false;
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
            btnSave.Enabled = false;
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
                        string sql = "DELETE * FROM Book_Master WHERE ISBN='" + isbn + "'";
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

        private void btnFirstRecord_Click(object sender, EventArgs e)
        {
            pointer = 0;
            navigation();
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

        private void btnLastRecord_Click(object sender, EventArgs e)
        {
            pointer = maxrecords - 1;
            navigation();
        }
        public void fillcategorycombo()
        {
            da = new OleDbDataAdapter("SELECT Category FROM Category_Master ",conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            for (int i=0; i < dt.Rows.Count; i++)
            {
                cboCategory.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT * FROM Category_Master WHERE Category='" + cboCategory.SelectedItem.ToString() + "'",conn);
            ds = new DataSet();
            da.Fill(ds);
        }
        public void fillpublishercombo()
        {
            da = new OleDbDataAdapter("SELECT Name FROM Publisher_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                cboPublisher.Items.Add(dt.Rows[j].ItemArray[0]);
            }
        }
        private void cboPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT Name FROM Publisher_Master", conn);
            ds = new DataSet();
            da.Fill(ds);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void cleartextbox()
        {
            txtTotal_Quantity.Clear();
            txtAuthor.Clear();
            txtBook.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult num = MessageBox.Show("Only Numbers are allowed.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTotal_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                DialogResult num = MessageBox.Show("Only Numbers are allowed.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                DialogResult Name = MessageBox.Show("Only Letters are allowed.", "Invalid Key", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
