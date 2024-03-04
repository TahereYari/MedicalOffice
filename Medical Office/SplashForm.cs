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

namespace Medical_Office
{
    public partial class SplashForm : Form
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
        public SplashForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
          //  this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region Definations
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        List<string> usernames = new List<string>();
        LogIn2 l2 = new LogIn2();
        UserBLL ubll = new UserBLL();
        RigAdmin r = new RigAdmin();
        bool IsRegister;

        #endregion
        private void SplashForm_Load(object sender, EventArgs e)
        {
            t1.Enabled = true;
            t1.Interval = 15;
            t1.Tick += timer1_Tick;
            t1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
            if (circularProgress1.Value >= 100)
            {
                t1.Stop();
               // circularProgress1.Visible = false;


                t2.Enabled = true;
                t2.Interval = 1;
                t2.Tick += timer2_Tick;
                t2.Start();
            }
            else if (circularProgress1.Value == 45)
            {

                IsRegister = ubll.IsRegisterd();
                circularProgress1.Value++;
            }
            else
            {
                circularProgress1.Value++;
               // labelWelcom.Visible = false;
            }
        
    }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsRegister)
            {
               
                this.Close();

                l2.Show();
                t2.Stop();
            }
            else
            {
                this.Close();
                r.Show();
               
           
             
                t2.Stop();

            }
        }

        private void labelWelcom_Click(object sender, EventArgs e)
        {

        }
    }
}
