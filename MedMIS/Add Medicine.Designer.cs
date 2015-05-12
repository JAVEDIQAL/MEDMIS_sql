namespace MedMIS
{
    partial class Add_Medicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, http://kitabosunnat.com/index.phpfalse.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Medicine));
            this.label1 = new System.Windows.Forms.Label();
            this.Medicine_Name = new System.Windows.Forms.Label();
            this.Med_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mfg_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Add_medcn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstocks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Entries of Medicines";
            // 
            // Medicine_Name
            // 
            this.Medicine_Name.AutoSize = true;
            this.Medicine_Name.Location = new System.Drawing.Point(63, 68);
            this.Medicine_Name.Name = "Medicine_Name";
            this.Medicine_Name.Size = new System.Drawing.Size(81, 13);
            this.Medicine_Name.TabIndex = 1;
            this.Medicine_Name.Text = "Medicine Name";
            // 
            // Med_name
            // 
            this.Med_name.Location = new System.Drawing.Point(167, 65);
            this.Med_name.Name = "Med_name";
            this.Med_name.Size = new System.Drawing.Size(226, 20);
            this.Med_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manafacturer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mfg.  Date";
            // 
            // Mfg_date
            // 
            this.Mfg_date.Location = new System.Drawing.Point(167, 113);
            this.Mfg_date.Name = "Mfg_date";
            this.Mfg_date.Size = new System.Drawing.Size(226, 20);
            this.Mfg_date.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exp. Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(167, 211);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // Add_medcn
            // 
            this.Add_medcn.BackgroundImage = global::MedMIS.Properties.Resources._1386857181_add2_;
            this.Add_medcn.Location = new System.Drawing.Point(489, 236);
            this.Add_medcn.Name = "Add_medcn";
            this.Add_medcn.Size = new System.Drawing.Size(129, 123);
            this.Add_medcn.TabIndex = 9;
            this.Add_medcn.UseVisualStyleBackColor = true;
            this.Add_medcn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stock";
            // 
            // txtstocks
            // 
            this.txtstocks.Location = new System.Drawing.Point(167, 260);
            this.txtstocks.Name = "txtstocks";
            this.txtstocks.Size = new System.Drawing.Size(119, 20);
            this.txtstocks.TabIndex = 11;
            this.txtstocks.TextChanged += new System.EventHandler(this.txtstocks_TextChanged);
            // 
            // Add_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 359);
            this.Controls.Add(this.txtstocks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add_medcn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mfg_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Med_name);
            this.Controls.Add(this.Medicine_Name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Medicine";
            this.Text = "Add_Medicine";
            this.Load += new System.EventHandler(this.Add_Medicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Medicine_Name;
        private System.Windows.Forms.TextBox Med_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Mfg_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Add_medcn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstocks;
       // private System.Windows.Forms.Button button1;

    }
}