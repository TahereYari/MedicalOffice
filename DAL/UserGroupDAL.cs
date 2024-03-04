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
    public class UserGroupDAL
    {
        DB db = new DB();

        public string Create(UserGroup ug)
        {
            try
            {
                if (Read(ug))
                {

                    db.UserGroups.Add(ug);
                    db.SaveChanges();
                    return " ثبت با موفقیت انجام شد.";
                }
                else
                {
                    return "نام گروه کاربری تکراری است.";
                }

            }

            catch (Exception e)
            {
                return "خطایی در ثبت اطلاعات رخ داده است" + e.Message;
            }
        }

        public bool Read(UserGroup ug)
        {
            var q = db.UserGroups.Where(i => i.title == ug.title && i.DeleteStatuse == false);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public UserGroup ReadN(string s)
        {
            return db.UserGroups.Where(i => i.title == s &&i.DeleteStatuse == false).SingleOrDefault();
        }
        public UserGroup ReadByTitle(string t)
        {
            return db.UserGroups.Where(x => x.title == t && x.DeleteStatuse == false).SingleOrDefault();
        }

        public List<string> ReadGroup()
        {
            return db.UserGroups.Where(i => i.DeleteStatuse==false).Select(i => i.title).ToList();
        }
    }
}
