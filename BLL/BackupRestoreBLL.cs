using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
   public class BackupRestoreBLL
    {
        BackupRestoreDAL brdall = new BackupRestoreDAL();
        public void BackUp(string path)
        {
             brdall.BackUp(path);
        }

        public void Restore(string path)
        {
            brdall.Restore(path);
        }
    }
}
