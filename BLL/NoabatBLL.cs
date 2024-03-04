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
   public class NoabatBLL
    {
        NoabatDAL ndal = new NoabatDAL();
        public string Create(Noabat N)
        {
            return ndal.Create(N);
        }

        public DataTable Search(string date, string doctor)
        {
            return ndal.Search(date, doctor);
        }

    

        public DataTable ReadNobatReserve(string date, string doctor, string codeMelii)
        {
            return ndal.ReadNobatReserve(date,doctor,codeMelii);
        }

        public Noabat ReadNobatReserve2(string date, string doctor, string codeMelii)
        {
            return ndal.ReadNobatReserve2(date, doctor, codeMelii);
        }
    }
}
