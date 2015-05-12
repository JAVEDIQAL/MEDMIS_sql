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
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
            Pass.PasswordChar = '*';
            cpopass.PasswordChar = '*';
            Crepass.PasswordChar='*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
            

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string str = "select * from  tbl_signin";
            //string str = "INSERT INTO tbl_login(username,Password) VALUES (@username,@Password)";
            SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS");
            connection.Open();
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                if ((UserName.TextLength!=0) && (Pass.TextLength!=0))
                {
                    if (string.Equals(UserName.Text.ToString(), reader.GetValue(1).ToString(),StringComparison.InvariantCultureIgnoreCase) && (Pass.Text.ToString()==reader.GetValue(2).ToString()))
                    {

                        MedMenu mm = new MedMenu();
                        mm.Show();
                        break;

                        // rf.Show();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username/password");
                        break;

                    }

                }
                else {


                    MessageBox.Show("Please fill up all the fields before submitting");
                    break;
                
                }
            }
            
          }

        private void OK_Click(object sender, EventArgs e)
        {           SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS");
                    connection.Open();
                    string getquery="select username ,Password from tbl_signin";
                    SqlCommand getcommand = new SqlCommand(getquery, connection);
                    SqlDataReader getreader = getcommand.ExecuteReader();
                    while (getreader.Read())
                    {

                        //MessageBox.Show(getreader.GetValue(0).ToString());

                        //MessageBox.Show(getreader.GetValue(1).ToString());
                        if ((CPUser.Text.ToString() == getreader.GetValue(0).ToString()) && (cpopass.Text.ToString() == getreader.GetValue(1).ToString()) && Crepass.Text.ToString() != "")
                        {
                            string insertquery = "Update  tbl_signin  SET Password=@Password";
                            SqlCommand insertcommand = new SqlCommand(insertquery, connection);

                            insertcommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Crepass.Text.ToString();
                            var rows = insertcommand.ExecuteNonQuery();
                           // MessageBox.Show(rows.ToString());





                        }

                    }




        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
                        //MessageBox.Show( getreader.GetValue(0).ToString());

                        //if ((CPUser.Text == "JAVED") && (cpopass.Text == userpass))
                        //{

                        //    if (Crepass.Text != " ")
                        //    {

                        //        string query = "UPDATE tbl_signin SET Password=@Password WHERE id=1";
                        //        SqlCommand insertcommand = new SqlCommand(query, connection);
                        //        insertcommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Crepass.Text.ToString();
                        //        var rowsaffected = insertcommand.ExecuteNonQuery();
                        //        connection.Close();
                        //        MessageBox.Show(rowsaffected.ToString());
                        //        MessageBox.Show("Password Changed:)");




                        //    }

                        //    else if (Crepass.Text == "")
                        //    {

                        //        MessageBox.Show("Please fill all fields before submitting");
                        //    }
                        //}
                    }

        }
























            //using (SqlCommand command = new SqlCommand(str, connection))
            //{ 
            //       command.Parameters.Add("@username",SqlDbType.NVarChar).Value=UserName.Text.ToString();
            //       command.Parameters.Add("@Password",SqlDbType.NVarChar).Value=Pass.Text.ToString();
            //       var rowsaffected = command.ExecuteNonQuery();
            //       connection.Close();
            //       MessageBox.Show(rowsaffected.ToString());
            //       MessageBox.Show("Record inserted. Please check your table data. :)");
            
            
            //}
           
  
            
           
        
 

