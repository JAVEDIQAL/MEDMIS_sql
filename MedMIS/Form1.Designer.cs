namespace MedMIS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.lstLocal = new System.Windows.Forms.ListView();
            this.Printbtn = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.prnt_rpt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Add_party = new System.Windows.Forms.Button();
            this.PartId = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totaldscnt = new System.Windows.Forms.TextBox();
            this.totalamnt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InvoiceNo = new System.Windows.Forms.TextBox();
            this.AddNew = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.qty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.combocompany = new System.Windows.Forms.ComboBox();
            this.combomedicine = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Refreshbtn);
            this.groupBox2.Controls.Add(this.lstLocal);
            this.groupBox2.Controls.Add(this.Printbtn);
            this.groupBox2.Controls.Add(this.Exit_button);
            this.groupBox2.Location = new System.Drawing.Point(297, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 212);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(602, 316);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 1;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // lstLocal
            // 
            this.lstLocal.Location = new System.Drawing.Point(6, 15);
            this.lstLocal.Name = "lstLocal";
            this.lstLocal.Size = new System.Drawing.Size(812, 191);
            this.lstLocal.TabIndex = 2;
            this.lstLocal.UseCompatibleStateImageBehavior = false;
            // 
            // Printbtn
            // 
            this.Printbtn.Location = new System.Drawing.Point(488, 316);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(75, 23);
            this.Printbtn.TabIndex = 0;
            this.Printbtn.Text = "Print";
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(701, 316);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "Exit";
            this.Exit_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // prnt_rpt
            // 
            this.prnt_rpt.Image = global::MedMIS.Properties.Resources.printButton;
            this.prnt_rpt.Location = new System.Drawing.Point(965, 591);
            this.prnt_rpt.Name = "prnt_rpt";
            this.prnt_rpt.Size = new System.Drawing.Size(114, 48);
            this.prnt_rpt.TabIndex = 1;
            this.prnt_rpt.UseVisualStyleBackColor = true;
            this.prnt_rpt.Click += new System.EventHandler(this.prnt_rpt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MedMIS.Properties.Resources.shaukat_Khanum;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 591);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::MedMIS.Properties.Resources.images1;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.discount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Add_party);
            this.groupBox1.Controls.Add(this.PartId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.AddNew);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.combocompany);
            this.groupBox1.Controls.Add(this.combomedicine);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(297, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(730, 228);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(52, 22);
            this.discount.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(665, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Discount";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(411, 225);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 22);
            this.Price.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Price";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Add_party
            // 
            this.Add_party.Location = new System.Drawing.Point(330, 132);
            this.Add_party.Name = "Add_party";
            this.Add_party.Size = new System.Drawing.Size(32, 23);
            this.Add_party.TabIndex = 16;
            this.Add_party.Text = "A";
            this.Add_party.UseVisualStyleBackColor = true;
            this.Add_party.Click += new System.EventHandler(this.Add_party_Click);
            // 
            // PartId
            // 
            this.PartId.FormattingEnabled = true;
            this.PartId.Location = new System.Drawing.Point(142, 133);
            this.PartId.Name = "PartId";
            this.PartId.Size = new System.Drawing.Size(179, 23);
            this.PartId.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Party/Customer ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.totaldscnt);
            this.groupBox4.Controls.Add(this.totalamnt);
            this.groupBox4.Location = new System.Drawing.Point(481, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 98);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Amount";
            // 
            // totaldscnt
            // 
            this.totaldscnt.Location = new System.Drawing.Point(81, 59);
            this.totaldscnt.Name = "totaldscnt";
            this.totaldscnt.Size = new System.Drawing.Size(155, 22);
            this.totaldscnt.TabIndex = 1;
            // 
            // totalamnt
            // 
            this.totalamnt.Location = new System.Drawing.Point(81, 21);
            this.totalamnt.Name = "totalamnt";
            this.totalamnt.Size = new System.Drawing.Size(155, 22);
            this.totalamnt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.InvoiceNo);
            this.groupBox3.Location = new System.Drawing.Point(40, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 98);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2015, 3, 21, 15, 20, 21, 0);
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.Location = new System.Drawing.Point(78, 59);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(197, 22);
            this.InvoiceNo.TabIndex = 6;
            this.InvoiceNo.TextChanged += new System.EventHandler(this.InvoiceNo_TextChanged);
            // 
            // AddNew
            // 
            this.AddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNew.Image = global::MedMIS.Properties.Resources.Database;
            this.AddNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddNew.Location = new System.Drawing.Point(668, 291);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(74, 51);
            this.AddNew.TabIndex = 12;
            this.AddNew.Text = "       Add";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Save
            // 
            this.Save.Image = global::MedMIS.Properties.Resources.Save_;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Save.Location = new System.Drawing.Point(562, 291);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 51);
            this.Save.TabIndex = 1;
            this.Save.Text = "       Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(588, 225);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(53, 22);
            this.qty.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Qty.";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(142, 222);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(179, 22);
            this.dateTimePicker3.TabIndex = 0;
            this.dateTimePicker3.Value = new System.DateTime(2015, 1, 2, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(496, 168);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2015, 1, 2, 0, 0, 0, 0);
            // 
            // combocompany
            // 
            this.combocompany.FormattingEnabled = true;
            this.combocompany.Location = new System.Drawing.Point(142, 175);
            this.combocompany.Name = "combocompany";
            this.combocompany.Size = new System.Drawing.Size(179, 23);
            this.combocompany.TabIndex = 9;
            // 
            // combomedicine
            // 
            this.combomedicine.FormattingEnabled = true;
            this.combomedicine.Location = new System.Drawing.Point(488, 124);
            this.combomedicine.Name = "combomedicine";
            this.combomedicine.Size = new System.Drawing.Size(233, 23);
            this.combomedicine.Sorted = true;
            this.combomedicine.TabIndex = 8;
            this.combomedicine.SelectedIndexChanged += new System.EventHandler(this.combomedicine_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expiry Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manafacuture Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicine Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 640);
            this.Controls.Add(this.prnt_rpt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Billing Info.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox combocompany;
        private System.Windows.Forms.ComboBox combomedicine;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox InvoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListView lstLocal;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Add_party;
        private System.Windows.Forms.ComboBox PartId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totaldscnt;
        private System.Windows.Forms.TextBox totalamnt;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button prnt_rpt;
    }
}

