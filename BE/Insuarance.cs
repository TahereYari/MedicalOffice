using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Insuarance
    {

        public Insuarance()
        {
            DeleteStatuse = false;
        }
        public bool DeleteStatuse { get; set; }
        public int id { get; set; }
        public string NameOfInsutance { get; set; }
        public string Code { get; set; }
        public DateTime RegDate { get; set; }

      //  public Doctor Doctor { get; set; }
        public User User { get; set; }
     //  public Tariffe Tariffe { get; set; }
      //  public List<Servieces> Servieces { get; set; } = new List<Servieces>();


    }
}
