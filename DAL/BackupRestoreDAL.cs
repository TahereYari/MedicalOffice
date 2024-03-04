using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
   public class BackupRestoreDAL
    {
        

        public void BackUp(string path)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
       
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"backup database MedicalDB1 to disk ='" + path+@"\BackupDB.bak' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        public void Restore(string path)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=master; Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"restore database MedicalDB1 from disk ='" + path + "' with replace";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { }
           
        }
    }
}
