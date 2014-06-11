namespace Book_Rental_System
{
    partial class Return_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer6 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer6
            // 
            this.crystalReportViewer6.ActiveViewIndex = -1;
            this.crystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer6.DisplayGroupTree = false;
            this.crystalReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer6.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer6.Name = "crystalReportViewer6";
            this.crystalReportViewer6.SelectionFormula = "";
            this.crystalReportViewer6.Size = new System.Drawing.Size(973, 500);
            this.crystalReportViewer6.TabIndex = 0;
            this.crystalReportViewer6.ViewTimeSelectionFormula = "";
            this.crystalReportViewer6.Load += new System.EventHandler(this.crystalReportViewer6_Load);
            // 
            // Return_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 500);
            this.Controls.Add(this.crystalReportViewer6);
            this.Name = "Return_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return_Report";
            this.Load += new System.EventHandler(this.Return_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer6;
    }
}