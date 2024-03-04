using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public  class ShomareParvande
    {
        //public ShomareParvande()
        //{
        //    DeleteStatus = false;
        //}
        public bool DeleteStatus { get; set; }
        public int id { get; set; }
        public string FilesNumber { get; set; }
      
        public DateTime RegDate { get; set; }
        public Files Filee { get; set; }
        public Doctor doctor { get; set; }
    }
}
