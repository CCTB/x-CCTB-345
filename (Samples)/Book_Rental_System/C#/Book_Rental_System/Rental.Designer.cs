namespace Book_Rental_System
{
    partial class Rental
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCust_Name = new System.Windows.Forms.ComboBox();
            this.txtTotalRent = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.txtPublisher_Name = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.cmbISBN = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblTotalRent = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblRentPrice = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Book_Rental_System.Properties.Resources.Rental;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCust_Name);
            this.panel1.Controls.Add(this.txtTotalRent);
            this.panel1.Controls.Add(this.txtDays);
            this.panel1.Controls.Add(this.txtRentPrice);
            this.panel1.Controls.Add(this.txtPublisher_Name);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.txtBook);
            this.panel1.Controls.Add(this.cmbISBN);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblTotalRent);
            this.panel1.Controls.Add(this.lblDays);
            this.panel1.Controls.Add(this.lblRentPrice);
            this.panel1.Controls.Add(this.lblPublisher);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Controls.Add(this.lblBook);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 312);
            this.panel1.TabIndex = 1;
            // 
            // cmbCust_Name
            // 
            this.cmbCust_Name.FormattingEnabled = true;
            this.cmbCust_Name.Location = new System.Drawing.Point(139, 275);
            this.cmbCust_Name.Name = "cmbCust_Name";
            this.cmbCust_Name.Size = new System.Drawing.Size(245, 21);
            this.cmbCust_Name.TabIndex = 15;
            this.cmbCust_Name.SelectedIndexChanged += new System.EventHandler(this.cmbCust_Name_SelectedIndexChanged);
            // 
            // txtTotalRent
            // 
            this.txtTotalRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalRent.Location = new System.Drawing.Point(139, 238);
            this.txtTotalRent.Name = "txtTotalRent";
            this.txtTotalRent.Size = new System.Drawing.Size(245, 20);
            this.txtTotalRent.TabIndex = 14;
            this.txtTotalRent.Enter += new System.EventHandler(this.txtTotalRent_Enter);
            // 
            // txtDays
            // 
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDays.Location = new System.Drawing.Point(139, 204);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(245, 20);
            this.txtDays.TabIndex = 13;
            this.txtDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDays_KeyPress);
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentPrice.Location = new System.Drawing.Point(139, 170);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(245, 20);
            this.txtRentPrice.TabIndex = 12;
            this.txtRentPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentPrice_KeyPress);
            // 
            // txtPublisher_Name
            // 
            this.txtPublisher_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPublisher_Name.Location = new System.Drawing.Point(139, 132);
            this.txtPublisher_Name.Name = "txtPublisher_Name";
            this.txtPublisher_Name.Size = new System.Drawing.Size(245, 20);
            this.txtPublisher_Name.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Location = new System.Drawing.Point(139, 92);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(245, 20);
            this.txtAuthor.TabIndex = 10;
            // 
            // txtBook
            // 
            this.txtBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBook.Location = new System.Drawing.Point(139, 54);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(245, 20);
            this.txtBook.TabIndex = 9;
            // 
            // cmbISBN
            // 
            this.cmbISBN.FormattingEnabled = true;
            this.cmbISBN.Location = new System.Drawing.Point(139, 15);
            this.cmbISBN.Name = "cmbISBN";
            this.cmbISBN.Size = new System.Drawing.Size(245, 21);
            this.cmbISBN.TabIndex = 8;
            this.cmbISBN.SelectedIndexChanged += new System.EventHandler(this.cmbISBN_SelectedIndexChanged);
            this.cmbISBN.SelectedValueChanged += new System.EventHandler(this.cmbISBN_SelectedValueChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(22, 278);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(113, 19);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblTotalRent
            // 
            this.lblTotalRent.AutoSize = true;
            this.lblTotalRent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRent.Location = new System.Drawing.Point(22, 239);
            this.lblTotalRent.Name = "lblTotalRent";
            this.lblTotalRent.Size = new System.Drawing.Size(75, 19);
            this.lblTotalRent.TabIndex = 6;
            this.lblTotalRent.Text = "Total Rent";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(22, 206);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(41, 19);
            this.lblDays.TabIndex = 5;
            this.lblDays.Text = "Days";
            // 
            // lblRentPrice
            // 
            this.lblRentPrice.AutoSize = true;
            this.lblRentPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentPrice.Location = new System.Drawing.Point(22, 172);
            this.lblRentPrice.Name = "lblRentPrice";
            this.lblRentPrice.Size = new System.Drawing.Size(75, 19);
            this.lblRentPrice.TabIndex = 4;
            this.lblRentPrice.Text = "Rent Price";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(22, 134);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(69, 19);
            this.lblPublisher.TabIndex = 3;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(22, 94);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 19);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(22, 56);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(41, 19);
            this.lblBook.TabIndex = 1;
            this.lblBook.Text = "Book";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(22, 18);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(39, 19);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnRent);
            this.panel2.Location = new System.Drawing.Point(45, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 64);
            this.panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(309, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(97, 18);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "&Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblRentPrice;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblTotalRent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.TextBox txtTotalRent;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.TextBox txtPublisher_Name;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.ComboBox cmbISBN;
        private System.Windows.Forms.ComboBox cmbCust_Name;
    }
}