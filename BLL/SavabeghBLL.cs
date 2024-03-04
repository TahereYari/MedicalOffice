using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;
namespace BLL
{
   public class SavabeghBLL
    {
        SavabeghDAL sadal = new SavabeghDAL();


        public string Create(Savabegh s, Doctor d, Files f,ShomareParvande sh)
        {
            return sadal.Create(s,d,f,sh);
        }

        //public bool Read(Savabegh f, Doctor d)
        //{
        //}

        //public DataTable Read()
        //{
        //    return sadal.Read();

        //}

        //public DataTable Search(string s)
        //{
        //    return sadal.Search(s);
        //}
        public Savabegh Read(int id)
        {
            return sadal.Read(id);
        }

        //public Savabegh ReadMD(string s, Doctor d)
        //{
        //    return db.Savabeghs.Where(i => i.CodeMelli == s && i.Doctor.id == d.id).FirstOrDefault();

        //}
        //public Savabegh ReadName(string s)
        //{
        //    return db.Savabeghs.Where(i => i.Biography == s && i.DeleteStatus == false).SingleOrDefault();
        //}
        public DataTable ReadNumber(string s)
        {
            return sadal.ReadNumber(s);
        }
        public List<Savabegh> ReadALL()
        {
            return sadal.ReadALL();
        }
        public List<Savabegh> SavabeghOfPatiant()
        {
            return sadal.SavabeghOfPatiant();
        }

        public string Update(Savabegh sa, int id, Doctor d, Files f, ShomareParvande sh)
        {
            return sadal.Update(sa, id, d, f,sh);
        }

        public string Delete(int id)
        {
            return sadal.Delete(id);
        }
    }
}
