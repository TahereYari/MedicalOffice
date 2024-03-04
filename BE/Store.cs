using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Store
    {
        public Store()
        {
            DeleteStatus = false;
        }
        public int id { get; set; }
        public string NameProduct { get; set; }
        public DateTime OutPutDate { get; set; }
        public string NameDeliver { get; set; }
        public bool DeleteStatus { get; set; }
        public User User { get; set; }
    }
}
