using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        public User()
        {
            DeleteStatus = false;
            Active = true;
            Remember = false;
        }
        public int id { get; set; }
        public string Name { get; set; }
       // public string Family { get; set; }
        public string UserName { get; set; }
        public string CodeMelli { get; set; }
        public string Password { get; set; }
        public string Pic { get; set; }
        public bool DeleteStatus { get; set; }
        public bool Remember { get; set; }
        public DateTime RegDate { get; set; }
        public UserGroup UserGroup { get; set; }
        public bool Active { get; set; }
        public Doctor Doctor { get; set; }

        public List<Patiant> Patiants { get; set; } = new List<Patiant>();
    }
}
