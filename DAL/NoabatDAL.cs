using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class NoabatDAL
    {
        DB db = new DB();
        public string Create(Noabat N)
        {
            try
            {

                  db.Noabats.Add(N);
                  db.SaveChanges();
                 return "ثبت با موفقیت انجام شد.";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی مواجه شده است:\n" + e.Message;
            }
        }

        public DataTable Search(string date, string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ReadNoabat");
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@NameOfDoctor", doctor);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

     
        public DataTable ReadNobatReserve(string date, string doctor, string codeMelii)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ReadNobatReserve");
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@NameOfDoctor", doctor);
            cmd.Parameters.AddWithValue("@codeMelii", codeMelii);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }


        public Noabat ReadNobatReserve2(string date, string doctor, string codeMelii)
        {
            return db.Noabats.Where(i => i.Date1 == date && i.doctor == doctor && i.codeMelii == codeMelii).SingleOrDefault();
        }
    }
}
