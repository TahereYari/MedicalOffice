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
    public class ProductBLL
    {
        Product p = new Product();
        ProductDAL pdal = new ProductDAL();

        public string Create(Product p, Doctor d)
        {
            return pdal.Create(p,d);

        }

        public bool Read(Product p)
        {
            return pdal.Read(p);
        }

     
        //public DataTable Search(string s)
        //{
        //    return pdal.Search(s);
        //}
        public Product Read(int id)
        {
            return pdal.Read(id);
        }

        public string Update(Product p, int id, Doctor d)
        {
            return pdal.Update(p,id,d);
        }
        public string Delete(int id)
        {
            return pdal.Delete(id);
        }
    }
}
