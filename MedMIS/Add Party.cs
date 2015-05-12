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
    public partial class Add_Party : Form
    {
        SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS");
        SqlCommand command = new SqlCommand();
        string conn = "Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS";


        //disables the close button of the form
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
             
        
        public Add_Party()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Party_Load(object sender, EventArgs e)
        {




        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO  tbl_partyinfo (CP_id,Name,Addrss,Cntct_No) VALUES (@CP_id,@Name,@Addrss,@Cntct_No)";

            using (SqlConnection connection1 = new SqlConnection(conn))
            {
                connection1.Open();
                using (SqlCommand insertCommand = new SqlCommand(query, connection1))
                {


                    //a shorter syntax to adding parameter
                    insertCommand.Parameters.Add("@CP_id", SqlDbType.Int).Value = CP_id.Text;
                    insertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtname.Text;
                    insertCommand.Parameters.Add("@Addrss", SqlDbType.VarChar).Value = txtAddrss.Text;
                    insertCommand.Parameters.Add("@Cntct_No", SqlDbType.VarChar).Value = txtcontact.Text;

                    //make sure you open and close(after executing) the connection

                    var rowsaffected = insertCommand.ExecuteNonQuery();
                    connection1.Close();
                    MessageBox.Show(rowsaffected.ToString());
                    MessageBox.Show("Record Inserted :)");
                    

                }
            }
        }



        private void btnclr_Click(object sender, EventArgs e)
        {
            CP_id.Clear();
            txtname.Clear();
            txtcontact.Clear();
            txtAddrss.Clear();



        }

        private void btnupdt_Click(object sender, EventArgs e)
        {
            if (CP_id.TextLength!=0)
            {
               
                string query = "Update tbl_partyinfo set Name=@Name,Addrss=@Addrss,Cntct_No=@Cntct_No where CP_id=@CP_id";
                using (SqlConnection connection1 = new SqlConnection(conn))
                {
                    connection1.Open();
                    using (SqlCommand insertCommand = new SqlCommand(query, connection1))
                    {


                        //a shorter syntax to adding parameter
                      
                        insertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtname.Text;
                        insertCommand.Parameters.Add("@Addrss", SqlDbType.VarChar).Value = txtAddrss.Text;
                        insertCommand.Parameters.Add("@Cntct_No", SqlDbType.VarChar).Value = txtcontact.Text;
                        insertCommand.Parameters.Add("@CP_id", SqlDbType.Int).Value = CP_id.Text;

                        //make sure you open and close(after executing) the connection

                        var rowsaffected = insertCommand.ExecuteNonQuery();
                        connection1.Close();
                        MessageBox.Show(rowsaffected.ToString());
                        MessageBox.Show("Id no."+CP_id.Text +" Updated.");

                
                    }
                }

            }
            else 
            
            {

                MessageBox.Show("Please identify Id before updating");
            
            
            }
            //if (System.Windows.Forms.Application.OpenForms["Add_Party"] != null)
            //{

            //    (System.Windows.Forms.Application.OpenForms["Add_Party"] as Form1).PopulatePartyIdCombobox();


            //}

        }

        private void btndlt_Click(object sender, EventArgs e)
        {


            if (CP_id.Text != " ")
            {

                string query = "Delete from tbl_partyinfo  where CP_id=@CP_id";
                using (SqlConnection connection1 = new SqlConnection(conn))
                {
                    connection1.Open();
                    using (SqlCommand insertCommand = new SqlCommand(query, connection1))
                    {
                        insertCommand.Parameters.Add("@CP_id", SqlDbType.Int).Value = CP_id.Text;

                        //make sure you open and close(after executing) the connection

                        var rowsaffected = insertCommand.ExecuteNonQuery();
                        connection1.Close();
                        MessageBox.Show(rowsaffected.ToString());
                        MessageBox.Show("Id no." + CP_id.Text + " deleted.");
                       


                    }
                }

            }
            else
            {

                MessageBox.Show("Please identify Id before updating");


            }

          
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.PopulatePartyIdCombobox();
            f1.Show();

            this.Close();
        }






    }
}
