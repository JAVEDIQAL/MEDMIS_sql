using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace MedMIS
{
    public partial class Form1 : Form
    {
         SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS");
         SqlCommand command = new SqlCommand();
         int avlble_stck; 
         Int64 totl_prc;
         Int32 prc, dsc,int_qty;
         float totldsc, dsc_prcnt, retailpric;
         int rem_stock;
        public Form1()
        {
           

            InitializeComponent();
            CustomControls();
            connection.Open();
            ShowListView();
            PopulateCombobox();
            PopulatePartyIdCombobox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

           

        }

        private void PopulateCombobox()
        {
            string str = "select med_name from  tbl_mdcnentry";
            command.Connection = connection;
            command.CommandText = str;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!combomedicine.Items.Contains(reader[0]))
                    combomedicine.Items.Add(reader[0]);
                //if (!combocompany.Items.Contains(reader[1]))
                //    combocompany.Items.Add(reader[1]);

            }

            reader.Close();
        }
        public void PopulatePartyIdCombobox()
        {

            string str = "select distinct CP_id from  tbl_partyinfo";
            command.Connection = connection;
            command.CommandText = str;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!PartId.Items.Contains(reader[0]))
                    PartId.Items.Add(reader[0]);

            }
            reader.Close();



        }
         private void CustomControls()
         {
             dateTimePicker1.Format = DateTimePickerFormat.Custom;
             dateTimePicker1.CustomFormat = "";
             dateTimePicker2.Format = DateTimePickerFormat.Custom;
             dateTimePicker2.CustomFormat = "";
             dateTimePicker3.Format = DateTimePickerFormat.Custom;
             dateTimePicker3.CustomFormat = "";
             dateTimePicker1.Value = Date.Today;
             lstLocal.View = View.Details;
             lstLocal.BackColor = System.Drawing.Color.Aqua;
             lstLocal.Columns.Add("Invoice No.", 80, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Invoice Date", 130, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Party/Customer ID",130,HorizontalAlignment.Left);
             lstLocal.Columns.Add("Medicine Name", 90, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Company Name", 90, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Mfg.Date", 130, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Exp.Date", 130, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Qty.", 80, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Price",80,HorizontalAlignment.Left);
             lstLocal.Columns.Add("Discount", 80, HorizontalAlignment.Left);
             lstLocal.Columns.Add("Retail Price.", 80, HorizontalAlignment.Left);
             lstLocal.GridLines = true;
             lstLocal.FullRowSelect = true;                            
         }
       
       private void ShowListView()
          {

              lstLocal.Items.Clear();
              
                string str = "select * from  tbl_Mdcl";
               
                command.Connection = connection;
                command.CommandText = str;
                lstLocal.View = View.Details;
                lstLocal.FullRowSelect = true;
               
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                 {
                            
                           ListViewItem lv = new ListViewItem(reader.GetValue(0) + " ");
                            Date list_parse_indte = Date.Parse(reader.GetValue(1) + " ");
                            
                                lv.SubItems.Add(list_parse_indte.ToShortString()+" ");
                            
                                lv.SubItems.Add(reader.GetValue(2) + "");
                            
                                lv.SubItems.Add(reader.GetValue(3)+"");
                           
                                lv.SubItems.Add(reader.GetValue(4) + "");
                            Date list_parse_mdte = Date.Parse(reader.GetValue(5) + "");
                            
                                lv.SubItems.Add(list_parse_mdte.ToShortString() + "");
                            Date list_parse_exdte = Date.Parse(reader.GetValue(6) + "");
                            
                                lv.SubItems.Add(list_parse_exdte.ToShortString()+"");
                           
                                lv.SubItems.Add(reader.GetValue(7)+"");
                            
                                lv.SubItems.Add(reader.GetValue(8) + "");
                            
                                lv.SubItems.Add(reader.GetValue(9) + "");
                           
                                lv.SubItems.Add(reader.GetValue(10) + "");
                            lstLocal.Items.Add(lv);
                        

                 }

                reader.Close();
        }


        private void display_all()
        {
        
        
        
        
        }
        private void Exit_Click(object sender, EventArgs e)
        {
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void InvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            InvoiceNo.Clear();
            qty.Clear();
            dateTimePicker1.Value=Date.Today ;
            dateTimePicker2.Value = Date.Today;
            dateTimePicker3.Value = Date.Today;
            combomedicine.Items.Clear();
            combocompany.Items.Clear();
            discount.Clear();
            Price.Clear();
            discount.Clear();
            totalamnt.Clear();
            totaldscnt.Clear();
            Save.Enabled = true;
            AddNew.Enabled = false;
            PopulateCombobox();
            PopulatePartyIdCombobox();
        }

        public void Save_Click(object sender, EventArgs e)
        {

            //check and validation?
            if (InvoiceNo.TextLength != 0 && PartId.SelectedItem != null && combomedicine.SelectedItem != null && combocompany.SelectedItem != null && qty.TextLength != 0 && discount.TextLength != 0 && Price.TextLength != 0 && dateTimePicker1.Value != null && dateTimePicker2.Value != null && dateTimePicker3.Value != null)
            {

                if (!ValidateInputboxes(InvoiceNo))
                {
                    MessageBox.Show("Please enter only numeric in Invoice No.field");
                }

                if (!ValidateInputboxes(qty))
                {
                    MessageBox.Show("Please enter only numeric in Qty field");
                }
                if (!ValidateInputboxes(discount))
                {
                    MessageBox.Show("Please enter only numeric in discount.field");
                }
                if (!ValidateInputboxes(Price))
                {
                    MessageBox.Show("Please enter only numeric in Price field");
                }

                if (CheckAvailableStock(avlble_stck))
                {
                    CustomerReport();
                }

            }

            else
            {


                MessageBox.Show("Please fill in all the fields before saving");

            }
           
        }

        //helper  function to validate input
        public bool ValidateInputboxes(TextBox tb)
         { 

              int output;
              if (!int.TryParse(tb.Text, out output))
              {

                 

                  return false;

              }
              else
              {



                  return true;
              
              }
              
        
        }

        //helper function to check available stock from database
        public bool CheckAvailableStock(int stock)
        {
            int output;
            if (int.TryParse(qty.Text, out output))
            {

                if (output > stock || output==0)
                {

                    MessageBox.Show("Please select in the available stock of" + avlble_stck);
                    return false;

                }
                else {

                        //Update stock value in tbl_mdcnentry
                        rem_stock=stock-output;
                        UpdateStock(rem_stock);
                         return true;
                
                
                     }

                
            }
            else
            {
                MessageBox.Show("Parsing failed for avaialable stock");
                return false;
                
            
            }
           

        }
        public void CustomerReport()
        {            
               try
                {
                    string conn = "Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS";
                    String query = "INSERT INTO  tbl_Mdcl (Invoice_No,Invoice_Date,CustomerId,Med_Name,Comp_Name,Date_Manaf,Date_Exp,Qty,Price,Discount,Retail) VALUES (@Invoice_No,@Invoice_Date,@CustomerId,@Med_Name,@Comp_Name,@Manaf_Date,@Exp_Date,@Qty,@Price,@Discount,@Retail)";
                    using ( SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (SqlCommand insertCommand = new SqlCommand(query, connection))
                        {

                          
                            //Formatting date for database
                            Date in_dte = Date.Parse(dateTimePicker1.Value.ToString());
                            Date m_dte = Date.Parse(dateTimePicker2.Value.ToString());
                            Date e_dte = Date.Parse(dateTimePicker3.Value.ToString());

                            //calculating total price after discount
                            prc = Convert.ToInt32(Price.Text);
                            dsc = Convert.ToInt32(discount.Text);
                            int_qty=Convert.ToInt32(qty.Text);
                            totl_prc = prc *int_qty;
                            if (dsc != 0)
                            {
                                 dsc_prcnt = (float)dsc / 100;                               
                                //discount amount
                                 totldsc = (float)totl_prc * dsc_prcnt;
                                 retailpric = totl_prc - totldsc;
                                // MessageBox.Show(totl_prc.ToString());
                            }
                            else 
                            {
                                totldsc=0;
                                retailpric=totl_prc-totldsc;
                            
                              
                            
                            }
                            

                            ////a shorter syntax to adding parameter
                                insertCommand.Parameters.Add("@Invoice_No", SqlDbType.Int).Value = InvoiceNo.Text;
                                insertCommand.Parameters.Add("@Invoice_Date", SqlDbType.Date).Value = in_dte.ToShortString();
                                insertCommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = PartId.Text;
                                insertCommand.Parameters.Add("@Med_Name", SqlDbType.VarChar).Value = combomedicine.Text;
                                insertCommand.Parameters.Add("@Comp_Name", SqlDbType.VarChar).Value = combocompany.Text;
                                insertCommand.Parameters.Add("@Manaf_Date", SqlDbType.Date).Value = m_dte.ToShortString();
                                insertCommand.Parameters.Add("@Exp_Date", SqlDbType.Date).Value = e_dte.ToShortString();
                                insertCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = qty.Text;
                                insertCommand.Parameters.Add("@Price", SqlDbType.Int).Value = totl_prc;
                                insertCommand.Parameters.Add("@Discount", SqlDbType.Int).Value = totldsc;
                                insertCommand.Parameters.Add("@Retail", SqlDbType.Int).Value = retailpric;
                                totalamnt.Text = retailpric.ToString();
                                totaldscnt.Text = totldsc.ToString();

                                ////make sure you open and close(after executing) the connection
                                var rowsaffected = insertCommand.ExecuteNonQuery();
                                connection.Close();
                               // MessageBox.Show(rowsaffected.ToString());
                                MessageBox.Show("Record inserted. Please check your table data. :)");
                                ShowListView();


                            }

                           
                        }

                    }
                
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);

                }
                            
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            lstLocal.Items.Clear();
            
            ShowListView();
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void Add_party_Click(object sender, EventArgs e)
        {
            Add_Party ap = new Add_Party();
            ap.Show();
            PopulatePartyIdCombobox();
            this.Close();
           
        }

        private void combomedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            combocompany.Items.Clear();
            if (!GetAutoCombobox_filled())
            {
                Save.Enabled = false;

            }
            else
            {

                Save.Enabled = true;
            
            
            }
        }

        public bool GetAutoCombobox_filled()
        {

            // int select_item;
            string str = "select med_name,mnf_name,mfg_date,exp_date,stock from  tbl_mdcnentry";
            command.Connection = connection;
            command.CommandText = str;
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                
                if (combomedicine.SelectedItem.ToString() == (string)reader["med_name"])
                {
                    combocompany.Items.Add(reader.GetValue(1).ToString());
                    dateTimePicker2.Text=reader.GetValue(2).ToString();
                    dateTimePicker3.Text = reader.GetValue(3).ToString();
                    avlble_stck  = Convert.ToInt32(reader.GetValue(4));
                    if (avlble_stck == 0)
                    {

                        MessageBox.Show("No stock of "+combomedicine.SelectedItem.ToString()+ " right now.");
                        reader.Close();
                        return false;
                        
                    }




                    break;
                }

            }
            reader.Close();

            return true;
        }
        
        public void UpdateStock(int new_stock)
        {
            string conn = "Server=localhost\\SQLEXPRESS;integrated security=SSPI;MultipleActiveResultSets=true;database=MMIS";
            String str =  "Update tbl_mdcnentry set stock= @stock where med_name=@med_name";
            
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(str, connection))
                    {
                        try
                        {
                           insertCommand.Parameters.Add("@stock", SqlDbType.Int).Value = new_stock;
                           insertCommand.Parameters.Add("@med_name", SqlDbType.VarChar).Value = combomedicine.SelectedItem.ToString();
                           var rowsaffected = insertCommand.ExecuteNonQuery();
                           connection.Close();
                           MessageBox.Show(rowsaffected.ToString());
                        
                        
                        }
                        catch (Exception e)
                          {

                             MessageBox.Show(e.Message.ToString()); 

                          }


                    }


                }

            }

        private void prnt_rpt_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
        }

            


        








       
    }
}
