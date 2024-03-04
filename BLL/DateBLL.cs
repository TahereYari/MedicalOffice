using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   public class DateBLL
    {
        DateDAL dadal = new DateDAL();
        public void Create(Date da, string ti, Doctor d)
        {
             dadal.Create(da,ti,d);
        }

        public DataTable Search(string date, string doctor)
        {
            return dadal.Search(date, doctor);
        }

        public Date Read(int id)
        {
            return dadal.Read(id);
        }

        public string Delete(int id)
        {
            return dadal.Delete(id);
        }

        //public List<Date> NobatOfDoctor1(string date, string d)
        //{
        //    return dadal.NobatOfDoctor1(date, d);
        //}

        public List<BE.Dto.TimesForeNoabat> ReadView(string date, string doctor)
        {
            return dadal.ReadView(date,doctor);
        }

        public void Noabat(string da, string d, string ti)
        {
            dadal.Noabat(da, d, ti);
        }
        public void NoabatAfterDel(string da, string d, string ti)
        {
             dadal.NoabatAfterDel(da, d, ti);
        }

        //public DataTable TrueReserve(string date, string time, string doctor)
        //{
        //    return dadal.TrueReserve(date, time, doctor);
        //}

        public void reception(string da, Doctor d, string ti)
        {
            dadal.reception(da, d, ti);
        }
    }
}
