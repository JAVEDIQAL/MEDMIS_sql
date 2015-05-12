namespace MedMIS
{
    partial class Add_Party
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Party));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CP_id = new System.Windows.Forms.TextBox();
            this.txtAddrss = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnupdt = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(139, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer/Party Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer/Party Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact No";
            // 
            // CP_id
            // 
            this.CP_id.Location = new System.Drawing.Point(152, 70);
            this.CP_id.Name = "CP_id";
            this.CP_id.Size = new System.Drawing.Size(100, 20);
            this.CP_id.TabIndex = 5;
            // 
            // txtAddrss
            // 
            this.txtAddrss.Location = new System.Drawing.Point(116, 164);
            this.txtAddrss.Multiline = true;
            this.txtAddrss.Name = "txtAddrss";
            this.txtAddrss.Size = new System.Drawing.Size(210, 49);
            this.txtAddrss.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(116, 120);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(136, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(116, 225);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(158, 20);
            this.txtcontact.TabIndex = 8;
            // 
            // btndlt
            // 
            this.btndlt.Location = new System.Drawing.Point(12, 262);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(75, 23);
            this.btndlt.TabIndex = 9;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = true;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // btnupdt
            // 
            this.btnupdt.Location = new System.Drawing.Point(116, 262);
            this.btnupdt.Name = "btnupdt";
            this.btnupdt.Size = new System.Drawing.Size(75, 23);
            this.btnupdt.TabIndex = 10;
            this.btnupdt.Text = "Update";
            this.btnupdt.UseVisualStyleBackColor = true;
            this.btnupdt.Click += new System.EventHandler(this.btnupdt_Click);
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(239, 262);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 11;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(349, 262);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnexit
            // 
            this.btnexit.Image = global::MedMIS.Properties.Resources.images_003;
            this.btnexit.Location = new System.Drawing.Point(325, 22);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 49);
            this.btnexit.TabIndex = 13;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Add_Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 297);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnupdt);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtAddrss);
            this.Controls.Add(this.CP_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Party";
            this.Text = "Add_Party";
            this.Load += new System.EventHandler(this.Add_Party_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CP_id;
        private System.Windows.Forms.TextBox txtAddrss;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnupdt;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
    }
}