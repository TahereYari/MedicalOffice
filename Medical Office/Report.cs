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
using Stimulsoft;
using Stimulsoft.Report;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Medical_Office
{
    public partial class Report : Form
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
        public Report()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
          //  this.BackColor = Color.FromArgb(169, 214, 229);
        }

        DoctorBLL dbll = new DoctorBLL();
        PationtBLL pbll = new PationtBLL();
        msgBox m = new msgBox();
        DialogResult res;
        #region methode
        void fillgrid()
        {
            try
            {
                string d1 = ConvertDate(dateTimePickerX1.Text);
                string d2 = ConvertDate(dateTimePickerX2.Text);

                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = pbll.ListPatiant(d1, d2);

                dataGridViewX1.Columns[0].Width = 50;
                dataGridViewX1.Columns["id"].Visible = false;

                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["VisitDate"].HeaderText = "تاریخ مراجعه";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
                dataGridViewX1.Columns["Hozor"].HeaderText = "ساعت حضور";


            }
            catch { }
        }
        void fillgridDoctor()
        {
            try
            {
                string d1 = ConvertDate(dateTimePickerX1.Text);
                string d2 = ConvertDate(dateTimePickerX2.Text);

                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = pbll.ListPatiantByDoctor(d1, d2, combodoctor.Text);

                dataGridViewX1.Columns[0].Width = 50;
                dataGridViewX1.Columns["id"].Visible = false;

                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["VisitDate"].HeaderText = "تاریخ مراجعه";
                dataGridViewX1.Columns["Hozor"].HeaderText = "ساعت حضور";
            }
            catch { }
        }
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
        public int GetPersianDayesDiffDate(string date1, string date2)
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


        #endregion


        //public DateTime ConvertDate1(string date1)
        //{
        //    DateTime date2 = Convert.ToDateTime(date1);
        //    string s = date2.ToString("yyyy/MM/dd");
        //    return Convert.ToDateTime(s);
        //}
        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
            }
            catch { }

         
        }
        StiReport sti = new StiReport();
        private void xuiButton1_Click(object sender, EventArgs e)
        {

            try
            {
                sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//Reportlistofdate.mrt");
                sti.Dictionary.Variables["Date"].Value = (ConvertDate(dateTimePickerX1.Text));
                sti.Dictionary.Variables["NameOfDoctor"].Value = combodoctor.Text;
                sti.RegBusinessObject("ListPatiantOfDate", dataGridViewX1.DataSource);
                sti.Render();
                sti.Show();
            }
            catch { }
       
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = pbll.Search(ConvertDate(dateTimePickerX1.Text), combodoctor.Text);
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["Hozor"].HeaderText = "ساعت حضور";
            }
            catch { }
           
        }

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            { dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1; }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void xuiButton2_Click(object sender, EventArgs e)
        {
           
        }
        public Patiant PatiantLastWeek = new  Patiant();
        DataTable dt = new DataTable();
      //  public List<Patiant> LastWeek = new List<Patiant>();
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
        public string LastWeek()
        {
            PersianCalendar c = new PersianCalendar();
            string d1 = (c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + (c.GetDayOfMonth(DateTime.Now) - 7).ToString("0#"));
            return d1;
        }
        public string DateNow()
        {
            PersianCalendar c = new PersianCalendar();
            string d1 = (c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#"));
            return d1;
        }

        void reportlistOfPatiant()
        {
            try
            {
                string d10 = ConvertDate(dateTimePickerX1.Text);
                string d20 = ConvertDate(dateTimePickerX2.Text);

                sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//Reportlistofpatiant1.mrt");
                sti.Dictionary.Variables["date1"].Value = ConvertDate(dateTimePickerX1.Text);
                sti.Dictionary.Variables["date2"].Value = ConvertDate(dateTimePickerX1.Text);
                sti.RegBusinessObject("ListOfPatiant", dataGridViewX1.DataSource);
                sti.Render();
                sti.Show();
            }
            catch { }
          
        }
        void reportlistOfPatiantByDoctor()
        {
            try
            {
                string d10 = ConvertDate(dateTimePickerX1.Text);
                string d20 = ConvertDate(dateTimePickerX2.Text);
         
                sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportIstOfPatiantByDoctor.mrt");
                sti.Dictionary.Variables["date1"].Value = ConvertDate(dateTimePickerX1.Text);
                sti.Dictionary.Variables["date2"].Value = ConvertDate(dateTimePickerX1.Text);
                sti.Dictionary.Variables["doctor"].Value = combodoctor.Text;
                sti.RegBusinessObject("listOfPatiantByDoctor", dataGridViewX1.DataSource);
                sti.Render();
                sti.Show();
            }
            catch
            {

            }
       
        }
  
        private void xuiButton5_Click(object sender, EventArgs e)
        {
            try
            {
                //*********************************************************************************************
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "لیست بیماران", 2))
                {
                    if (radioButton1.Checked)
                    {

                        fillgrid();
                        res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                        if (res == DialogResult.Yes)
                        {
                            reportlistOfPatiant();
                        }

                    }
                    //*********************************************************************************************
                    if (radioButton2.Checked)
                    {

                        fillgridDoctor();
                        res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                        if (res == DialogResult.Yes)
                        {
                            reportlistOfPatiantByDoctor();
                        }
                    }
                    //*********************************************************************************************
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
