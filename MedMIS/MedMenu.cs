using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedMIS
{
    public partial class MedMenu : Form
    {
        public MedMenu()
        {
            InitializeComponent();
        }

        private void MedMenu_Load(object sender, EventArgs e)
        {

        }

        private void Add_mdcn_Click(object sender, EventArgs e)
        {
            Add_Medicine am = new Add_Medicine();
            am.Show();

        }

        private void SalesReport_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search sr = new Search();
            sr.Show();
        }

        private void btnmnth_rep_Click(object sender, EventArgs e)
        {
            //ReportForm rf = new ReportForm();
            //rf.Show();
            SellReportForm srf = new SellReportForm();
            srf.Show();

        }
    }
}
