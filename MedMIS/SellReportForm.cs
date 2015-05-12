using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace MedMIS
{
    public partial class SellReportForm : Form
    {
        public SellReportForm()
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
            cryRpt.Load(@"D:\Javed\PROGRAMMING BOOKS\C#\MedMIS\MedMIS\Months_rpt.rpt");
            cryRpt.SetDataSource(ds);
            SellCRpt .ReportSource = cryRpt;
            SellCRpt.DisplayToolbar = true;
            SellCRpt.Refresh();

        }



















        

        private void SellCRpt_Load(object sender, EventArgs e)
        {

        }

        private void SellReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
