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
    public partial class LoginForm : Form
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
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.BackColor = Color.FromArgb(169, 214, 229);
            //panel1.Controls.Add(ra);
            //panel1.Controls["RegisterAdmin"].Location = new Point(101, 85);
            //panel1.Controls.Add(ucl);
            //panel1.Controls["UCLogin"].Location = new Point(101, 85);
        }


        #region Definations
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        List<string> usernames = new List<string>();
        RegisterAdmin ra = new RegisterAdmin();
        UCLogin ucl = new UCLogin();
        UserBLL ubll = new UserBLL();
        bool IsRegister;

        #endregion
        private void LoginForm_Load(object sender, EventArgs e)
        {
            t1.Enabled = true;
            t1.Interval = 15;
            t1.Tick += timer1_Tick;
            t1.Start();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void LoadLoginForm()
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarX1.Value >= 100)
            {
                t1.Stop();
                progressBarX1.Visible = false;
             

                t2.Enabled = true;
                t2.Interval = 1;
                t2.Tick += timer2_Tick;
                t2.Start();
            }
            else if (progressBarX1.Value == 45)
            {
              
                IsRegister = ubll.IsRegisterd();
                progressBarX1.Value++;
            }
            else
            {
                progressBarX1.Value++;
                labelWelcom.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsRegister)
            {

                panel1.Controls.Add(ucl);
                panel1.Controls["UCLogin"].Location = new Point(89, 56);
                t2.Stop();
            }
            else
            {
                panel1.Controls.Add(ra);

                panel1.Controls["RegisterAdmin"].Location = new Point(89, 56);
                t2.Stop();

            }
        }
    }
}
