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

    public class InsuaranceBLL
    {
        DB db = new DB();
        InsuaranceDAL idal = new InsuaranceDAL();

        public string Create(Insuarance i)
        {
            return idal.Create(i);
        }

        public DataTable Read()
        {
            return idal.Read();
        }
        //public List<string> ReadName(int id)
        //{
        //    return idal.ReadName(id);
        //}
        public List<Insuarance> ReadName()
        {
            return idal.ReadName();
        }
        //public async Task<IPagedList<Insuarance>> getpagedListAsync(int pagenumber, int pagesize)
        //{
        //    return await idal.getpagedListAsync(pagenumber, pagesize);
        //}
        public int CountOfInsuance()
        {
            return idal.CountOfInsuance();
        }
        public Insuarance Read(int id)
        {
            return idal.Read(id);
        }
        public Insuarance ReadN(string s)
        {
            return idal.ReadN(s);
        }
        public DataTable Search(string s)
        {
            return idal.Search(s);
        }
        public string Update(Insuarance i, int id)
        {
            return idal.Update(i, id);
        }
        public string Delete(int id)
        {
            return idal.Delete(id);
        }

    }
}
