using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BE;
using BLL;
using FoxLearn.License;
using System.Runtime.InteropServices;

namespace Medical_Office
{
    public partial class RigAdmin : Form
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
        public RigAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }
        OpenFileDialog ofp = new OpenFileDialog();

        UserGroupBLL ugbll = new UserGroupBLL();
        UserBLL ubll = new UserBLL();
        msgBox m = new msgBox();
        DialogResult res = new DialogResult();
        string SavePic(string UserName)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\userpic\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string PicName = UserName + ".jpg";
            try
            {
                string picpath = ofp.FileName;
                File.Copy(picpath, path + PicName, true);
            }
            catch (Exception e)
            {
                MessageBox.Show("سیستم قادر به ذخیره عکس نمیباشد:\n" + e.Message);

            }
            return path + PicName;
        }
        private void RigAdmin_Load(object sender, EventArgs e)
        {
            try { txtname.Text = ComputerInfo.GetComputerId(); }
            catch { }
        }

  

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Image Pic;
            ofp.Filter = "JPG(*.JPG)|*.JPG";
            ofp.Title = "تصویر کاربر  را انتخاب کنید.";
            if (ofp.ShowDialog() == DialogResult.OK)
            {
                Pic = Image.FromFile(ofp.FileName);

            }
        }

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
        void CreateAdminGroup()
        {
            try
            {
                UserGroup ug = new UserGroup();
                ug.title = "مدیریت";
                ug.AccessUserGroups.Add(FillUserAccessRole("اطلاعات کاربران", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("اطلاعات پزشکان", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("گروه کاربری", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("تغییر رمز عبور", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("تنظیم تاریخ حضور پزشک", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("ثبت اطلاعات بیماران", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("ایجاد شماره پرونده", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("لیست بیماران", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("سوابق بیماران", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("پذیرش", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("جستجوی شماره پرونده", true, true, true, true));


                ug.AccessUserGroups.Add(FillUserAccessRole("نوبت دهی", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("گزارشات", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("نمودار", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("پشتیبانی", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("بازگردانی", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("بخش تعرفه", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("بخش بیمه", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("قبوض", true, true, true, true));
                ug.AccessUserGroups.Add(FillUserAccessRole("خدمات", true, true, true, true));
               
                ugbll.Create(ug);
            }
            catch { }
           

        }


        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                KeyManager km = new KeyManager(txtname.Text);
                string productKey = txtcode.Text;
                if (km.ValidKey(ref productKey))
                {
                    KeyValuesClass kv = new KeyValuesClass();
                    if (km.DisassembleKey(productKey, ref kv))
                    {
                        LicenseInfo lic = new LicenseInfo();
                        lic.ProductKey = productKey;
                        lic.FullName = "Personal accounting";
                        if (kv.Type == LicenseType.TRIAL)
                        {
                            lic.Day = kv.Expiration.Day;
                            lic.Month = kv.Expiration.Month;
                            lic.Year = kv.Expiration.Year;
                        }

                        km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                        m.myshowdialog("فعالسازی", "نرم افزار با موفقیت فعالسازی شد.", "", false, false);
                        groupBox1.Enabled = true;
                        //  MessageBox.Show("You have been successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //   SwitchPanel();
                    }
                }
                else
                    //  MessageBox.Show("Your product key is invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m.myshowdialog("اخطار", "کد وارد شده نا معتبر است.", "", false, false);
            }
            catch { }
           

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                CreateAdminGroup();
                u.Name = txtFamily.Text;
                u.UserName = txtusername.Text;

                if (txtPass.Text == txtRepPass.Text)
                {
                    u.Password = txtRepPass.Text;
                }
                else
                {
                    MessageBox.Show("تکرار کلمه عبور نادرست است.");

                }
                //if (u.Pic != null)
                //{
                //    m.myshowdialog("", "ubll.Create(u, ug)", "", false, false);
                //}

                //else
                //{
                //    m.myshowdialog("", "تصویر کاربر انتخاب نشده است.", "", false, false);
                //}

                u.Pic = null;
                u.RegDate = DateTime.Now.Date;
                m.myshowdialog("ثبت مدیریت", ubll.Create(u, ugbll.ReadN("مدیریت")), "", false, false);
                this.Visible = false;
                LogIn2 l2 = new LogIn2();
                l2.ShowDialog();
            }
            catch
            {
                m.myshowdialog("", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }
         
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

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    xuiButton3_Click(sender,e);
                    
                }
            }
            catch { }
        }

        private void txtFamily_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                   txtusername.Focus();

                }
            }
            catch { }
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
                    txtRepPass.Focus();

                }
            }
            catch { }
        }

        private void txtRepPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    xuiButton1_Click(sender, e);

                }
            }
            catch { }
        }
    }
    
    
}
