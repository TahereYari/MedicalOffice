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
using System.Globalization;
using System.Runtime.InteropServices;

namespace Medical_Office
{
    public partial class ReportDate : Form
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
        public ReportDate()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }
        PationtBLL pbll = new PationtBLL();
        DoctorBLL dbll = new DoctorBLL();
        Doctor d = new Doctor();
        msgBox m = new msgBox();
        Savabegh sa = new Savabegh();
        SavabeghBLL sabll = new SavabeghBLL();
        User u = new User();
        UserBLL ubll = new UserBLL();
       
        string ConvertDate(string date1)
        {
            try
            {
                DateTime date2 = Convert.ToDateTime(date1);
                PersianCalendar c = new PersianCalendar();
                string date3 = c.GetYear(date2).ToString("####/") + c.GetMonth(date2).ToString("0#/") + c.GetDayOfMonth(date2).ToString("0#");
                return date3;
            }
            catch (Exception)
            {
                dateTimePickerX2.Focus();
                return m.myshowdialog("", "لطفا در ورود تاریخ دقت نمایید", "", false, false).ToString();

            }
        }
        public int GetPersianDayesDiffDate1(string date1, string date2)
        {
            int year1 = Convert.ToInt16(date1.Substring(0, 4));
            int month1 = Convert.ToInt16(date1.Substring(5, 2));
            int day1 = Convert.ToInt16(date1.Substring(8, 2));
            int year2 = Convert.ToInt16(date2.Substring(0, 4));
            int month2 = Convert.ToInt16(date2.Substring(5, 2));
            int day2 = Convert.ToInt16(date2.Substring(8, 2));
            PersianCalendar c = new PersianCalendar();
            DateTime d1 = c.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
            DateTime d2 = c.ToDateTime(year2, month2, day2, 0, 0, 0, 0);
            TimeSpan ts = d2.Subtract(d1);
            return ts.Days;
        }

        public bool GetPersianDayesDiffDate(string date1, string date2)
        {
            int year1 = Convert.ToInt16(date1.Substring(0, 4));
            int month1 = Convert.ToInt16(date1.Substring(5, 2));
            int day1 = Convert.ToInt16(date1.Substring(8, 2));
            int year2 = Convert.ToInt16(date2.Substring(0, 4));
            int month2 = Convert.ToInt16(date2.Substring(5, 2));
            int day2 = Convert.ToInt16(date2.Substring(8, 2));
            PersianCalendar c = new PersianCalendar();
            DateTime d1 = c.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
            DateTime d2 = c.ToDateTime(year2, month2, day2, 0, 0, 0, 0);
            TimeSpan ts = d2.Subtract(d1);

            if(d1>=d2)
            {
                return true;
            }
            else
            {
                return false;
            }
           // return ts.Days;
        }

        public bool GetPersianDayesDiffDate2(string date1, string date2)
        {
            int year1 = Convert.ToInt16(date1.Substring(0, 4));
            int month1 = Convert.ToInt16(date1.Substring(5, 2));
            int day1 = Convert.ToInt16(date1.Substring(8, 2));
            int year2 = Convert.ToInt16(date2.Substring(0, 4));
            int month2 = Convert.ToInt16(date2.Substring(5, 2));
            int day2 = Convert.ToInt16(date2.Substring(8, 2));
            PersianCalendar c = new PersianCalendar();
            DateTime d1 = c.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
            DateTime d2 = c.ToDateTime(year2, month2, day2, 0, 0, 0, 0);
            TimeSpan ts = d2.Subtract(d1);

            if (d1 <= d2)
            {
                return true;
            }
            else
            {
                return false;
            }
            // return ts.Days;
        }
        public int GetPersianDayesDiffDate3(string date1, string date2)
        {
            int year1 = Convert.ToInt16(date1.Substring(0, 4));
            int month1 = Convert.ToInt16(date1.Substring(5, 2));
            int day1 = Convert.ToInt16(date1.Substring(8, 2));
            int year2 = Convert.ToInt16(date2.Substring(0, 4));
            int month2 = Convert.ToInt16(date2.Substring(5, 2));
            int day2 = Convert.ToInt16(date2.Substring(8, 2));
            PersianCalendar c = new PersianCalendar();
            DateTime d1 = c.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
            DateTime d2 = c.ToDateTime(year2, month2, day2, 0, 0, 0, 0);
            TimeSpan ts = d2.Subtract(d1);
            return ts.Days;
        }
   

        private void ReportDate_Load(object sender, EventArgs e)
        {
            try
            {
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
            }
            catch { }

        }




        private void xuiButton5_Click(object sender, EventArgs e)
        {

            ///***************************************************************************************
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                PersianCalendar c = new PersianCalendar();
                string dateNow = c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#");

                if (ubll.Access(u1, "گزارشات", 2))
                {
                    chart2.Series["Series1"].Points.Clear();
                    if (radioButton2.Checked)
                    {

                        foreach (var item in dbll.AcceptPationALLdoctor())
                        {
                            int x = 0;
                            foreach (var q in item.Patiants)
                            {

                                if (Convert.ToDateTime(q.VisitDate) > Convert.ToDateTime(ConvertDate(dateTimePickerX1.Text)) && Convert.ToDateTime(q.VisitDate) < Convert.ToDateTime(ConvertDate(dateTimePickerX2.Text)))

                                {
                                    x++;
                                }

                            }
                            chart2.Series["Series1"].Points.AddXY(item.Name, x);
                        }
                    }
                    ///***************************************************************************************   
                  
                    if (radioButton4.Checked)
                    {

                        foreach (var item in dbll.AcceptPationALLdoctor())
                        {
                            double x =0;
                            foreach (var q in item.Patiants)
                            {
                                //bool d1 = GetPersianDayesDiffDate(q.VisitDate, ConvertDate(dateTimePickerX1.Text));
                                //bool d2 = GetPersianDayesDiffDate2(q.VisitDate, ConvertDate(dateTimePickerX2.Text));
                                if (Convert.ToDateTime(q.VisitDate) > Convert.ToDateTime(ConvertDate(dateTimePickerX1.Text)) && Convert.ToDateTime(q.VisitDate) < Convert.ToDateTime(ConvertDate(dateTimePickerX2.Text)))
                                {

                                    x = (x + q.Price);

                                }
                            }
                            chart2.Series["Series1"].Points.AddXY(item.Name, x.ToString("N0"));
                        }
                    }
                    ///***************************************************************************************  
                 
                    if (radioButton1.Checked)
                    {

                        foreach (var item in ubll.ReadPatiants())
                        {
                            int x = 0;
                            foreach (var q in item.Patiants)
                            {
                                bool d1 = GetPersianDayesDiffDate(q.VisitDate, ConvertDate(dateTimePickerX1.Text));
                                bool d2 = GetPersianDayesDiffDate2(q.VisitDate, ConvertDate(dateTimePickerX2.Text));

                                if (Convert.ToDateTime(q.VisitDate) > Convert.ToDateTime(ConvertDate(dateTimePickerX1.Text)) && Convert.ToDateTime(q.VisitDate) < Convert.ToDateTime(ConvertDate(dateTimePickerX2.Text)))
                                //if (d1 && d2)
                                {
                                    x++;
                                }

                            }
                            chart2.Series["Series1"].Points.AddXY(item.Name, x);
                        }
                    }
                    ///*************************************************************************************** 

                    if (radioButton3.Checked)
                    {

                        foreach (var item in dbll.AcceptPationALLdoctor())
                        {
                            int x = 0;
                            foreach (var q in item.Patiants)
                            {

                                if (Convert.ToDateTime(q.VisitDate)== Convert.ToDateTime(dateNow))

                                {
                                    x++;
                                }

                            }
                            chart2.Series["Series1"].Points.AddXY(item.Name, x);
                        }
                    }

                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }




            }
            catch { m.myshowdialog("اخطار", "لطفا در ورود اطلاعات دقت نمایید", "", false, false); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
