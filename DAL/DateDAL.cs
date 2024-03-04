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
    public class DateDAL
    {
        DB db = new DB();
        public void Create(Date da, string ti, Doctor d)
        {

            //try
            //{

            if (Read(da,ti,d))
            {
                da.doctor = db.Doctors.Find(d.id);
                da.Times1 = ti;
                db.Dates.Add(da);

                db.SaveChanges();

                //    return "ثبت با موفقیت انجام شد.";
            }
            //else
            //{
            //    //return "اطلاعات وارد شده تکراری است.";
            //    //Create(da, ti, d);
            //    var q = db.Dates.Where(i => i.date1 == da.date1 && i.Times1==ti&&i.doctor.id==d.id).FirstOrDefault();
            //    db.Dates.Remove(q);
            //    //da.doctor = db.Doctors.Find(d.id);
            //    //da.Times1 = ti;
            //    //db.Dates.Add(da);

            //    //db.SaveChanges();
            //}


            //}
            //    catch 
            //    {}
        }
        public bool Read(Date da, string ti, Doctor d)
        {
            //فعل تکراری بودن
            var q = db.Dates.Where(i => i.date1 == da.date1 && i.doctor.id==d.id && i.Times1==ti && i.DeleteStatus == false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Search(string date, string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ReadDates");
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
        public Date Read(int id)
        {
            return db.Dates.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }

        public string Delete(int id)
        {
            try
            {
                var q = db.Dates.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
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

        //public List<Date> NobatOfDoctor1(string date,string d)
        //{
        //    return db.Dates.Include("Doctor").Include("times").Where(i => i.doctor.Name == d &&i.date1==date && i.DeleteStatus == false ).ToList();
        //}



        public List<BE.Dto.TimesForeNoabat> ReadView(string date, string doctor)
        {
            List<BE.Dto.TimesForeNoabat> Times = new List<BE.Dto.TimesForeNoabat>();
            foreach (DataRow dtRow in Search(date, doctor).Rows)
            {
                BE.Dto.TimesForeNoabat b = new BE.Dto.TimesForeNoabat();
                b.times = dtRow[0].ToString();

                Times.Add(b);
            }
            return Times;
        }

        public void Noabat(string da, string d, string ti)
        {
           var q = db.Dates.Where(i => i.date1 == da && i.DeleteStatus == false && i.doctor.Name == d.ToString() && i.Times1==ti ).SingleOrDefault();
            q.Reserve = true;
            db.SaveChanges();
        }
        public void reception(string da, Doctor d, string ti)
        {
            var q = db.Dates.Where(i => i.date1 == da && i.DeleteStatus == false && i.doctor.id == d.id && i.Times1 == ti).SingleOrDefault();
            q.Reserve = true;
            db.SaveChanges();
        }

        public void NoabatAfterDel(string da, string d, string ti)
        {
            var q = db.Dates.Where(i =>i.date1 == da && i.DeleteStatus == false && i.doctor.Name == d && i.Times1 == ti).SingleOrDefault();
            q.Reserve = false;
            db.SaveChanges();
        }

        //public DataTable TrueReserve(string date, string time, string doctor)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable dt = new DataTable();
        //    cmd = new SqlCommand("dbo.TrueReserve");
        //    cmd.Parameters.AddWithValue("@date", date);
        //    cmd.Parameters.AddWithValue("@time", time);
        //    cmd.Parameters.AddWithValue("@NameOfDoctor", doctor);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = con;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds.Tables[0];
        //}
    }
}

