using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 

namespace Book_Rental_System
{
    public partial class MDI : Form
    {
        public static Form objlogin;
        public static Form objCategory;
        public MDI()
        {
            InitializeComponent();
        }
        private void MDI_Load(object sender, EventArgs e)
        {
            MDI f = new MDI();
            f.WindowState = FormWindowState.Maximized;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1Date.Text = DateTime.Now.ToLongDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl2Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void lbl2Time_Click(object sender, EventArgs e)
        {
            lbl2Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutobj = new AboutUs();
            aboutobj.MdiParent = this;
            aboutobj.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category catobj = new Category();
            catobj.MdiParent = this;
            catobj.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer custobj = new Customer();
            custobj.MdiParent = this;
            custobj.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book bookobj = new Book();
            bookobj.MdiParent = this;
            bookobj.Show();
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publisher pubobj = new Publisher();
            pubobj.MdiParent = this;
            pubobj.Show();
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Book serobj = new Search_Book();
            serobj.MdiParent = this;
            serobj.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Customer sercustobj = new Search_Customer();
            sercustobj.MdiParent = this;
            sercustobj.Show();
        }

        private void publisherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Publisher serpubobj = new Search_Publisher();
            serpubobj.MdiParent = this;
            serpubobj.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_User newusrobj = new New_User();
            newusrobj.MdiParent = this;
            newusrobj.Show();           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password chngpassobj = new Change_Password();
            chngpassobj.MdiParent = this;
            chngpassobj.Show();           
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Remove_User objRem_User = new Remove_User();
            objRem_User.MdiParent = this;
            objRem_User.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Book objPur_Book = new Purchase_Book();
            objPur_Book.MdiParent = this;
            objPur_Book.Show();
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rental objRental = new Rental();
            objRental.MdiParent = this;
            objRental.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return objReturn = new Return();
            objReturn.MdiParent = this;
            objReturn.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Program.help);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Report objBook_rpt = new Book_Report();
            objBook_rpt.MdiParent = this;
            objBook_rpt.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Report objCustomer_rpt = new Customer_Report();
            objCustomer_rpt.MdiParent = this;
            objCustomer_rpt.Show();
        }

        private void publisherReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publisher_Report objPublisher_rpt = new Publisher_Report();
            objPublisher_rpt.MdiParent = this;
            objPublisher_rpt.Show();
        }

        private void billReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill_Report objBill_rpt = new Bill_Report();
            objBill_rpt.MdiParent = this;
            objBill_rpt.Show();
        }

        private void rentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rent_Report objRent_rpt = new Rent_Report();
            objRent_rpt.MdiParent = this;
            objRent_rpt.Show();
        }

        private void returnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Report objReturn_rpt = new Return_Report();
            objReturn_rpt.MdiParent = this;
            objReturn_rpt.Show();
        }
    }
}
