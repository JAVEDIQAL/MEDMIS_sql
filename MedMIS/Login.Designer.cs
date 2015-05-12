namespace MedMIS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Log_in = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.CPass = new System.Windows.Forms.TabPage();
            this.OK = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPUser = new System.Windows.Forms.TextBox();
            this.cpopass = new System.Windows.Forms.TextBox();
            this.Crepass = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Log_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Log_in);
            this.tabControl1.Controls.Add(this.CPass);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // Log_in
            // 
            this.Log_in.AllowDrop = true;
            this.Log_in.BackColor = System.Drawing.Color.Aquamarine;
            this.Log_in.BackgroundImage = global::MedMIS.Properties.Resources.User2;
            this.Log_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_in.Controls.Add(this.pictureBox1);
            this.Log_in.Controls.Add(this.label2);
            this.Log_in.Controls.Add(this.label1);
            this.Log_in.Controls.Add(this.Submit);
            this.Log_in.Controls.Add(this.Pass);
            this.Log_in.Controls.Add(this.UserName);
            this.Log_in.Location = new System.Drawing.Point(4, 22);
            this.Log_in.Name = "Log_in";
            this.Log_in.Padding = new System.Windows.Forms.Padding(3);
            this.Log_in.Size = new System.Drawing.Size(1074, 483);
            this.Log_in.TabIndex = 0;
            this.Log_in.Text = "Log_in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::MedMIS.Properties.Resources.cropped;
            this.pictureBox1.Location = new System.Drawing.Point(35, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 94);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(553, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(553, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // Submit
            // 
            this.Submit.Image = global::MedMIS.Properties.Resources.Gobutton;
            this.Submit.Location = new System.Drawing.Point(764, 174);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(159, 85);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "SUBMIT";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Pass
            // 
            this.Pass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Pass.Location = new System.Drawing.Point(623, 127);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(234, 20);
            this.Pass.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(623, 73);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(234, 20);
            this.UserName.TabIndex = 1;
            // 
            // CPass
            // 
            this.CPass.BackgroundImage = global::MedMIS.Properties.Resources.User2;
            this.CPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CPass.Controls.Add(this.OK);
            this.CPass.Controls.Add(this.pictureBox2);
            this.CPass.Controls.Add(this.label5);
            this.CPass.Controls.Add(this.label4);
            this.CPass.Controls.Add(this.label3);
            this.CPass.Controls.Add(this.CPUser);
            this.CPass.Controls.Add(this.cpopass);
            this.CPass.Controls.Add(this.Crepass);
            this.CPass.Location = new System.Drawing.Point(4, 22);
            this.CPass.Name = "CPass";
            this.CPass.Padding = new System.Windows.Forms.Padding(3);
            this.CPass.Size = new System.Drawing.Size(1074, 483);
            this.CPass.TabIndex = 1;
            this.CPass.Text = "Change Password";
            this.CPass.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Image = global::MedMIS.Properties.Resources.smallsuccess;
            this.OK.Location = new System.Drawing.Point(665, 254);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 39);
            this.OK.TabIndex = 10;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MedMIS.Properties.Resources.LoginRed_cropped;
            this.pictureBox2.Location = new System.Drawing.Point(828, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 240);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserName";
            // 
            // CPUser
            // 
            this.CPUser.Location = new System.Drawing.Point(415, 36);
            this.CPUser.Name = "CPUser";
            this.CPUser.Size = new System.Drawing.Size(306, 20);
            this.CPUser.TabIndex = 5;
            // 
            // cpopass
            // 
            this.cpopass.Location = new System.Drawing.Point(415, 112);
            this.cpopass.Name = "cpopass";
            this.cpopass.Size = new System.Drawing.Size(306, 20);
            this.cpopass.TabIndex = 4;
            // 
            // Crepass
            // 
            this.Crepass.Location = new System.Drawing.Point(415, 188);
            this.Crepass.Name = "Crepass";
            this.Crepass.Size = new System.Drawing.Size(306, 20);
            this.Crepass.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 586);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.Log_in.ResumeLayout(false);
            this.Log_in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CPass.ResumeLayout(false);
            this.CPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CPass;
        private System.Windows.Forms.TabPage Log_in;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPUser;
        private System.Windows.Forms.TextBox cpopass;
        private System.Windows.Forms.TextBox Crepass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button OK;

    }
}