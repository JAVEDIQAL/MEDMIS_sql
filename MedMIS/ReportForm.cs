using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
namespace MedMIS
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            string query = "Select * from tbl_Mdcl";
            string constr = "Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS";
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.CommandType=CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds,"tbl_Mdcl");
            
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\Javed\PROGRAMMING BOOKS\C#\MedMIS\MedMIS\Selling_rpt.rpt");
            cryRpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
