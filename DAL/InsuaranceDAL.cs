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
   public  class InsuaranceDAL
    {
        DB db = new DB();
        Insuarance i = new Insuarance();


        public string Create(Insuarance i)
        {
            try
            {
                if(Read(i))
                {
                    db.Insuarances.Add(i);
                    db.SaveChanges();
                    return "ثبت با موفقیت انجام شد.";

                }

                else
                {
                    return "کدبیمه وارد شده تکراری است.";
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
            cmd = new SqlCommand("dbo.ReadInsurance");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public Insuarance Read(int id)
        {
            return db.Insuarances.Where(t => t.id == id && i.DeleteStatuse==false).FirstOrDefault();
        }
        public bool Read(Insuarance i)
        {
            //فعل تکراری بودن
            var q = db.Insuarances.Where(j => j.Code == i.Code &&i.DeleteStatuse==false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Insuarance ReadN(String s)
        {
            return db.Insuarances.Where(i => i.NameOfInsutance == s && i.DeleteStatuse==false).SingleOrDefault();
        }
        public DataTable Search(string s)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("dbo.SearchInsurance");
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
        public int CountOfInsuance()
        {
            
            var q = db.Insuarances.Where(i => i.DeleteStatuse==false );
            
            return q.Count(); 
            
        }
        //public List<string> ReadName()
        //{
        //    return db.Insuarances.Where(i => i.DeleteStatuse == false).Select(i => i.Name).ToList();
        //}
        public List<Insuarance> ReadName()
        {
            return db.Insuarances.Where(t=>t.DeleteStatuse==false).ToList();
        }
        //public async Task<IPagedList<Insuarance>> getpagedListAsync(int pagenumber , int pagesize )
        //{
        //    return await Task.Factory.StartNew(() =>

        //    {

        //       return db.Insuarances.Where(i => i.DeleteStatuse == false).OrderBy(i => i.id).ToPagedList(pagenumber, pagesize);
               
        //    }
        //    );
        //}
        public string Update(Insuarance i, int id)

        {
            var q = db.Insuarances.Where(t => t.id == id && t.DeleteStatuse == false).FirstOrDefault();
            try
            {
                if (q != null)
                {
                    q.NameOfInsutance = i.NameOfInsutance;
                    q.Code = i.Code;
                    db.SaveChanges();
                    return "ویرایش با موفقیت انجام شد.";

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
            try
            {
                var q = db.Insuarances.Where(t => t.id == id && t.DeleteStatuse == false).FirstOrDefault();
            
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


}
}
