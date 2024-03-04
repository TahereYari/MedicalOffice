using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public  class Ghobooz
    {
        public int id { get; set; }
        public Files Files { get; set; }
        public Doctor Doctor { get; set; }
        public Patiant Patiant { get; set; }
        public bool Ischeck { get; set; }
        //public List<Tariffe> Tariffe { get; set; } = new List<Tariffe>();
        //public List<Servieces> Servieces { get; set; } = new List<Servieces>();

    }
}
