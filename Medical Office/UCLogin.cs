using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BE;
using BLL;

namespace Medical_Office
{
    public partial class UCLogin : UserControl
    {
        public FormBorderStyle FormBorderStyle { get; private set; }


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
        public UCLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }

        UserBLL ubll = new UserBLL();
        User u = new User();
        Remember r = new Remember();
        RememberBLL rbll = new RememberBLL();
        msgBox m = new msgBox();
        private void UCLogin_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection usernames = new AutoCompleteStringCollection();
            foreach (var item in rbll.Readusername())
            {
                usernames.Add(item);
            }
            txtusername.AutoCompleteCustomSource = usernames;

            //AutoCompleteStringCollection passwords = new AutoCompleteStringCollection();
            //foreach (var item in rbll.ReadPassword())
            //{
            //    passwords.Add(item);
            //}
            //txtPass.AutoCompleteCustomSource = passwords;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            u = ubll.Login(txtusername.Text, txtPass.Text);

            if (u != null)
            {
                //MainForm w = (MainForm)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
                if(checkBoxX1.Checked)
                {
                    ubll.remember(txtusername.Text);

                }
            
                MainWindow w = new MainWindow();
                w.Show();
                w.loggedinuser = u;
                w.RefreshPage();


                ((LoginForm)System.Windows.Forms.Application.OpenForms["LoginForm"]).Close();

            }
            else
            {
                m.myshowdialog("", "رمز عبور یا نام کاربر اشتباه است.", "",false,false);
            }


            txtusername.Text = "";
            txtPass.Text = "";
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
           
                string p= ubll.ReadPassword1(txtusername.Text);
           txtPass.Text = ubll.Decode(p);
          
           
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
