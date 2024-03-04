using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


namespace DAL
{
   public class PationtDAL
    {
        DB db = new DB();
     public string Create(Patiant p,  Insuarance i,Doctor d, List<Servieces> S, Files f,User u)
           
        {
            try
            {
            //    if (Read(p,d,f))
            //{

                p.Insuarance = db.Insuarances.Find(i.id);
            p.Files = db.Filess.Find(f.id);
            p.Doctor=db.Doctors.Find(d.id);
            p.User = db.Users.Find(u.id);
            foreach (var item in S)
            {
                p.Servieces.Add(db.Serviecess.Find(item.id));
            }
            db.Patiants.Add(p);
            db.SaveChanges();
            return "ثبت با موفقیت انجام شد.";
        //}
        //    else
        //    {
        //        return "اطلاعات وارد شده تکراری است.";
        //    }


            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی مواجه شده است:\n" + e.Message;

            }
        }

        public bool Read(Patiant p, Doctor d, Files f)
        {

            //فعل تکراری بودن
            var q = db.Patiants.Where(i => i.Doctor.id == d.id &&i.Files.id==f.id && i.VisitDate==p.VisitDate && i.DeleteStatuse == false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Read(string date)
        {
            //این فعل برای نمایش دیتای دیتا گرید است
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ReadPatiant");
            cmd.Parameters.AddWithValue("@search", date);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];


        }


        public DataTable Search(string date,string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ListPasianOfDate");
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
        public DataTable PatiantLastWeek(string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ListOfPatiantLastWeek");
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
        public DataTable ReadBetween(string date1, string date2)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ReadBetween");
            cmd.Parameters.AddWithValue("@date1", date1);
            cmd.Parameters.AddWithValue("@date2", date2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable RedBetweenByName(string date1, string date2, string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.RedBetweenByName");
            cmd.Parameters.AddWithValue("@date1", date1);
            cmd.Parameters.AddWithValue("@date2", date2);
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
        public DataTable ALLListOfPatiantLastWeek()
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ALLListOfPatiantLastWeek");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        //public bool Read(Files f, Doctor d)
        //{
        //    //فعل تکراری بودن

        //    var q = db.Patiants.Where(i => i.CodeMelli == f.CodeMelli && i.Doctor.id == f.Doctor.id);
        //    if (q.Count() == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public Files PatiantLastWeek(string lastWeek,string d)
        //{
        //    // var q = db.Patiants.Where((i => GetPersianDayes(i.VisitDate) <= GetPersianDayes(lastWeek)) && (db.Doctors.Where(j=>j.Name==d)));
        //    foreach(var item in db.Doctors)
        //    {
        //        if(item.Name==d)
        //        {
        //            foreach (var i in db.Patiants)
        //            {
        //                if(GetPersianDayes(i.VisitDate) <= GetPersianDayes(lastWeek))
        //                {
        //                    foreach(var x  in db.Filess)
        //                    {
        //                        return x.FullName;
        //                    }
        //                }
        //            }
        //        }

        //    }
        //}
        public DateTime GetPersianDayes(string date1)
        {
            int year1 = Convert.ToInt16(date1.Substring(0, 4));
            int month1 = Convert.ToInt16(date1.Substring(5, 2));
            int day1 = Convert.ToInt16(date1.Substring(8, 2));
            PersianCalendar c = new PersianCalendar();
            DateTime d1 = c.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
            return d1;
        }
        public bool AcceptPation(string date1, string date2)
        {

            var q = db.Patiants.Where(i => GetPersianDayes(i.VisitDate) >= GetPersianDayes(date1) && GetPersianDayes(i.VisitDate) <= GetPersianDayes(date2) );
            return true;
        }

        public List<Patiant> AcceptPationLastWeek(string date1, string date2)
        {
            
             return db.Patiants.Where(i => GetPersianDayes(i.VisitDate) >= GetPersianDayes(date1) && GetPersianDayes(i.VisitDate) <= GetPersianDayes(date2) && i.DeleteStatuse == false).ToList();

        }


        public Patiant Read(int id)
        {
            return db.Patiants.Include("Doctor").Where(i => i.id == id && i.DeleteStatuse == false).FirstOrDefault();
        }
        //public Patiant ReadName(string s)
        //{
        //    return db.Patiants.Where(i => i.FullName == s && i.DeleteStatuse == false).SingleOrDefault();
        //}
      
        public List<Patiant> ReadALL(string d)
        {
            return db.Patiants.Include("Doctor").Where(i => i.DeleteStatuse == false && i.Doctor.Name==d).ToList();
        }
        public int count()
        {
            return db.Patiants.Count();
        }
        public List<Patiant> DoctorOfPatiant()
        {
            return db.Patiants.Include("Doctor").Where(i => i.DeleteStatuse == false).ToList();
        }

        //public string Update(Files f, int id, Doctor d)
        //{
        //    //    try
        //    //    {
        //    var q = db.Patiants.Where(i => i.id == id).FirstOrDefault();
        //    if (q != null)
        //    {
        //        //if (Read(s, d))
        //        //{
        //        q.Name = f.Name;
        //        q.CodeMelli = f.CodeMelli;
        //        q.Doctor.Name = d.Name;
        //        q.Phone = f.Phone;
        //        q.Sex = f.Sex;
        //        db.SaveChanges();
        //        return " ویرایش با موفقیت انجام شد.";

        //        //}
        //        //else
        //        //{
        //        //    return "اطلاعات وارد شده تکراری است.";
        //        //}


        //    }
        //    else
        //    {
        //        return "موردی یافت نشد.";
        //    }
        //    //}
        //    //catch(Exception e)
        //    //{
        //    //    return "ویرایش اطلاعات با خطایی مواجه شده است:\n" + e.Message;
        //    //}
        //}

        //public List<Patiant> ReadDD(DateTime s, Doctor d)
        //{
        //    return db.Patiants.Include("Doctors").Include("Files").Where(i => i.DeleteStatuse == false && i.VisitDate==s && i.Doctors.i==d.id).ToList();
        //}
        public string Delete(int id)
        {
            try
                {
                    var q = db.Patiants.Where(i => i.id == id && i.DeleteStatuse == false).FirstOrDefault();
                    if (q != null)
                    {
                        q.DeleteStatuse = true;
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
                return "حذف با مشکل مواجه شده است:\n" + e.Message;
            }

        }
        public DataTable ListPatiant(string date1,string date2)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ListPatiant");
            cmd.Parameters.AddWithValue("@date1", date1);
            cmd.Parameters.AddWithValue("@date2", date2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable ListPatiantByDoctor(string date1, string date2,string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ListPatiantByDoctor");
            cmd.Parameters.AddWithValue("@date1", date1);
            cmd.Parameters.AddWithValue("@date2", date2);
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

        public List<Patiant> ReadPatiants()
        {
            //پذیرش ثبت شده توسط هر کاربر
            return db.Patiants.Include("Files").Where(i => i.DeleteStatuse == false).ToList();
        }

    }
}
