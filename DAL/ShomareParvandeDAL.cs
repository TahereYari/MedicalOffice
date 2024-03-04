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
   public class ShomareParvandeDAL
    {
        DB db = new DB();
        public string Create(ShomareParvande sh, Files f, Doctor d)
        {
            try
            {

                if (Read(f,d))
            {

                sh.doctor = db.Doctors.Find(d.id);
            sh.Filee = db.Filess.Find(f.id);
            Random rnd = new Random();
            string s = rnd.Next(1000000).ToString();
            var q = db.ShomareParvandes.Where(z => z.FilesNumber == s);
            while (q.Count() > 0)
            {
                s = rnd.Next(1000000).ToString();
            }
            sh.FilesNumber = s;
            db.ShomareParvandes.Add(sh);
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

        public ShomareParvande ReadSHD(string s, Doctor d)
        {
            return db.ShomareParvandes.Include("Filee").Include("doctor").Where(i => i.FilesNumber == s && i.doctor.id == d.id && i.DeleteStatus == false).FirstOrDefault();

        }
        public ShomareParvande ReadSH(int idf)
        {
            return db.ShomareParvandes.Where(i => i.Filee.id == idf && i.DeleteStatus == false).FirstOrDefault();

        }

        public List<string> ReadShomare(string d)
        {
            return db.ShomareParvandes.Where(i => i.DeleteStatus == false && i.doctor.Name==d && i.Filee.DeleteStatus==false).Select(i => i.FilesNumber).ToList();
        }
        public ShomareParvande ReadFilesNumber(string s)
        {
            return db.ShomareParvandes.Where(i => i.FilesNumber == s && i.DeleteStatus == false).SingleOrDefault();
        }
        public DataTable Search(string s)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.Searchparvande");
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

        public bool Read(Files f, Doctor d)
        {
            //فعل تکراری بودن
            var q = db.ShomareParvandes.Where(i => i.doctor.id == d.id && i.Filee.id==f.id && i.DeleteStatus == false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
