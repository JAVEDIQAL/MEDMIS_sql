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
namespace MedMIS
{
    public partial class Search : Form
    {    SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS");
         
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_mdcn_Click(object sender, EventArgs e)
        {
            string medvalue=txtsearchmdcn.Text.ToString();                            
            SqlDataReader reader = null;
            try{
                 connection.Open();
                
			// 1. declare command object with parameter
                 SqlCommand cmd=new SqlCommand("Select med_name ,stock from tbl_mdcnentry where med_name LIKE '%'+ @medname + '%'" ,connection);
            
            // 2. define parameters used in command object
                SqlParameter param=new SqlParameter();
                param.ParameterName="@medname";
                param.Value=medvalue;
                
          // 3. add new parameter to command object
                cmd.Parameters.Add(param);
                // get data stream
			reader = cmd.ExecuteReader();
                // write each record
			   while(reader.Read())
			     {

                     label1.Text = "Available " + reader.GetValue(0).ToString() + " stock is " + reader.GetValue(1).ToString();
			     }
		        }
		finally
		{
			// close reader
			if (reader != null)
			{
				reader.Close();
			}

			// close connection
			if (connection != null)
			{
				connection.Close();
			}
		}
            
            
            
            
            
            
            
            
            
            
            
            }




























               
                //if (String.Equals(txtsearchmdcn.Text.ToString(), (string)reader["med_name"],StringComparison.InvariantCultureIgnoreCase))
                //{

                //    label1.Text = "Available stock of " + reader.GetValue(0).ToString() + " is " + reader.GetValue(1).ToString();

                //    break;

                //}
                //else
                //{ 
                   
                //  label1.Text="Not Available";
                
                
                //}
         
        










    }
}
