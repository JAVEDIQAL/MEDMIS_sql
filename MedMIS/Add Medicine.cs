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
    public partial class Add_Medicine : Form
    {
        SqlConnection connection ;
        SqlCommand command;
        bool old=false;
        public Add_Medicine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Add_Medicine_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool rslt;
           string  med_name =Med_name.Text;
           string mfg_name = Mfg_date.Text;
           int stck =Convert.ToInt32( txtstocks.Text);
           Date mfg_date = Date.Parse(dateTimePicker1.Text.ToString());
           Date exp_date = Date.Parse(dateTimePicker2.Text.ToString());
           rslt=CheckNeworOldMed( med_name);
           if (rslt == false)
           {
               string query = "Insert into tbl_mdcnentry(med_name,mnf_name,mfg_date,exp_date,stock) values(@med_name,@mnf_name,@mfg_date,@exp_date,@stock)";
               using (connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS"))
               {
                   connection.Open();
                   using (command = new SqlCommand(query, connection))
                   {

                       command.Parameters.Add("@med_name", SqlDbType.VarChar).Value = med_name;
                       command.Parameters.Add("@mnf_name", SqlDbType.VarChar).Value = mfg_name;
                       command.Parameters.Add("@mfg_date", SqlDbType.Date).Value = mfg_date.ToShortString();
                       command.Parameters.Add("@exp_date", SqlDbType.Date).Value = exp_date.ToShortString();
                       command.Parameters.Add("@stock", SqlDbType.Int).Value = stck;

                   }
                   command.ExecuteNonQuery();
                   MessageBox.Show("New Medicine Item added");
               }
           }
           else
           { 
            string query = "update tbl_mdcnentry set stock=@newstock where med_name=@med_name";
               using (connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS"))
               {
                   connection.Open();
                   using (command = new SqlCommand(query, connection))
                   {

                       command.Parameters.Add("@med_name", SqlDbType.VarChar).Value = med_name;
                       command.Parameters.Add("@newstock", SqlDbType.Int).Value = stck;

                   }
                   command.ExecuteNonQuery();
                   MessageBox.Show("Stock Updated");
               }
           }
           
           
           
          


        

        }

        private bool CheckNeworOldMed(string medicine_name)
        { 
            
            string query="select med_name from tbl_mdcnentry";
            using (connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS"))
            {
                connection.Open();
                using (command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show(reader.GetValue(0).ToString());
                        if (medicine_name == reader.GetValue(0).ToString())
                        {
                            old = true;
                            break;
                            
                        }
                        
                        
                       
                    }
                  
                }
            }
            return old;
        }



        private void txtstocks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
