using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Savabegh
    {
        public Savabegh()
        {
            DeleteStatus = false;
        }
        public bool DeleteStatus { get; set; }
        public string visiDate { get; set; }
        public int id { get; set; }
        public DateTime RegDate { get; set; }
        public string medicine { get; set; }
        public string Biography { get; set; }
        public string TypeOfMedical { get; set; }
        public Files Files { get; set; }
        public Doctor Doctor { get; set; }
        public ShomareParvande ShomareParvandes { get; set; }
    }
}
