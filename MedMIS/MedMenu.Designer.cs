namespace MedMIS
{
    partial class MedMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedMenu));
            this.Add_mdcn = new System.Windows.Forms.Button();
            this.SalesReport = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnmnth_rep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_mdcn
            // 
            this.Add_mdcn.BackgroundImage = global::MedMIS.Properties.Resources._1386857181_add2_;
            this.Add_mdcn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add_mdcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_mdcn.Location = new System.Drawing.Point(211, -1);
            this.Add_mdcn.Name = "Add_mdcn";
            this.Add_mdcn.Size = new System.Drawing.Size(174, 70);
            this.Add_mdcn.TabIndex = 0;
            this.Add_mdcn.Text = "Add Medicine";
            this.Add_mdcn.UseVisualStyleBackColor = true;
            this.Add_mdcn.Click += new System.EventHandler(this.Add_mdcn_Click);
            // 
            // SalesReport
            // 
            this.SalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReport.Image = global::MedMIS.Properties.Resources._1386932131_Money;
            this.SalesReport.Location = new System.Drawing.Point(211, 75);
            this.SalesReport.Name = "SalesReport";
            this.SalesReport.Size = new System.Drawing.Size(171, 59);
            this.SalesReport.TabIndex = 1;
            this.SalesReport.Text = "Sales Report";
            this.SalesReport.UseVisualStyleBackColor = true;
            this.SalesReport.Click += new System.EventHandler(this.SalesReport_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = global::MedMIS.Properties.Resources.search;
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsearch.Location = new System.Drawing.Point(214, 232);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(171, 75);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnmnth_rep
            // 
            this.btnmnth_rep.Image = global::MedMIS.Properties.Resources.Monthly_report1;
            this.btnmnth_rep.Location = new System.Drawing.Point(211, 140);
            this.btnmnth_rep.Name = "btnmnth_rep";
            this.btnmnth_rep.Size = new System.Drawing.Size(174, 73);
            this.btnmnth_rep.TabIndex = 3;
            this.btnmnth_rep.Text = "Monthly Report";
            this.btnmnth_rep.UseVisualStyleBackColor = true;
            this.btnmnth_rep.Click += new System.EventHandler(this.btnmnth_rep_Click);
            // 
            // MedMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedMIS.Properties.Resources.city_dental_hospital_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 367);
            this.Controls.Add(this.btnmnth_rep);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.SalesReport);
            this.Controls.Add(this.Add_mdcn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedMenu";
            this.Text = "MedMenu";
            this.Load += new System.EventHandler(this.MedMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_mdcn;
        private System.Windows.Forms.Button SalesReport;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnmnth_rep;

    }
}