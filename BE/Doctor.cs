using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  
    public class Doctor
    {
        public Doctor()
        {
            DeleteStatus = false;
        }

        public int id { get; set; }
        public string DoctorNumber { get; set; }
        public string Name { get; set; }
       // public string Family { get; set; }
        public string Phone { get; set; }
        public string CodeMelli { get; set; }
        public DateTime RegDate { get; set; }
        public string birhthday { get; set; }
        public string sex { get; set; }
        public string takhasos { get; set; }
        public string Address { get; set; }
        public string Pic { get; set; }
        public bool DeleteStatus { get; set; }
        public List<Servieces> Servieces { get; set; } = new List<Servieces>();
        public List<Patiant> Patiants { get; set; } = new List<Patiant>();
        public List<Date> Dates { get; set; } = new List<Date>();
        public List<ShomareParvande> ShomareParvande { get; set; } = new List<ShomareParvande>();
    }
}
