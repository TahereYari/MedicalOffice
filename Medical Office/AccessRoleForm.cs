using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Medical_Office
{
    public partial class AccessRoleForm : Form
    {

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // width of ellipse
         int nHeightEllipse // height of ellipse
     );
        public AccessRoleForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }

        #region Definations
        AccessGroup ac = new AccessGroup();
        UserGroup ug = new UserGroup();
        UserGroupBLL ugbll = new UserGroupBLL();
        msgBox m = new msgBox();

        #endregion

        #region checkBox

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (koli1.Checked)
            {
                k1.Checked = true;
                d1.Checked = true;
                g1.Checked = true;
                ch1.Checked = true;
                date1.Checked = true;
                p1.Checked = true;
                sh1.Checked = true;
                l1.Checked = true;
                sa1.Checked = true;
                r1.Checked = true;
                se1.Checked = true;

                n1.Checked = true;
                re1.Checked = true;
                chart1.Checked = true;
                b1.Checked = true;
                restor1.Checked = true;
                tarefe1.Checked = true;
                insur1.Checked = true;
                ghabz1.Checked = true;
                service1.Checked = true;
               

            }
            else
            {
                k1.Checked = false;
                d1.Checked = false;
                g1.Checked = false;
                ch1.Checked = false;
                date1.Checked = false;
                p1.Checked = false;
                sh1.Checked = false;
                l1.Checked = false;
                sa1.Checked = false;
                r1.Checked = false;
                se1.Checked = false;

                n1.Checked = false;
                re1.Checked = false;
                chart1.Checked = false;
                b1.Checked = false;
                restor1.Checked = false;
                tarefe1.Checked = false;
                insur1.Checked = false;
                ghabz1.Checked = false;
                service1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (koli2.Checked)
            {
                k2.Checked = true;
                d2.Checked = true;
                g2.Checked = true;
                ch2.Checked = true;
                date2.Checked = true;
                p2.Checked = true;
                sh2.Checked = true;
                l2.Checked = true;
                sa2.Checked = true;
                r2.Checked = true;
                se2.Checked = true;

                n2.Checked = true;
                re2.Checked = true;
                chart2.Checked = true;
                b2.Checked = true;
                restor2.Checked = true;
                tarefe2.Checked = true;
                insur2.Checked = true;
                ghabz2.Checked = true;
                service2.Checked = true;

            }
            else
            {
                k2.Checked = false;
                d2.Checked = false;
                g2.Checked = false;
                ch2.Checked = false;
                date2.Checked = false;
                p2.Checked = false;
                sh2.Checked = false;
                l2.Checked = false;
                sa2.Checked = false;
                r2.Checked = false;
                se2.Checked = false;


                n2.Checked = false;
                re2.Checked = false;
                chart2.Checked = false;
                b2.Checked = false;
                restor2.Checked = false;
                tarefe2.Checked = false;
                insur2.Checked = false;
                ghabz2.Checked = false;
                service2.Checked = false;

            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (koli3.Checked)
            {
                k3.Checked = true;
                d3.Checked = true;
                g3.Checked = true;
                ch3.Checked = true;
                date3.Checked = true;
                p3.Checked = true;
                sh3.Checked = true;
                l3.Checked = true;
                sa3.Checked = true;
                r3.Checked = true;
                se3.Checked = true;

                n3.Checked = true;
                re3.Checked = true;
                chart3.Checked = true;
                b3.Checked = true;
                restor3.Checked = true;
                tarefe3.Checked = true;
                insur3.Checked = true;
                ghabz3.Checked = true;
                service3.Checked = true;

            }
            else
            {
                k3.Checked = false;
                d3.Checked = false;
                g3.Checked = false;
                ch3.Checked = false;
                date3.Checked = false;
                p3.Checked = false;
                sh3.Checked = false;
                l3.Checked = false;
                sa3.Checked = false;
                r3.Checked = false;
                se3.Checked = false;

                n3.Checked = false;
                re3.Checked = false;
                chart3.Checked = false;
                b3.Checked = false;
                restor3.Checked = false;
                tarefe3.Checked = false;
                insur3.Checked = false;
                ghabz3.Checked = false;
                service3.Checked = false;

            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (koli4.Checked)
            {
                k4.Checked = true;
                d4.Checked = true;
                g4.Checked = true;
                ch4.Checked = true;
                date4.Checked = true;
                p4.Checked = true;
                sh4.Checked = true;
                l4.Checked = true;
                sa4.Checked = true;
                r4.Checked = true;
                se4.Checked = true;

                n4.Checked = true;
                re4.Checked = true;
                chart4.Checked = true;
                b4.Checked = true;
                restor4.Checked = true;
                tarefe4.Checked = true;
                insur4.Checked = true;
                ghabz4.Checked = true;
                service4.Checked = true;


            }
            else
            {
                k4.Checked = false;
                d4.Checked = false;
                g4.Checked = false;
                ch4.Checked = false;
                date4.Checked = false;
                p4.Checked = false;
                sh4.Checked = false;
                l4.Checked = false;
                sa4.Checked = false;
                r4.Checked = false;
                se4.Checked = false;

                n4.Checked = false;
                re4.Checked = false;
                chart4.Checked = false;
                b4.Checked = false;
                restor4.Checked = false;
                tarefe4.Checked = false;
                insur4.Checked = false;
                ghabz4.Checked = false;
                service4.Checked = false;

            }
        }

        #endregion


        #region Methods
        AccessGroup FillUserAccessRole(string section, bool CanEnter, bool CanCreate, bool CanUpdate, bool CanDelete)
        {
            AccessGroup ar = new AccessGroup();
            ar.Section = section;
            ar.CanEnter = CanEnter;
            ar.CanCreate = CanCreate;
            ar.CanUpdate = CanUpdate;
            ar.CanDelete = CanDelete;
            return ar;
        }
        #endregion
  

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "گروه کاربری", 2))
                {
                    UserGroup ug = new UserGroup();
                    ug.title = txtGroup.Text;

                    ug.AccessUserGroups.Add(FillUserAccessRole(doctor.Text, d1.Checked, d2.Checked, d3.Checked, d4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(list.Text, l1.Checked, l2.Checked, l3.Checked, l4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(savabegh.Text, sa1.Checked, sa2.Checked, sa3.Checked, sa4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(reception.Text, r1.Checked, r2.Checked, r3.Checked, r4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(search.Text, se1.Checked, se2.Checked, se3.Checked, se4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(karbaran.Text, k1.Checked, k2.Checked, k3.Checked, k4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(patiant.Text, p1.Checked, p2.Checked, p3.Checked, p4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(parvande.Text, sh1.Checked, sh2.Checked, sh3.Checked, sh4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(tarefe.Text, tarefe1.Checked, tarefe2.Checked, tarefe3.Checked, tarefe4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(insur.Text, insur1.Checked, insur2.Checked, insur3.Checked, insur4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(service.Text, service1.Checked, service2.Checked, service3.Checked, service4.Checked));

                    ug.AccessUserGroups.Add(FillUserAccessRole(usergroup.Text, g1.Checked, g2.Checked, g3.Checked, g4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(changr.Text, ch1.Checked, ch2.Checked, ch3.Checked, ch4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(date.Text, date1.Checked, date2.Checked, date3.Checked, date4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(nobat.Text, n1.Checked, n2.Checked, n3.Checked, n4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(report.Text, r1.Checked, r2.Checked, r3.Checked, r4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(chart.Text, chart1.Checked, chart2.Checked, chart3.Checked, chart4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(backup.Text, b1.Checked, b2.Checked, b3.Checked, b4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(restor.Text, restor1.Checked, restor2.Checked, restor3.Checked, restor4.Checked));
                    ug.AccessUserGroups.Add(FillUserAccessRole(ghabz.Text, ghabz1.Checked, ghabz2.Checked, ghabz3.Checked, ghabz4.Checked));

                    m.myshowdialog("ثبت گروه کاربری", ugbll.Create(ug), "", false, false);

                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
                foreach(var item in Controls)
                {
                    if(item.GetType().ToString()=="System.Windows.Forms.CheckBox")
                    {
                        (item as CheckBox).Checked = false;
                    }
                }
                txtGroup.Text = "";

                
            }
            catch
            {
                m.myshowdialog("", "مشکلی به وجود آمده است لطفا دوباره تلاش کنید.", "", false, false);
            }
     
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
