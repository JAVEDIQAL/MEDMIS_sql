using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MedMIS
{
    class DatabaseConnection
    {
        private string _sqlstring;
        private string _connstring;
        SqlDataAdapter da_1;

        public string sqlstring
        {
            set { _sqlstring = value; }
        
        }
        public string connstring
        {
            set { _connstring = value; }
        
        }

        public System.Data.DataSet GetConnection
        {

            get {return MyDataSet() ;}
        
        }
        private System.Data.DataSet MyDataSet()
        {
            SqlConnection conn = new SqlConnection(_connstring);
            conn.Open();
            da_1=new SqlDataAdapter(_sqlstring,conn);
            System.Data.DataSet dat_set=new  System.Data.DataSet();
            da_1.Fill(dat_set,"tbl_Medicines");
            conn.Close();
            return dat_set;

        }

        public void UpdateDatabase(System.Data.DataSet ds)
        {

            SqlCommandBuilder cb = new SqlCommandBuilder(da_1);
            cb.DataAdapter.Update(ds.Tables[0]);
        
        }
        
        
        
        
        
        
        
        

    }
}
