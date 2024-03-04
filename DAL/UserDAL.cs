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
    public  class UserDAL
    {
        DB db = new DB();
        public string Create(User u, UserGroup ug)
        {

            try
            {
                if (Read(u))
                {
                    u.UserGroup = db.UserGroups.Find(ug.id);
                    db.Users.Add(u);
                    db.SaveChanges();
                    return "ثبت نام با موفقیت انجام شد";
                }
                else
                {
                    return "نام کاربری تکراری است.";
                }

            }
            catch (Exception e)
            {
                return "خطایی درافزودن کاربر وجود دارد:\n" + e.Message;
            }


        }

        public bool Read(User u)
        {
            //فعل تکراری بودن
            var q = db.Users.Where(i => i.UserName == u.UserName && i.DeleteStatus==false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User Read(int id)
        {
            //این فعل برای ویرایش اطلاعات استفاده میشود
            return db.Users.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
        }
        public void ReadActive(int id,bool a)
        {
            //این فعل برای ویرایش اطلاعات استفاده میشود
            var q= db.Users.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();

            q.Active = a;
            db.SaveChanges();
        }
        public DataTable Read()
        {
            //این فعل برای نمایش دیتای دیتا گرید است
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.ReadUser");
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
            cmd = new SqlCommand("dbo.searchUser");
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
        public User ReadU(string s)
        {
            return db.Users.Where(i => i.UserName == s && i.DeleteStatus == false).SingleOrDefault();
        }
      
        public User Readid(int id)
        {
            return db.Users.Where(i => i.id == id && i.DeleteStatus == false).SingleOrDefault();
        }
        public bool IsRegisterd()
        {
            return db.Users.Count() > 0;

        }
        public List<string> ReadUserName()
        {
            return db.Users.Where(i => i.DeleteStatus == false).Select(i => i.UserName).ToList();
        }

        public string Update(User u, int id)
        {
            var q = db.Users.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
            try
            {
                if (q != null)
                {
                    q.Name = u.Name;
                   q.UserName = u.UserName;
                 //   q.Password = u.Password;
                    q.Pic = u.Pic;
                    db.SaveChanges();
                    return "ویرایش اطلاعات با موفقیت انجام شد";
                }

                else
                {
                    return "کاربر یافت نشد.";
                }
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات با خطایی مواجه شده است:\n" + e.Message;
            }
        }

        public string Delete(int id)
        {
            var q = db.Users.Where(i => i.id == id && i.DeleteStatus == false).FirstOrDefault();
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
                    return "کاربر یافت نشد";
                }
            }

            catch (Exception e)
            {
                return "حذف با مشکل مواجه شده است:\n" + e.Message;
            }
        }

        public User Login(string s, string p)
        {
            return db.Users.Include("UserGroup").Where(i => i.UserName == s && i.Password == p && i.DeleteStatus == false).SingleOrDefault();
        }

        public void Changeuser(string s, string p)
        {
           var q= db.Users.Include("UserGroup").Where(i => i.UserName == s &&i.DeleteStatus==false).SingleOrDefault();
            q.Password = p;
            db.SaveChanges();
        }
        public bool Access(User u, string s, int a)
        {
            UserGroup ug = db.UserGroups.Include("AccessUserGroups").Where(i => i.id == u.UserGroup.id && i.DeleteStatuse == false).FirstOrDefault();
            AccessGroup ac = ug.AccessUserGroups.Where(z => z.Section == s && z.DeleteStatuse == false).FirstOrDefault();
            if (a == 1)
            {
                return ac.CanEnter;
            }
            else if (a == 2)
            {
                return ac.CanCreate;
            }
            else if (a == 3)
            {
                return ac.CanUpdate;
            }
            else
            {
                return ac.CanDelete;
            }
        }

        public string ReadPassword1(string username)
        {
            return db.Users.Where(i => i.UserName == username && i.DeleteStatus==false && i.Remember==true).Select(i => i.Password).SingleOrDefault();

        }

        public void remember(string s)
        {
            var q = db.Users.Include("UserGroup").Where(i => i.UserName == s && i.DeleteStatus == false).SingleOrDefault();
            q.Remember = true;
            db.SaveChanges();
        }

        public List<User> ReadPatiants()
        {
            //پذیرش ثبت شده توسط هر کاربر
            return db.Users.Include("Patiants").Where(i => i.DeleteStatus == false).ToList();
        }

    }
}
