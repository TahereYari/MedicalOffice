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
    public class FilesDAL
    {
        DB db = new DB();

        public string Create(Files f)
        {
            try
            {

                if (Read(f))
                {

                    db.Filess.Add(f);
                    db.SaveChanges();

                    return "ثبت با موفقیت انجام شد.";
                }
                else
                {
                    return "اطلاعات وارد شده تکراری است.";
                }


            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی مواجه شده است:\n" + e.Message;

            }
        }
        public bool Read(Files f)
        {
            //فعل تکراری بودن
            var q = db.Filess.Where(i => i.CodeMelli == f.CodeMelli &&i.DeleteStatus==false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Files Read(int id)
        {
            return db.Filess.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }
        public DataTable Read()
        {
            //این فعل برای نمایش دیتای دیتا گرید است
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.ReadFile");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable Search(string s)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.SearchFile");
            cmd.Parameters.AddWithValue("@Search", s);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public Files ReadMelli(string s)
        {
            return db.Filess.Where(i => i.CodeMelli == s && i.DeleteStatus==false).FirstOrDefault();

        }

        public Files ReadName(string s)
        {
            return db.Filess.Where(i => i.CodeMelli == s && i.DeleteStatus == false).SingleOrDefault();
        }
        public List<string> ReadCodeMelii()
        {
            return db.Filess.Where(i => i.DeleteStatus == false).Select(i=>i.CodeMelli).ToList();
        }
        public List<Files> ReadALL()
        {
            return db.Filess.Where(i => i.DeleteStatus == false).ToList();
        }
        public List<Files> FilesOfDoctor()
        {
            return db.Filess.Include("Doctor").Where(i => i.DeleteStatus == false).ToList();
        }

        public string Update(Files f, int id)
        {
            try
            {
                var q = db.Filess.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
            if (q != null)
            {
                    q.CodeMelli = f.CodeMelli;
                    q.FullName = f.FullName;
                    q.Phone = f.Phone;
                    q.Sex = f.Sex;
                    db.SaveChanges();
                    return " ویرایش با موفقیت انجام شد.";

            }
            else
            {
                return "موردی یافت نشد.";
            }
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات با خطایی مواجه شده است:\n" + e.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                var q = db.Filess.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
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
    }
}
