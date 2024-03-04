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
using FoxLearn.License;
using BE;
using BLL;
using System.IO;
using System.Globalization;

namespace Medical_Office
{
    public partial class RegisterAdmin : UserControl
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
        public RegisterAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.BackColor = Color.FromArgb(169, 214, 229);
        }
        OpenFileDialog ofp = new OpenFileDialog();

        UserGroupBLL ugbll = new UserGroupBLL();
        UserBLL ubll = new UserBLL();
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
             MessageBox.Show( "سیستم قادر به ذخیره عکس نمیباشد:\n" + e.Message);

            }
            return path + PicName;
        }
        private void RegisterAdmin_Load(object sender, EventArgs e)
        {
            txtname.Text = ComputerInfo.GetComputerId();
        }

        private void buttonX1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("نرم افزار با موفقیت فعالسازی شد.");
                    //  MessageBox.Show("You have been successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 //   SwitchPanel();
                }
            }
            else
                //  MessageBox.Show("Your product key is invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               MessageBox.Show("کد وارد شده نا معتبر است.");
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
            UserGroup ug = new UserGroup();
            ug.title = "مدیریت";
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش پزشکان", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش پرونده", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش نوبت دهی", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش بیمه", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش خدمات", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش کاربران", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("پنل پبامکی", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش گزارشات", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش تعرفه", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش بیمه", true, true, true, true));
            ug.AccessUserGroups.Add(FillUserAccessRole("بخش انبار", true, true, true, true));
            ugbll.Create(ug);

        }

        private void buttonX2_Click(object sender, EventArgs e)
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

            u.Pic = SavePic(txtusername.Text);
            u.RegDate = DateTime.Now.Date;
           MessageBox.Show(ubll.Create(u, ugbll.ReadN("مدیریت")));
            this.Visible = false;
            ((LoginForm)Application.OpenForms["LoginForm"]).LoadLoginForm();
        }
    }
}
