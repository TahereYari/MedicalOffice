using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BE
{
   public  class Files
    {

        public Files()
        {
            DeleteStatus = false;
        }
        public bool DeleteStatus { get; set; }
        public int id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Sex { get; set; }
    //  public string FilesNumber { get; set; }
        public string CodeMelli { get; set; }
        public DateTime RegDate { get; set; }
        public List<ShomareParvande> ShomareParvande { get; set; } = new List<ShomareParvande>();
        public List<Patiant> Patiant { get; set; } = new List<Patiant>();
    }
}
