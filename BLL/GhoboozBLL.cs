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
   public class GhoboozBLL
    {
        GhooboozDAL ghdal = new GhooboozDAL();
     //   public string Create(Ghobooz gh, Patiant p, Doctor d, List<Servieces> S, Files f, List<Tariffe> t)
        public string Create(Ghobooz gh, Patiant p, Doctor d, Files f)
        {
            return ghdal.Create(gh, p,d , f);
        }

        public DataTable SearchPay(string date, string doctor)
        {
            return ghdal.SearchPay(date, doctor);
        }

        public DataTable SearchUnPay(string date, string doctor)
        {
            return ghdal.SearchUnPay(date, doctor);
        }

        public bool Ischecked(int id)
        {
            return ghdal.Ischecked(id);
        }

        public Ghobooz Read(int id)
        {
            return ghdal.Read(id);
        }

        public List<BE.Dto.TarrefeServiceVM> ReadView(int id)
        {
            return ghdal.ReadView(id);
        }
    }
}
