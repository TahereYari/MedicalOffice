using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Noabat
    {
        public Noabat()
        {
            DeleteStatus = false;

        }
        public bool DeleteStatus { get; set; }
        public int id { get; set; }
        public string Date1 { get; set; }
        public string Time1 { get; set; }
        public string codeMelii { get; set; }
        public string doctor { get; set; }
    }
}
