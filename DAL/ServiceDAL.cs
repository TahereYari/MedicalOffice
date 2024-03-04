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
    public class ServiceDAL
    {
        DB db = new DB();
        public string Create(Servieces s,Doctor d)
        {
            try
            {
                if (Read(s))
                {
                   s.Doctor = db.Doctors.Find(d.id);
               
                    db.Serviecess.Add(s);
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

        public bool Read(Servieces s)
        {
            //فعل تکراری بودن
      
            var q = db.Serviecess.Include("Doctor").Where(i => i.Code == s.Code && i.DeleteStatus == false) ;
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Read()
        {
            //این فعل برای نمایش دیتای دیتا گرید است
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.ReadService");
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }

        public DataTable ReadForReport()
        {
            //این فعل برای نمایش دیتای دیتا گرید است
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.ReadServiceByDoctor");
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
            cmd = new SqlCommand("dbo.SearchService");
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

        public Servieces Read(int id)
        {
            return db.Serviecess.Include("Doctor").Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }
        public Servieces ReadName(string s)
        {
            return db.Serviecess.Where(i => i.NameOfService == s && i.DeleteStatus==false).SingleOrDefault();
        }
        public List<Servieces>ReadALL()
        {
            return db.Serviecess.Where(i => i.DeleteStatus == false).ToList();
        }
        //public List<Servieces> ServiceOfDoctor()
        //{
        //    return db.Serviecess.Where(i => i.DeleteStatus == false).ToList();
        //}

        public List<Servieces> ServiceOfDoctor1(int id)
        {
            return db.Serviecess.Include("Doctor").Where(i => i.Doctor.id == id && i.DeleteStatus == false).ToList();
        }
        //public Servieces ServiceOfDoctor(string s)
        //{
        //    return db.Serviecess.Include("Doctor").Where(i => i.Name == s && i.DeleteStatus == false).SingleOrDefault();
        //}

        public string Update(Servieces s, int id,Doctor d)
        {
            try
            {
                var q = db.Serviecess.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
                if(q!=null)
                {
                
                        q.NameOfService = s.NameOfService;
                        q.Code = s.Code;
                  q.Doctor.Name = d.Name;
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
                var q = db.Serviecess.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
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
                return "حذف اطلاعات با مشکلی مواجه شده است:\n" + e.Message;

            }

        }
    }
}
