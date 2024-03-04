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
    public  class ServiceBLL
    {
        ServiceDAL sdal = new ServiceDAL();
        Servieces s = new Servieces();
        public string Create(Servieces s,Doctor d)
        {
            return sdal.Create(s,d);
        }

        public bool Read(Servieces s)
        {
            return sdal.Read(s);
        }

        public DataTable Read()
        {
            return sdal.Read();
        }
        public DataTable ReadForReport()
        {
            return sdal.ReadForReport();
        }
        public DataTable Search(string s)
        {
            return sdal.Search(s);
        }
        public Servieces Read(int id)
        {
            return sdal.Read(id);
        }
        public Servieces ReadName(string s)
        {
            return sdal.ReadName(s);
        }
       
        public List<Servieces> ReadALL()
        {
            return sdal.ReadALL();
        }
        //public Servieces ServiceOfDoctor(string s)
        //{
        //    return sdal.ServiceOfDoctor(s);
        //}
        public List<Servieces> ServiceOfDoctor1(int id)
        {
            return sdal.ServiceOfDoctor1(id);
        }
        //public List<Servieces> ServiceOfDoctor()
        //{
        //    return sdal.ServiceOfDoctor();
        //}
        public string Update(Servieces s, int id ,Doctor d)
        {
            return sdal.Update(s, id,d);
        }

        public string Delete(int id)
        {
            return sdal.Delete(id);
        }
    }
}
