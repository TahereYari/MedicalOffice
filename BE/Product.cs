using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Product
    {

        public Product()
        {
            DeleteStatus = false;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool DeleteStatus { get; set; }
        public DateTime OutPutDate { get; set; }
        public string NameDeliver { get; set; }
        public string NameGirander { get; set; }
        public Doctor Doctor { get; set; } 
        public User User { get; set; }
    }
}
