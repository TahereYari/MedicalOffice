using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
     public  class Tariffe
    {
        public Tariffe()
        {
            DeleteStatus = false;
        }
        public bool DeleteStatus { get; set; }
        public int id { get; set; }
        public string ServieceType { get; set; }
        public double PortionInsuarance { get; set; }
        public double PortionOrganizatin { get; set; }
        public double OtherCost { get; set; }
        public DateTime Regdate { get; set; }
        public Servieces Serviece { get; set; }
        public Insuarance Insuarance { get; set; }
    }
}
