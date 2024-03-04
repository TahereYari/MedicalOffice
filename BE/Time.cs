using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Time
    {
        public Time()
        {
            DeleteStatus = false;
           
        }
        public bool DeleteStatus { get; set; }
        public int id { get; set; }
        public string time1 { get; set; }

      //  public  List<Date> dates { get; set; } = new List<Date>();
    }
}
