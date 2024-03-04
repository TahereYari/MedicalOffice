using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Servieces
    {

        public Servieces()
        {
            DeleteStatus = false;
        }
        public bool DeleteStatus { get; set; }
        public int id { get; set; }
        public DateTime Regdate { get; set; }
        public string NameOfService { get; set; }
        public string Code { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patiant> Patiant { get; set; } = new List<Patiant>();
        public User User { get; set; }
       // public Tariffe Tariffe { get; set; }
        //     public List<Insuarance> Insuarance { get; set; } = new List<Insuarance>();

    }
}
