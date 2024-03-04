using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Effects;
using System.Windows.Forms;
using BE;
using BLL;
using System.IO;
using System;

using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace Medical_Office
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public BE.User  loggedinuser = new BE.User();
        msgBox m = new msgBox();
        UserBLL ubll = new UserBLL();
        void openform(Form f)
        {
            try
            {
                Window w = (Window)this.FindName("Main") as Window;
                BlurEffect blur = new BlurEffect();
                blur.Radius = 15;
                this.Effect = blur;

                f.ShowDialog();

                blur.Radius = 0;
                this.Effect = blur;
            }
            catch
            {

            }
          

        }
        private void MainWindow_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.N)
                {
                    InsuranceForm insf = new InsuranceForm();
                    openform(insf);
                }
            }
            catch
            {

            }
           
        }

        public void RefreshPage()
        {
            try
            {
                usernametxt.Text = loggedinuser.UserName;
            }
            catch
            {

            }
           
  
        }
        private void TabItem_MouseLeave(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
         
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
           
           
        }

        private void TextBlock_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
          
        }

        private void TextBlock_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                msgBox m = new msgBox();
                System.Windows.Forms.DialogResult res1 = new System.Windows.Forms.DialogResult();
                res1 = m.myshowdialog("خروج از برنامه", "آیا قصد خروج از برنامه رادارید؟", "", true, false);
                if (res1 == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Windows.Application.Current.Shutdown();
                }
            }
            catch { }
        }

        private void TextBlock_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void TextBlock_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void TextBlock_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void WrapPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "خدمات", 1))
                {
                    ServiecesForm sf = new ServiecesForm();
                    openform(sf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }

          
          
        }

        private void WrapPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "ثبت اطلاعات بیماران", 1))
                {
                    FileForm ff = new FileForm();
                    openform(ff);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

            }
            catch
            {

            }

           
          
        }

        private void WrapPanel_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
     

            if (ubll.Access(loggedinuser, "ایجاد شماره پرونده", 1))
            {
                ShomareParvandeForm shf = new ShomareParvandeForm();
                openform(shf);
            }

            else
            {

                m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
            }
        }

        private void WrapPanel_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
         try
            {
                if (ubll.Access(loggedinuser, "لیست بیماران", 1))
                {
                    Report r = new Report();
                    openform(r);
                }

            else
            {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
                {

            }

           
          
        }

        private void WrapPanel_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "اطلاعات کاربران", 1))
                {
                    UserForm uf = new UserForm();
                    openform(uf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }
        
     

        }

        private void WrapPanel_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
          
            try
            {
                if (ubll.Access(loggedinuser, "اطلاعات پزشکان", 1))
                {
                    DoctorForm df = new DoctorForm();
                    openform(df);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }

          

        }

        private void WrapPanel_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            try
            {

                if (ubll.Access(loggedinuser, "گروه کاربری", 1))
                {
                    AccessRoleForm af = new AccessRoleForm();
                    openform(af);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }



        }

        private void WrapPanel_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "تغییر رمز عبور", 1))
                {

                    ChandePassword chp = new ChandePassword();
                    openform(chp);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }
            

        }

        private void WrapPanel_MouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "بخش بیمه", 1))
                {

                    InsuranceForm insf = new InsuranceForm();
                    openform(insf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }

         

            
        }

        private void WrapPanel_MouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "بخش تعرفه", 1))
                {

                    TariffeForm tf = new TariffeForm();
                    openform(tf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }

           

            
        }

        private void WrapPanel_MouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "خدمات", 1))
                {

                    ServiecesForm sf = new ServiecesForm();
                    openform(sf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

            }
            catch
            {

            }


          
       
        }

        private void WrapPanel_MouseLeftButtonDown_11(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void WrapPanel_MouseLeftButtonDown_12(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "قبوض", 1))
                {

                    GhooboozForm ghf = new GhooboozForm();
                    openform(ghf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }

           

         
        }

        private void WrapPanel_MouseLeftButtonDown_13(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "نوبت دهی", 1))
                {

                    NobatForm n = new NobatForm();
                    openform(n);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }


           
        }

        private void WrapPanel_MouseLeftButtonDown_14(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "سوابق بیماران", 1))
                {

                    SavabeghForm saf = new SavabeghForm();
                    openform(saf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }
          
           

        }
        BackupRestoreBLL brbll = new BackupRestoreBLL();
        private void WrapPanel_MouseLeftButtonDown_15(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "پشتیبانی", 1))
                {

                 

                    BackRes br = new BackRes();
                    br.linkLabel1.Text = "در صورتی که میخواهید عملیات پشتیبان گیری کامل شود کلیک کنید";
                    openform(br);



                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

            }
            catch
            {

            }
           

        
        }

        private void WrapPanel_MouseLeftButtonDown_16(object sender, MouseButtonEventArgs e)
        {
            //try
            //{
                if (ubll.Access(loggedinuser, "بازگردانی", 1))
                {


                    BackRes br = new BackRes();
                    br.linkLabel1.Text = "در صورتی که میخواهید عملیات بازیابی انجام شود کلیک کنید";
                    openform(br);



                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
           // }
            //catch
            //{

            //}
          

         
        }

     

        private void WrapPanel_MouseLeftButtonDown_18(object sender, MouseButtonEventArgs e)
        {
           
          
           

        }

     

        private void WrapPanel_MouseLeftButtonDown_19(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "لیست بیماران", 1))
                {

                    Report r = new Report();
                    openform(r);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

            }
            catch
            {

            }
          


           
        }

        private void WrapPanel_MouseLeftButtonDown_20(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "ثبت اطلاعات بیماران", 1))
                {

                    FileForm f = new FileForm();
                    openform(f);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

            }
            catch
            {

            }
          

           
        }

        private void WrapPanel_MouseLeftButtonDown_21(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "جستجوی شماره پرونده", 1))
                {

                    SearchParvande shp = new SearchParvande();
                    openform(shp);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }
          


           
        }

        private void WrapPanel_MouseLeftButtonDown_22(object sender, MouseButtonEventArgs e)
        {
            try
            {
                LogIn2 l2 = new LogIn2();
                l2.linkLabel2.Visible = true;
                l2.linkLabel1.Visible = false;
                openform(l2);
                this.Close();
            }
            
            catch
            {

            }
        }
          

        private void WrapPanel_MouseLeftButtonDown_23(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "ایجاد شماره پرونده", 1))
                {

                    ShomareParvandeForm shp = new ShomareParvandeForm();
                    openform(shp);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }
           

        }

        private void WrapPanel_MouseLeftButtonDown_24(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "نمودار", 1))
                {

                    ReportDate rd = new ReportDate();
                    openform(rd);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }
          

           
        }

        private void WrapPanel_MouseLeftButtonDown_17(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "گزارشات", 1))
                {

                    ListForms lf = new ListForms();
                    openform(lf);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }

           
        }

        private void WrapPanel_MouseLeftButtonDown_25(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "تنظیم تاریخ حضور پزشک", 1))
                {

                    SetTime st = new SetTime();
                    openform(st);
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }
           
          
        }

        private void WrapPanel_MouseLeftButtonDown_26(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (ubll.Access(loggedinuser, "پذیرش", 1))
                {

                    PatiantForm pf = new PatiantForm();
                    openform(pf);
                }

            else
            {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
            }
            catch
            {

            }

           
           

        }
    }
}
