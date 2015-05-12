namespace MedMIS
{
    partial class SellReportForm
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
            this.SellCRpt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // SellCRpt
            // 
            this.SellCRpt.ActiveViewIndex = -1;
            this.SellCRpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SellCRpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.SellCRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellCRpt.Location = new System.Drawing.Point(0, 0);
            this.SellCRpt.Name = "SellCRpt";
            this.SellCRpt.Size = new System.Drawing.Size(338, 262);
            this.SellCRpt.TabIndex = 0;
            this.SellCRpt.Load += new System.EventHandler(this.SellCRpt_Load);
            // 
            // SellReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 262);
            this.Controls.Add(this.SellCRpt);
            this.Name = "SellReportForm";
            this.Text = "SellReportForm";
            this.Load += new System.EventHandler(this.SellReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer SellCRpt;
    }
}