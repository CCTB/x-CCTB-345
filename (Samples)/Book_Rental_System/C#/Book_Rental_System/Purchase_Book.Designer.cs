namespace Book_Rental_System
{
    partial class Purchase_Book
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotal_Price = new System.Windows.Forms.TextBox();
            this.txtBook_Price = new System.Windows.Forms.TextBox();
            this.txtQuantiry = new System.Windows.Forms.TextBox();
            this.txtPublisher_Name = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.lblCustomer_Name = new System.Windows.Forms.Label();
            this.lblTotal_Price = new System.Windows.Forms.Label();
            this.lblBook_Price = new System.Windows.Forms.Label();
            this.lblPublisher_Name = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.cmbISBN = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Book_Rental_System.Properties.Resources.Purchase_Book;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCust_Name);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtTotal_Price);
            this.panel1.Controls.Add(this.txtBook_Price);
            this.panel1.Controls.Add(this.txtQuantiry);
            this.panel1.Controls.Add(this.txtPublisher_Name);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.txtBook);
            this.panel1.Controls.Add(this.lblCustomer_Name);
            this.panel1.Controls.Add(this.lblTotal_Price);
            this.panel1.Controls.Add(this.lblBook_Price);
            this.panel1.Controls.Add(this.lblPublisher_Name);
            this.panel1.Controls.Add(this.lblQty);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblAuthor);
            this.panel1.Controls.Add(this.lblBook);
            this.panel1.Controls.Add(this.cmbISBN);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Location = new System.Drawing.Point(34, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 308);
            this.panel1.TabIndex = 1;
            // 
            // cmbCust_Name
            // 
            this.cmbCust_Name.FormattingEnabled = true;
            this.cmbCust_Name.Location = new System.Drawing.Point(140, 110);
            this.cmbCust_Name.Name = "cmbCust_Name";
            this.cmbCust_Name.Size = new System.Drawing.Size(281, 21);
            this.cmbCust_Name.TabIndex = 20;
            this.cmbCust_Name.SelectedIndexChanged += new System.EventHandler(this.cmbCust_Name_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 23);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2010, 5, 16, 3, 47, 54, 0);
            // 
            // txtTotal_Price
            // 
            this.txtTotal_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal_Price.Location = new System.Drawing.Point(140, 266);
            this.txtTotal_Price.Name = "txtTotal_Price";
            this.txtTotal_Price.Size = new System.Drawing.Size(281, 20);
            this.txtTotal_Price.TabIndex = 18;
            
            this.txtTotal_Price.Enter += new System.EventHandler(this.txtTotal_Price_Enter);
            // 
            // txtBook_Price
            // 
            this.txtBook_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBook_Price.Location = new System.Drawing.Point(140, 235);
            this.txtBook_Price.Name = "txtBook_Price";
            this.txtBook_Price.Size = new System.Drawing.Size(281, 20);
            this.txtBook_Price.TabIndex = 17;
            this.txtBook_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBook_Price_KeyPress);
            // 
            // txtQuantiry
            // 
            this.txtQuantiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantiry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantiry.Location = new System.Drawing.Point(140, 204);
            this.txtQuantiry.Name = "txtQuantiry";
            this.txtQuantiry.Size = new System.Drawing.Size(281, 20);
            this.txtQuantiry.TabIndex = 16;
            this.txtQuantiry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantiry_KeyPress);
            // 
            // txtPublisher_Name
            // 
            this.txtPublisher_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPublisher_Name.Location = new System.Drawing.Point(140, 173);
            this.txtPublisher_Name.Name = "txtPublisher_Name";
            this.txtPublisher_Name.Size = new System.Drawing.Size(281, 20);
            this.txtPublisher_Name.TabIndex = 15;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Location = new System.Drawing.Point(140, 80);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(281, 20);
            this.txtAuthor.TabIndex = 12;
            // 
            // txtBook
            // 
            this.txtBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBook.Location = new System.Drawing.Point(140, 49);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(281, 20);
            this.txtBook.TabIndex = 11;
            // 
            // lblCustomer_Name
            // 
            this.lblCustomer_Name.AutoSize = true;
            this.lblCustomer_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer_Name.Location = new System.Drawing.Point(16, 110);
            this.lblCustomer_Name.Name = "lblCustomer_Name";
            this.lblCustomer_Name.Size = new System.Drawing.Size(113, 19);
            this.lblCustomer_Name.TabIndex = 10;
            this.lblCustomer_Name.Text = "Customer Name";
            // 
            // lblTotal_Price
            // 
            this.lblTotal_Price.AutoSize = true;
            this.lblTotal_Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal_Price.Location = new System.Drawing.Point(16, 265);
            this.lblTotal_Price.Name = "lblTotal_Price";
            this.lblTotal_Price.Size = new System.Drawing.Size(77, 19);
            this.lblTotal_Price.TabIndex = 9;
            this.lblTotal_Price.Text = "Total Price";
            // 
            // lblBook_Price
            // 
            this.lblBook_Price.AutoSize = true;
            this.lblBook_Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_Price.Location = new System.Drawing.Point(16, 234);
            this.lblBook_Price.Name = "lblBook_Price";
            this.lblBook_Price.Size = new System.Drawing.Size(77, 19);
            this.lblBook_Price.TabIndex = 8;
            this.lblBook_Price.Text = "Book Price";
            // 
            // lblPublisher_Name
            // 
            this.lblPublisher_Name.AutoSize = true;
            this.lblPublisher_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher_Name.Location = new System.Drawing.Point(16, 172);
            this.lblPublisher_Name.Name = "lblPublisher_Name";
            this.lblPublisher_Name.Size = new System.Drawing.Size(111, 19);
            this.lblPublisher_Name.TabIndex = 7;
            this.lblPublisher_Name.Text = "Publisher Name";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(16, 203);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(65, 19);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Quantity";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(16, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 19);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(17, 79);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 19);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(16, 48);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(41, 19);
            this.lblBook.TabIndex = 2;
            this.lblBook.Text = "Book";
            // 
            // cmbISBN
            // 
            this.cmbISBN.FormattingEnabled = true;
            this.cmbISBN.Location = new System.Drawing.Point(140, 17);
            this.cmbISBN.Name = "cmbISBN";
            this.cmbISBN.Size = new System.Drawing.Size(281, 21);
            this.cmbISBN.TabIndex = 1;
            this.cmbISBN.SelectedIndexChanged += new System.EventHandler(this.cmbISBN_SelectedIndexChanged);
            this.cmbISBN.SelectedValueChanged += new System.EventHandler(this.cmbISBN_SelectedValueChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(16, 17);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(39, 19);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnPurchase);
            this.panel2.Location = new System.Drawing.Point(34, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 60);
            this.panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(192, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(103, 17);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.Text = "&Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // Purchase_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Purchase_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_Book";
            this.Load += new System.EventHandler(this.Purchase_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cmbISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPublisher_Name;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotal_Price;
        private System.Windows.Forms.Label lblBook_Price;
        private System.Windows.Forms.Label lblCustomer_Name;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtPublisher_Name;
        private System.Windows.Forms.TextBox txtQuantiry;
        private System.Windows.Forms.TextBox txtBook_Price;
        private System.Windows.Forms.TextBox txtTotal_Price;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ComboBox cmbCust_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}