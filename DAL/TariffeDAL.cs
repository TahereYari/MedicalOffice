using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
using static BE.Dto.TarrefeServiceVM;

namespace DAL
{
    public class TariffeDAL
    {
        DB db = new DB();
        Tariffe t = new Tariffe();

        public string Create(Tariffe t, Insuarance i, Servieces s)
        {
            try
            {

                if (Read(t, i, s))
                {
                    t.Insuarance = db.Insuarances.Find(i.id);
                    t.Serviece = db.Serviecess.Find(s.id);
                    db.Tariffes.Add(t);
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

        public DataTable Read()
        {
            //این فعل برای نمایش دیتای دیتا گرید است
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.ReadTarifee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }


        public bool Read(Tariffe t, Insuarance i, Servieces s)
        {
            //فعل تکراری بودن
            var q = db.Tariffes.Include("Insuarance").Include("Serviece").Where(j => j.Insuarance.id == i.id && j.Serviece.id == s.id && j.DeleteStatus == false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public DataTable Read()
        //{
        //    //این فعل برای نمایش دیتای دیتا گرید است
        //    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalOfficeDB2; Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand();
        //    cmd = new SqlCommand("dbo.ReadTarrife");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = con;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);

        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds.Tables[0];


        //}
        public DataTable Search(string s)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.SearchTarrife");
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


        //public async Task<IPagedList<Tariffe>> getpagedListAsync(int pagenumber, int pagesize,Insuarance i)
        //{

        //    return await Task.Factory.StartNew(() =>

        //    {
        //        //var q = db.Insuarances.Select(ins => ins.Name).SingleOrDefault();
        //       // Task<IPagedList<Insuarance>> q = db.Insuarances.Where(ii=> ii.id ==i.id ).Select(ii=>i.Name).ToPagedList(pagenumber, pagesize);



        //        return db.Tariffes.Where(j => j.DeleteStatus == false ).OrderBy(t => t.id).ToPagedList(pagenumber, pagesize);


        //    }
        //    );
        //}

        public Tariffe Read(int id)
        {
            return db.Tariffes.Include("Insuarance").Include("Serviece").Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }

        public string Update(Tariffe t, int id, Insuarance i, Servieces s)

        {
            var q = db.Tariffes.Where(j => j.id == id && i.DeleteStatuse == false).FirstOrDefault();
            try
            {
                if (q != null)
                {
                    //if (Read(t,i,s))
                    //{

                    q.Insuarance.NameOfInsutance = i.NameOfInsutance;
                    q.Serviece.NameOfService = s.NameOfService;

                    q.PortionInsuarance = t.PortionInsuarance;
                    q.PortionOrganizatin = t.PortionOrganizatin;
                    q.OtherCost = t.OtherCost;
                    db.SaveChanges();
                    return "ویرایش با موفقیت انجام شد.";
                    //}
                    //else
                    //{
                    //    return "اطلاعات وارد شده تکراری است.";
                    //}

                }
                else
                {
                    return "موردی یافت نشد.";
                }
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات با مشکل مواجه شده است:\n" + e.Message;
            }

        }
        public string Delete(int id)
        {
            var q = db.Tariffes.Where(j => j.id == id && j.DeleteStatus == false).FirstOrDefault();
            try
            {
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
                return "حذف با مشکل مواجه شده است:\n" + e.Message;
            }
        }

        public Tariffe ServiceTariffe(string Insuarance, string Serviece)
        {
            return  db.Tariffes.Include("Insuarance").Include("Serviece").Where(i => i.Insuarance.NameOfInsutance == Insuarance && i.Serviece.NameOfService == Serviece && i.DeleteStatus == false).FirstOrDefault(); ;

        }

        //public List< Tariffe> ServiceTariffe1(string Insuarance, string Serviece)
        //{
        //  //  return db.Tariffes.Include("Insuarance").Include("Serviece").Where(i => i.Insuarance.NameOfInsutance == Insuarance && i.Serviece.NameOfService == Serviece && i.DeleteStatus == false).ToList(); ;
        //    var result = from t in db.Tariffes
        //                   join s in db.Serviecess
        //                 on t.id equals s.id into empDept

        //                 select new
        //                 {
        //                     OtherCost = t.OtherCost,
        //                     po=t.PortionOrganizatin,
        //                     pi=t.PortionInsuarance,
        //                     sn=t.Serviece.NameOfService

        //                 }
        //}
        public Tariffe ServiceTariffeAzad(string Serviece)
        {
            var q = db.Tariffes.Include("Insuarance").Include("Serviece").Where(i => i.Serviece.NameOfService == Serviece && i.DeleteStatus == false).FirstOrDefault();
            q.OtherCost = db.Tariffes.Max(i => i.OtherCost);
            q.PortionInsuarance = db.Tariffes.Max(i => i.PortionInsuarance);
            q.PortionOrganizatin = db.Tariffes.Max(i => i.PortionOrganizatin);
            return q;


        }

      public  DataTable Read1(string Insuarance, string Serviece)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.ReadSI");
            cmd.Parameters.AddWithValue("@NameOfInsutance", Insuarance);
            cmd.Parameters.AddWithValue("@NameOfService", Serviece);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }
        public DataTable ServiceAzzad(string Serviece)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.SerViceAzad");
            cmd.Parameters.AddWithValue("@NameOfService", Serviece);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }
        public BE.Dto.TarrefeServiceVM ReadView2(string Serviece)
        {
            BE.Dto.TarrefeServiceVM listTarreffe = new BE.Dto.TarrefeServiceVM();
            foreach (DataRow dtRow in ServiceAzzad(Serviece).Rows)
            {
                BE.Dto.TarrefeServiceVM b = new BE.Dto.TarrefeServiceVM();
                b.NameOfService = dtRow[3].ToString();
                b.PortionInsuarance = Convert.ToDouble(dtRow[2]);
                b.PortionOrganizatin = Convert.ToDouble(dtRow[0]);
                b.OtherCost = Convert.ToDouble(dtRow[1]);
                listTarreffe = b;
            }
            return listTarreffe;
        }
        public List<BE.Dto.TarrefeServiceVM> ReadView(string Insuarance, string Serviece)
        {
            List<BE.Dto.TarrefeServiceVM> listTarreffe = new List<BE.Dto.TarrefeServiceVM>();
            foreach (DataRow dtRow in Read1(Insuarance,Serviece).Rows)
            {
                BE.Dto.TarrefeServiceVM b = new BE.Dto.TarrefeServiceVM();
                b.NameOfService = dtRow[1].ToString();
                b.PortionInsuarance = Convert.ToDouble(dtRow[2]);
                b.PortionOrganizatin = Convert.ToDouble(dtRow[3]);
                b.OtherCost = Convert.ToDouble(dtRow[4]);
                listTarreffe.Add(b);
            }
            return listTarreffe;
        }
//*********************************
        public BE.Dto.TarrefeServiceVM ReadView1(string Insuarance, string Serviece)
        {
            BE.Dto.TarrefeServiceVM listTarreffe = new BE.Dto.TarrefeServiceVM();
            foreach (DataRow dtRow in Read1(Insuarance, Serviece).Rows)
            {
                BE.Dto.TarrefeServiceVM b = new BE.Dto.TarrefeServiceVM();
                b.NameOfService = dtRow[3].ToString();
                b.PortionInsuarance = Convert.ToDouble(dtRow[2]);
                b.PortionOrganizatin = Convert.ToDouble(dtRow[0]);
                b.OtherCost = Convert.ToDouble(dtRow[1]);
                //    listTarreffe.NameOfService=b.NameOfService;
                //    listTarreffe.PortionInsuarance = b.PortionInsuarance;
                //    listTarreffe.PortionOrganizatin = b.PortionOrganizatin;
                //    listTarreffe.OtherCost = b.OtherCost;
                listTarreffe =b;
            }
            return listTarreffe;
        }

        //public List<BE.Dto.TarrefeServiceVM> ReadView(string Insuarance, string Serviece)
        //{
        //    DataTable Read()
        //      {
        //        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
        //        SqlCommand cmd = new SqlCommand();
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter da = new SqlDataAdapter();
        //        da.SelectCommand = new SqlCommand("dbo.ReadSI");
        //        da.SelectCommand = new SqlCommand();
        //        da.SelectCommand.Parameters.AddWithValue("@NameOfInsutance", Insuarance);
        //        da.SelectCommand.Parameters.AddWithValue("@NameOfService", Serviece);
        //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        da.SelectCommand.Connection = con;
        //        da.Fill(dt);
        //        return dt;

        //    }
        //    List<BE.Dto.TarrefeServiceVM> listTarreffe = new List<BE.Dto.TarrefeServiceVM>();
        //    foreach (DataRow dtRow in this.Read().Rows)
        //    {
        //        BE.Dto.TarrefeServiceVM b = new BE.Dto.TarrefeServiceVM();
        //        b.NameOfService = dtRow[1].ToString();
        //        b.PortionInsuarance = Convert.ToDouble(dtRow[2]);
        //        b.PortionOrganizatin = Convert.ToDouble(dtRow[3]);
        //        b.OtherCost = Convert.ToDouble(dtRow[4]);
        //        listTarreffe.Add(b);
        //    }
        //    return listTarreffe;
        //}



    }
}
