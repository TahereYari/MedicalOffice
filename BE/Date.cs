using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Date
    {
        public Date()
        {
            DeleteStatus = false;
            Reserve = false;
        }
        public bool DeleteStatus { get; set; }
        public int id { get; set; }

      public string date1 { get; set; }
    public string Times1 { get; set; }
      //  public  List<Time> times { get; set; } = new List<Time>();
        public Doctor doctor { get; set; }
       public bool Reserve { get; set; }
    }
}
