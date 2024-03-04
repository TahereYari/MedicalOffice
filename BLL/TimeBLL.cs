using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;

namespace BLL
{
   public class TimeBLL
    {
        TimeDAL tidal = new TimeDAL();
        public void Create(Time ti)
        {
           tidal.Create(ti);
        }

        public List<Time> ReadTime()
        {
            return tidal.ReadTime();
        }

        public Time Readt(string s)
        {
            return tidal.Readt(s);
        }

        public DataTable Read()
        {
            return tidal.Read();
        }

        public Time Read(int id)
        {
            return tidal.Read(id);
        }

        public string Delete(int id)
        {
            return tidal.Delete(id);
        }
        public List< Time> ReadT(string ti)
        {
            return tidal.ReadT(ti);
        }
    }
}
