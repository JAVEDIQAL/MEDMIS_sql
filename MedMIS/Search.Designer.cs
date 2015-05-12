namespace MedMIS
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.btnSearch_mdcn = new System.Windows.Forms.Button();
            this.txtsearchmdcn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch_mdcn
            // 
            this.btnSearch_mdcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_mdcn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch_mdcn.Image = global::MedMIS.Properties.Resources.image;
            this.btnSearch_mdcn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch_mdcn.Location = new System.Drawing.Point(286, 17);
            this.btnSearch_mdcn.Name = "btnSearch_mdcn";
            this.btnSearch_mdcn.Size = new System.Drawing.Size(101, 94);
            this.btnSearch_mdcn.TabIndex = 0;
            this.btnSearch_mdcn.Text = "Medicine";
            this.btnSearch_mdcn.UseVisualStyleBackColor = true;
            this.btnSearch_mdcn.Click += new System.EventHandler(this.btnSearch_mdcn_Click);
            // 
            // txtsearchmdcn
            // 
            this.txtsearchmdcn.Location = new System.Drawing.Point(39, 55);
            this.txtsearchmdcn.Name = "txtsearchmdcn";
            this.txtsearchmdcn.Size = new System.Drawing.Size(241, 20);
            this.txtsearchmdcn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedMIS.Properties.Resources.drugs_magnifying_glass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearchmdcn);
            this.Controls.Add(this.btnSearch_mdcn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch_mdcn;
        private System.Windows.Forms.TextBox txtsearchmdcn;
        private System.Windows.Forms.Label label1;
    }
}