using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;


namespace BLL
{
    public class TariffeBLL
    {
        TariffeDAL tdal = new TariffeDAL();
        public string Create(Tariffe t, Insuarance i,Servieces s)
        {
            return tdal.Create(t,i,s);
        }

        public DataTable Read()
        {
            return tdal.Read();
        }

        //public async Task<IPagedList<Tariffe>> getpagedListAsync(int pagenumber, int pagesize,Insuarance i)
        //{
        //    return await tdal.getpagedListAsync(pagenumber, pagesize , i);
        //}
        public DataTable Search(string s)
        {
            return tdal.Search(s);
        }
        public string Update(Tariffe t, int id, Insuarance i,Servieces s)
        {
            return tdal.Update(t, id,i, s);
        }
        public string Delete(int id)
        {
            return tdal.Delete(id);
        }

        public Tariffe Read(int id)
        {
            return tdal.Read(id);
        }

        public Tariffe ServiceTariffe(string Insuarance, string Serviece)
        {
            return tdal.ServiceTariffe(Insuarance, Serviece);
        }
        public Tariffe ServiceTariffeAzad(string Serviece)
        {
            return tdal.ServiceTariffeAzad(Serviece);
        }
        //public List<Tariffe> ServiceTariffe1(string Insuarance, string Serviece)
        //{
        //    return tdal.ServiceTariffe1(Insuarance, Serviece);
        //}

        //DataTable Read1(string Insuarance, string Serviece)
        //{
        //    return tdal.Read1(Insuarance, Serviece);

        //}

        public List<BE.Dto.TarrefeServiceVM> ReadView(string Insuarance, string Serviece)
        {
            return tdal.ReadView(Insuarance, Serviece);
        }

        public DataTable Read1(string Insuarance, string Serviece)
        {
            return tdal.Read1(Insuarance, Serviece);

        }

        public BE.Dto.TarrefeServiceVM ReadView1(string Insuarance, string Serviece)
        {

            return tdal.ReadView1(Insuarance, Serviece);
        }


        public DataTable ServiceAzzad(string Serviece)
        {
            return tdal.ServiceAzzad(Serviece);

        }
        public BE.Dto.TarrefeServiceVM ReadView2(string Serviece)
        {
            return tdal.ReadView2(Serviece);
        }
    }
}
