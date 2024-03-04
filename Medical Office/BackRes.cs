using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace Medical_Office
{
    public partial class BackRes : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // width of ellipse
      int nHeightEllipse // height of ellipse
  );
        public BackRes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
          //  this.BackColor = Color.FromArgb(82, 121, 111);
           
        }
        BackupRestoreBLL brbll = new BackupRestoreBLL();
        private void BackRes_Load(object sender, EventArgs e)
        {
           


        }
        Timer t1 = new Timer();
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        msgBox m = new msgBox();
        //  brbll.BackUp(fbd.SelectedPath);
        public bool BackUp(string path)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=MedicalDB1; Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"backup database MedicalDB1 to disk ='" + path + @"\BackupDB.bak' ";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                m.myshowdialog("", "پشتیبان گیری با موفقیت انجام شد.", "", false, false);
                return true;
            }
            catch
            {

                m.myshowdialog("", "!لطفا فایل بشتیبان را در درایوی غیر از درایو ویندوز ذخیره کنید", "", false, true);
                return false;
            }


        }

        public void Restore(string path)
        {
            try
            {
                DialogResult res = new DialogResult();
                
              res=  m.myshowdialog("اخطار", "!!!ممکن است تمام اطلاعات حال حاظر بانک اطلاعاتی شما تغییر کند \n !اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "", true, false);
                if (res==DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=master; Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = @"restore database MedicalDB1 from disk ='" + path + "' with replace";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    m.myshowdialog("", "اطلاعات با موفقیت بازیابی شد.", "", false, false);
                }


            }
            catch
            {
                m.myshowdialog("", "خطایی پیش آمده است لطفا دوباره تلاش کنید.", "", false, true);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            circularProgress1.Start();
            if(linkLabel1.Text == "در صورتی که میخواهید عملیات پشتیبان گیری کامل شود کلیک کنید")
            {
                fbd.ShowDialog();
                if (BackUp(fbd.SelectedPath))
                {
                    circularProgress1.Stop();
                }
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
               Restore(ofd.FileName);
              
            }

            circularProgress1.Stop();






        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
     


        private void timer1_Tick(object sender, EventArgs e)
        {
         
   


        }
    }
}
