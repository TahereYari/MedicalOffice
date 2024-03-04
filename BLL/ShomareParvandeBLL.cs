using System;
using System.Linq;
using BE;
using DAL;
using System.Data;
using System.Collections.Generic;

namespace BLL
{
    public class ShomareParvandeBLL
    {
        ShomareParvandeDAL shdal = new ShomareParvandeDAL();
        public string Create(ShomareParvande sh, Files f, Doctor d)
        {
            return shdal.Create(sh, f, d);
        }

        public ShomareParvande ReadSHD(string s, Doctor d)
        {
            return shdal.ReadSHD(s,d);

        }
        public List<string> ReadShomare(string d)
        {
            return shdal.ReadShomare(d);
        }
        public ShomareParvande ReadSH(int idf)
        {
            return shdal.ReadSH(idf);

        }

        public ShomareParvande ReadFilesNumber(string s)
        {
            return shdal.ReadFilesNumber(s);
        }

        public DataTable Search(string s)
        {
            return shdal.Search(s);
        }
    }
}
