using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class GhooboozDAL
    {
        DB db = new DB();
       // public string Create(Ghobooz gh, Patiant p, Doctor d, List<Servieces> S, Files f, List<Tariffe>  t)
             public string Create(Ghobooz gh, Patiant p, Doctor d,  Files f)
        {
            //try
            //    //{
            //    //if (Read(f, d))
            //    //{
            gh.Doctor = db.Doctors.Find(d.id);
            gh.Files = db.Filess.Find(f.id);
            gh.Patiant = db.Patiants.Find(p.id);
        
            //foreach (var item in S)
            //{
            //    gh.Servieces.Add(db.Serviecess.Find(item.id));
            //}

            //foreach (var item in t)
            //{
            //    gh.Tariffe.Add(db.Tariffes.Find(item.id));
            //}
            db.Ghoboozs.Add(gh);
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

        public DataTable SearchPay(string date, string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.GhoboozPay");
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

        public DataTable SearchUnPay(string date, string doctor)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.GhoboozUnPay");
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

        public bool Ischecked(int id)
        {
            //try
            //{
            var q = db.Ghoboozs.Where(i => i.id == id && i.Ischeck == false).SingleOrDefault();
            if (q != null)
            {
                q.Ischeck = true;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            //}

            //catch (Exception)
            //{
            //    return false;
            //}


        }

        public Ghobooz Read(int id)
        {
            return db.Ghoboozs.Where(i => i.id == id).FirstOrDefault();
        }

        public DataTable GhabzPrint(int id)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.GhabzPrint");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public List<BE.Dto.TarrefeServiceVM> ReadView(int id)
        {
            List<BE.Dto.TarrefeServiceVM> listTarreffe = new List<BE.Dto.TarrefeServiceVM>();
            foreach (DataRow dtRow in GhabzPrint(id).Rows)
            {
                BE.Dto.TarrefeServiceVM b = new BE.Dto.TarrefeServiceVM();
                b.NameOfService = dtRow[1].ToString();
                b.PortionInsuarance = Convert.ToDouble(dtRow[2]);
                b.PortionOrganizatin = Convert.ToDouble(dtRow[4]);
                b.OtherCost = Convert.ToDouble(dtRow[3]);
                listTarreffe.Add(b);
            }
            return listTarreffe;
        }

    }
    }
