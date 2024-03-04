using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public  class PationtBLL
    {
        DB db = new DB();
        PationtDAL pdal = new PationtDAL();

       public string Create(Patiant p, Insuarance i,Doctor d, List<Servieces> S, Files f,User u)
        {
          return pdal.Create(p,i,d, S, f,u);
      
        }
        public bool Read(Patiant p, Doctor d, Files f)
        {
            return pdal.Read(p, d, f);
        }

        //public bool Read(Files f, Doctor d)
        //{
        //    return pdal.Read(f, d);
        //}

        public DataTable Read(string date)
        {
            return pdal.Read(date);
        }

        public DataTable ReadBetween(string date1, string date2)
        {
            return pdal.ReadBetween(date1, date2);
        }
        public DataTable RedBetweenByName(string date1, string date2, string doctor)
        {
            return pdal.RedBetweenByName(date1, date2, doctor);
        }
        public DataTable Search(string date, string doctor)
        {
            return pdal.Search(date,doctor);
        }
        public DataTable PatiantLastWeek(string doctor)
        {
            return pdal.PatiantLastWeek(doctor);
        }
        public DataTable ALLListOfPatiantLastWeek()
        {
            return pdal.ALLListOfPatiantLastWeek();
        }
        //public DataTable Search( string date)
        //{
        //    return pdal.Search(date);
        //}
        public Patiant Read(int id)
        {
            return pdal.Read(id);
        }
        //public Patiant ReadName(string s)
        //{
        //    return pdal.ReadName(s);
        //}
        public List<Patiant> ReadALL(string d)
        {
              return pdal.ReadALL(d);
        }
        public int count()
        {
            return pdal.count(); ;
        }
        public List<Patiant> DoctorOfPatiant()
        {
            return   pdal.DoctorOfPatiant();
        }

        //public string Update(Files f, int id, Doctor d)
        //{
        //}
        public bool AcceptPation(string date1, string date2)
        {

            return pdal.AcceptPation(date1, date2);
        }
        public List<Patiant> AcceptPationLastWeek(string date1, string date2)
        {

            return pdal.AcceptPationLastWeek(date1, date2);

        }
        public string Delete(int id)
        {
            return pdal.Delete(id);
        }
        //public DataTable Read()
        //{
        //    return pdal.Read();


        //}
        public DataTable ListPatiant(string date1, string date2)
        {
            return pdal.ListPatiant(date1,date2);
        }

        public DataTable ListPatiantByDoctor(string date1, string date2, string doctor)
        {
            return pdal.ListPatiantByDoctor(date1, date2, doctor);
        }
        public List<Patiant> ReadPatiants()
        {
            return pdal.ReadPatiants();
        }
    }
}
