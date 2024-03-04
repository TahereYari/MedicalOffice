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
    public class FileBLL
    {
        FilesDAL fdal = new FilesDAL();
        public string Create(Files f)
        {
            return fdal.Create(f);
        }
        public DataTable Read()
        {
            return fdal.Read();
        }

        public DataTable Search(string s)
        {

            return fdal.Search(s);
        }
        public Files Read(int id)
        {
            return fdal.Read(id);
        }
        public Files ReadName(string s)
        {
            return fdal.ReadName(s);
        }
        public Files ReadMelli(string s)
        {
            return fdal.ReadMelli(s);

        }
        public List<string> ReadCodeMelii()
        {
            return fdal.ReadCodeMelii();
        }
        public List<Files> ReadALL()
        {
            return fdal.ReadALL();
        }
        public List<Files> FilesOfDoctor()
        {
            return fdal.FilesOfDoctor();
        }
        //public Files ReadMD(string s, Doctor d)
        //{
        //    return fdal.ReadMD(s,d);

        //}
        public string Update(Files f, int id)
        {
            return fdal.Update(f, id);
        }

        public string Delete(int id)
        {
            return fdal.Delete(id);
        }

    }
}
