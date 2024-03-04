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
    public class ProductDAL
    {
        Product p = new Product();
        DB db = new DB();

        public string Create(Product p, Doctor d)
        {
            //try
            //{
                if (Read(p))
                {
                    p.Doctor = db.Doctors.Find(d.id);
                db.Products.Add(p);
                db.SaveChanges();
                return "ثبت با موفقیت انجام شد.";
                }
                else
                {
                    return "اطلاعات وارد شده تکراری است.";
                }


            //}
            //catch (Exception e)
            //{
            //    return "ثبت اطلاعات با مشکلی مواجه شده است:\n" + e.Message;

            //}

        }

        public bool Read(Product p)
        {
            //فعل تکراری بودن
            var q = db.Products.Where(j => j.Code==p.Code);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
        //public DataTable Search(string s)
        //{
        //    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalOfficeDB2; Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand();
        //    DataTable dt = new DataTable();
        //    cmd = new SqlCommand("dbo.SearchProduct");
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
        public Product Read(int id)
        {
            return db.Products.Include("Doctor").Where(i => i.id == id).FirstOrDefault();
        }
        //public DataTable Read()
        //{
        //    //این فعل برای نمایش دیتای دیتا گرید است
        //    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalOfficeDB2; Integrated Security=True");
        //    SqlCommand cmd = new SqlCommand();
        //    cmd = new SqlCommand("dbo.ReadPatiant");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = con;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);

        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds.Tables[0];


        //}

        public string Update(Product p, int id, Doctor d)

        {
            var q = db.Products.Where(j => j.id == id).FirstOrDefault();
            try
            {
                if (q != null)
                {
                    //if (Read(t))
                    //{
      
                    q.Doctor.Name = d.Name;

                    q.Code = p.Code;
                    q.Name = p.Name;
                    q.NameDeliver = p.NameDeliver;
                    q.Price = p.Price;
                    q.Stock = p.Stock;
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
            var q = db.Products.Where(j => j.id == id).FirstOrDefault();
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

    }
}
