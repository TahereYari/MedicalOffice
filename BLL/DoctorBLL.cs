using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using DAL;
namespace BLL
{
   public class DoctorBLL
    {
        DB db = new DB();
        DoctorDAL ddal = new DoctorDAL();
        public string create(Doctor d)
        {
            return ddal.create(d);
        }

        public int Getid(string s)
        {
            return ddal.Getid(s);
        }
        public List<Doctor> AcceptPation(int id)
        {
            return ddal.AcceptPation(id);
        }
        public List<Doctor> AcceptPationALLdoctor()
        {
            return ddal.AcceptPationALLdoctor();
        }
        public DataTable Read()
        {
            return ddal.Read();
        }
        public DataTable Search(string s)
        {
            return ddal.Search(s);
        }
        public Doctor Read(int id)
        {
            return ddal.Read(id);
        }
        public List<Doctor> ReadName()
        {
            return ddal.ReadName();
        }
        public Doctor ReadN(string s)
        {
            return ddal.ReadN(s);
        }
        public string Update(Doctor d, int id)
        {
            return ddal.Update(d,id);
        }
        public string Delete(int id)
        {
            return ddal.Delete(id);
        }


    }
}
