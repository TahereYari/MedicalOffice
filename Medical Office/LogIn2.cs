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
    public partial class LogIn2 : Form
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
        public LogIn2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }

        msgBox m = new msgBox();
        DialogResult res = new DialogResult();
        UserBLL ubll = new UserBLL();
        User u = new User();
        Remember r = new Remember();
        RememberBLL rbll = new RememberBLL();
       

        private void LogIn2_Load(object sender, EventArgs e)
        {
            try
            {
                AutoCompleteStringCollection usernames = new AutoCompleteStringCollection();
                foreach (var item in rbll.Readusername())
                {
                    usernames.Add(item);
                }
                txtusername.AutoCompleteCustomSource = usernames;
            }
            catch { }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                res = m.myshowdialog("خروج از برنامه", "آیا قصد خروج از برنامه رادارید؟", "", true, false);
                if (res == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch { }
         
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

            //string p = ubll.ReadPassword1(txtusername.Text);
            //txtPass.Text = ubll.(p);
        }


        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                u = ubll.Login(txtusername.Text, txtPass.Text);
               
                    if (u != null)
                    {
                    if (u.Active == true)
                    {
                        //MainForm w = (MainForm)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
                        if (checkBoxX1.Checked)
                        {
                            ubll.remember(txtusername.Text);

                        }

                        MainWindow w = new MainWindow();
                        w.Show();
                        w.loggedinuser = u;
                        w.RefreshPage();
                        this.Close();

                    }
                    else
                    {
                        m.myshowdialog("", "شما اجازه ورود ندارید.", "", false, false);
                    }

                }
                    else
                    {
                        m.myshowdialog("", "رمز عبور یا نام کاربر اشتباه است.", "", false, false);
                    }


                    txtusername.Text = "";
                    txtPass.Text = "";
                txtusername.Focus();
               
               
            }
            catch
            {
                m.myshowdialog("اخطار", "لطفا در ورود اطلاعات دفت نمایید.", "", false, false);
            }
           
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
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
                    xuiButton3_Click(sender, e);
                }
            }
            catch { }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                res = m.myshowdialog("بستن", "میخواهید فرم را ببندید؟", "", true, false);
                if (res == DialogResult.Yes)
                {
                    LogIn2 l2 = new LogIn2();
                    l2.Close();
                    MainWindow w = new MainWindow();
                    w.Show();
                    w.loggedinuser = u;
                    w.RefreshPage();
                }
            }
            catch { }
        }
    }
}
