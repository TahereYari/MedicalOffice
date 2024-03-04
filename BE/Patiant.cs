using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patiant
    {
        public Patiant()
        {
            DeleteStatuse = false;

        }
        public bool DeleteStatuse { get; set; }
        public int id { get; set; }
        public string RegDate { get; set; }
        public string VisitDate { get; set; }
        public string Hozor { get; set; }
      
        public double Price { get; set; }
      //  public DateTime VisitDate1 { get; set; }
        public Files Files { get; set; }
        public List<Servieces> Servieces { get; set; } = new List<Servieces>();
        public Doctor Doctor { get; set; }
     //   public List<Doctor> Doctor { get; set; } = new List<Doctor>();
        public User User { get; set; }
        public Insuarance Insuarance { get; set; }
    }
}
