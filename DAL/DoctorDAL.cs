using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;


namespace DAL
{
    public class DoctorDAL
    {
        DB db = new DB();
        Doctor d = new Doctor();
        public string create(Doctor d)
        {
            try
            {
                if (Read(d))
                {
                    db.Doctors.Add(d);
                    db.SaveChanges();
                   return "اطلاعات ذخیره شد";
                }
                else
                {
                    return "کدنظام پزشکی تکراری است.";
                }

            }
            catch (Exception e)
            {
                return "در ثبت اطلاعات مشکلی وجود دارد:\n" + e.Message;
            }


        }
        public List<Doctor> AcceptPation(int id)
        {
           
            return db.Doctors.Include("Patiants").Where(i =>i.id==id  && i.DeleteStatus == false).ToList();
        }
        public List<Doctor> AcceptPationALLdoctor()
        {
            return db.Doctors.Include("Patiants").Where(i => i.DeleteStatus == false).ToList();
        }
        public bool Read(Doctor p)
        {

            //فعل تکراری بودن
            var q = db.Doctors.Where(i => i.DoctorNumber == p.DoctorNumber && i.DeleteStatus == false);
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
            cmd = new SqlCommand("dbo.ReadDoctor");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
            cmd = new SqlCommand("dbo.SearchDoctor");
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

        public Doctor Read(int id)
        {
            return db.Doctors.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }
        public Doctor ReadN(string s)
        {
            return db.Doctors.Where(i => i.Name ==s && i.DeleteStatus == false).SingleOrDefault();

        }
        public List<Doctor> ReadName()
        {
            return db.Doctors.Where(t => t.DeleteStatus == false).ToList();
        }
        public int  Getid(string s)
        {
           
            return db.Doctors.First(i => i.Name == s && i.DeleteStatus == false).id;
        }
        //public List<Doctor> ReadName()
        //{
        //    return db.Doctors.Where(i => i.DeleteStatus == false).ToList();
        //}
        //public DataTable Search(string s)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalOfficeDB2; Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable dt = new DataTable();
        //    cmd = new SqlCommand("dbo.SearchDoctor");
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
        public string Update(Doctor d, int id)
        {
            try
            {
                var q = db.Doctors.Where(i => i.DoctorNumber == d.DoctorNumber && i.DeleteStatus == false).FirstOrDefault();
            
                if (q != null)
                {
                    //if (Read(d))
                    //{
                        q.Name = d.Name;
                   
                    q.Phone = d.Phone;
                    q.CodeMelli = d.CodeMelli;
                    q.Address = d.Address;
                    q.DoctorNumber = d.DoctorNumber;
                    q.sex = d.sex;
                    q.Pic =d.Pic;
                    
                    q.birhthday =d.birhthday;
                    db.SaveChanges();
                    return "ویرایش اطلاعات با موفقیت انجام شد";
                    //}
                    //else
                    //{
                    //    return "کدنظام پزشکی تکراری است.";
                    //}
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
            var q = db.Doctors.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
            try
            {
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.SaveChanges();
                    return "حذف با موفقیت انجام شد";
                }

                else
                {
                    return "کاربر یافت نشد";
                }
            }
            catch (Exception e)
            {
                return "مشکلی در حذف اطلاعات وجود دارد.:\n" + e.Message;
            }

        }
    }
}
