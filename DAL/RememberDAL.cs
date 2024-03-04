using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
   public class RememberDAL
    {
        DB db = new DB();
        Remember r = new Remember();
        public void Create(Remember r)
        {
            if (Read(r))
            {
                
                db.Remembers.Add(r);
                db.SaveChanges();
                
            }
        }

        public bool Read(Remember r)
        {
            //فعل تکراری بودن
            var q = db.Remembers.Where(i => i.usernams == r.usernams && i.passwords==r.passwords );
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> Readusername()
        {
            return db.Users.Where(i=>i.Remember==true).Select(i => i.UserName).ToList();
        }
        public List<string> ReadPassword()
        {
            return db.Remembers.Select(i => i.passwords).ToList();
        }
        public string ReadPassword1(string username)
        {
           return db.Remembers.Where(i => i.usernams == username).Select(i => i.passwords).SingleOrDefault();
            
        }
        public void Changeuser(string s, string p)
        {
            var q = db.Remembers.Where(i => i.usernams == s ).SingleOrDefault();
            q.passwords = p;
            db.SaveChanges();
        }
    }
}
