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
    public partial class ChandePassword : Form
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
        public ChandePassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
          //  this.BackColor = Color.FromArgb(169, 214, 229);
        }

        private void ChandePassword_Load(object sender, EventArgs e)
        {

        }
        User u = new User();
        UserBLL ubll = new UserBLL();
        msgBox m = new msgBox();
        RememberBLL rbll = new RememberBLL();
        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "تغییر رمز عبور", 2))
                {
                    u = ubll.Login(txtUserName.Text, txtlast.Text);
                    if (u != null)
                    {


                        ubll.Changeuser(txtUserName.Text, txtrepPass.Text);

                        label1.Text = "";
                        label1.Text = "رمز عبور با موفقیت تغییر یافت";
                        label1.ForeColor = Color.FromArgb(0, 0, 0);

                    }
                    else
                    {
                        label1.Text = "رمز عبور یا نام کاربری اشتباه است";
                    }

                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

                

                txtlast.Text = "";
                txtPass.Text = "";
                txtrepPass.Text = "";
                txtUserName.Text = "";

                txtlast.WatermarkText = "رمز عبور قبلی";
                txtPass.WatermarkText = "رمز عبور جدید";
                txtUserName.WatermarkText = "نام کاربری";
                txtrepPass.WatermarkText = " تکرار رمز عبور جدید";
                xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
            }
            catch { }
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtlast.Focus();
                }
            }
            catch { }
          
        }

        private void txtlast_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPass.Focus();
                }
            }
            catch { }
           
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtrepPass.Focus();
                }
            }
            catch { }

            
        }

        private void txtrepPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    xuiButton3.Focus();
                    xuiButton3.BackgroundColor = Color.FromArgb(173, 182, 196);
                }
            }
            catch { }
           
        }

        private void xuiButton3_KeyDown(object sender, KeyEventArgs e)
        {
            try { xuiButton3_Click(sender, e); }
            catch { }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
