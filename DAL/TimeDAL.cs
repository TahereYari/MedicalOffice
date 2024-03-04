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
   public class TimeDAL
    {
        DB db = new DB();
        public void Create(Time ti)
        {
            try
            {

                if (Read(ti))
                {

                    db.Times.Add(ti);
                    db.SaveChanges();

                }
            }
            catch
            {
            }
        }


        public bool Read(Time ti)
        {
            //فعل تکراری بودن
            var q = db.Times.Where(i => i.time1 == ti.time1 && i.DeleteStatus == false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Time> ReadTime()
        {
            return db.Times.Where(t => t.DeleteStatus == false).ToList();
        }

        public Time Readt(string s)
        {
            return db.Times.Where(i => i.time1 == s && i.DeleteStatus == false).SingleOrDefault();


        }

        public DataTable Read()
        {
            //این فعل برای نمایش دیتای دیتا گرید است
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.ReadTime");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public Time Read(int id)
        {
            return db.Times.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }

        public string Delete(int id)
        {
            try
            {
                var q = db.Times.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.SaveChanges();
                    return "حذف با موفقیت انجام شد.";
                }
                else
                {
                    return "موردی یافت نشد.";
                }
            }
            catch (Exception e)
            {
                return "حذف اطلاعات با خطایی مواجه شده است:\n" + e.Message;
            }
        }

        public List <Time> ReadT(string ti)
        {
            return db.Times.Where(i => i.time1==ti  && i.DeleteStatus == false).ToList();

        }
    }
}
