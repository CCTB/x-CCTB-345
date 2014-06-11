using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Close the program/form
            this.Close();
        }

        private void LaunchOrActivate<T>() where T : Form, new()
        {
            T theForm = GetChildForm<T>();
            if (theForm == null)
            {
                theForm = new T();
                theForm.MdiParent = this;
                theForm.WindowState = FormWindowState.Maximized;
                theForm.Show();
            }
            else
            {
                theForm.WindowState = FormWindowState.Maximized;
                theForm.Focus();
            }
        }

        private T GetChildForm<T>() where T : Form
        {
            foreach (var childForm in MdiChildren)
            {
                if (childForm is T)
                {
                    return (T)childForm;
                }
            }
            return null;
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Open a form as a dialog box
            LaunchOrActivate<ViewRegions>();
            //frm.ShowDialog(); // Execution of this method will PAUSE here until the dialog box (ViewRegions) is closed
            // resume after the dialog box is closed

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: 1b) Open a ViewShippers form as a child form using .Show()
        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void errorLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutThisFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: 1a) Open an About form as a dialog using .ShowDialog()
            //           Show a MessageBox afterwards
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartDateTime.Text = "App started on: " + DateTime.Now.ToString();
        }
    }
}
