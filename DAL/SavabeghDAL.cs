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
  public  class SavabeghDAL
    {
        DB db = new DB();

        public string Create(Savabegh s, Doctor d,Files f, ShomareParvande sh)
        {
            //try
            //{
            //if (Read(s, d))
            //{
                s.Doctor = db.Doctors.Find(d.id);
                s.Files = db.Filess.Find(f.id);
            s.ShomareParvandes = db.ShomareParvandes.Find(sh.id);
                db.Savabeghs.Add(s);
                db.SaveChanges();
                return "ثبت با موفقیت انجام شد.";
            //}
            //else
            //{
            //    return "اطلاعات وارد شده تکراری است.";
            //}


            //}
            //    catch (Exception e)
            //    {
            //        return "ثبت اطلاعات با مشکلی مواجه شده است:\n" + e.Message;

            //    }
        }

        //public bool Read(Savabegh s, Doctor d)
        //{
        //    //فعل تکراری بودن

        //    var q = db.Savabeghs.Where(i => i.Files.CodeMelli == s.Files.CodeMelli && i.Doctor.id == d.id);
        //    if (q.Count() == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public DataTable Read()
        //{
        //    //این فعل برای نمایش دیتای دیتا گرید است
        //    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalOfficeDB2; Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand();
        //    cmd = new SqlCommand("dbo.ReadSavabeghs");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = con;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);

        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds.Tables[0];


        //}

        //public DataTable Search(string s)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalOfficeDB2; Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable dt = new DataTable();
        //    cmd = new SqlCommand("dbo.SearchFile");
        //    cmd.Parameters.AddWithValue("@Search", s);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = con;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds.Tables[0];
        //}
        public Savabegh Read(int id)
        {
            return db.Savabeghs.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }
        public DataTable ReadNumber(string s)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ReadSavabegh");
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
        //public Savabegh ReadMD(string s, Doctor d)
        //{
        //    return db.Savabeghs.Where(i => i.CodeMelli == s && i.Doctor.id == d.id).FirstOrDefault();

        //}
        //public Savabegh ReadName(string s)
        //{
        //    return db.Savabeghs.Where(i => i.Biography == s && i.DeleteStatus == false).SingleOrDefault();
        //}
        public List<Savabegh> ReadALL()
        {
            return db.Savabeghs.Where(i => i.DeleteStatus == false).ToList();
        }
        public List<Savabegh> SavabeghOfPatiant()
        {
            return db.Savabeghs.Include("Doctor").Where(i => i.DeleteStatus == false).ToList();
        }

        public string Update(Savabegh sa, int id, Doctor d, Files f,ShomareParvande sh)
        {
            try
            {
                var q = db.Savabeghs.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
                if (q != null)
                {
                    

                        q.medicine = sa.medicine;
                        q.Biography = sa.Biography;
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
            var q = db.Savabeghs.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
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

        
    }
}
