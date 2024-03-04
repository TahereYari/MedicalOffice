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
using System.Globalization;
using Stimulsoft.Report;


namespace Medical_Office
{
    public partial class GhooboozForm : Form
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
        public GhooboozForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }

        #region Definations
        Patiant p = new Patiant();
        PationtBLL pbll = new PationtBLL();

        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();

        Files f = new Files();
        FileBLL fbll = new FileBLL();

        Tariffe t = new Tariffe();
        TariffeBLL tbll = new TariffeBLL();

        Ghobooz gh = new Ghobooz();
        GhoboozBLL ghbll = new GhoboozBLL();
        msgBox m = new msgBox();
        int id;

        #endregion

        public string ConvertDate(string date1)
        {
            try
            {
                DateTime date2 = Convert.ToDateTime(date1);
                PersianCalendar pc = new PersianCalendar();
                return date2.ToString("yyyy/MM/dd");
            }
            catch (Exception)
            {
                dateTimePickerX2.Focus();
                return m.myshowdialog("", "لطفا در ورود تاریخ دقت نمایید", "", false, false).ToString();

            }

        }

        public void DGVPersian1()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = ghbll.SearchPay(ConvertDate(dateTimePickerX2.Text), combodoctor.Text);

                dataGridViewX1.Columns["Price"].DefaultCellStyle.Format = "N0";

                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
                dataGridViewX1.Columns["Price"].HeaderText = "هزینه";
                dataGridViewX1.Columns["id"].Visible = false;
            }
            catch { }
       
        }
        public void DGVPersian2()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = ghbll.SearchUnPay(ConvertDate(dateTimePickerX2.Text), combodoctor.Text);

                dataGridViewX1.Columns["Price"].DefaultCellStyle.Format = "N0";

                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
                dataGridViewX1.Columns["Price"].HeaderText = "هزینه";
                dataGridViewX1.Columns["id"].Visible = false;
            }
            catch { }

        }
        private void GhooboozForm_Load(object sender, EventArgs e)
        {
            try
            {
               
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
                dataGridViewX1.Columns["id"].Visible = false;
                combodoctor.Focus();
                //  FillGrid();
                combodoctor.Focus();
               // DGVPersian();
            }
            catch
            {

            }
        }


        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkPay.Checked)
                {
                     DGVPersian1();
                }

                else
                {
                     DGVPersian2();
                }
            }
            catch { }

        }


        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
                id = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["id"].Value);

            }
            catch
            { }
        }

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                dataGridViewX1.Columns[0].Width = 50;

            }
            catch
            { }

        }

        private void پرداختToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "قبوض", 2))
                {
                    if (ghbll.Ischecked(id))
                    {
                        m.myshowdialog("", "عملیات پرداخت با موفقیت انجام شد.", "", false, false);
                    }
                    else
                    {
                        m.myshowdialog("", "قبض قبلا پرداخت شده است.", "", false, false);
                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

               
            }
            catch { }
         
        }

        private void چاپقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<BE.Dto.TarrefeServiceVM> GhabzPrint = new List<BE.Dto.TarrefeServiceVM>();

                GhabzPrint = ghbll.ReadView(id);
                StiReport sti = new StiReport();
                sti.CacheAllData = true;
                sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportGHabz.mrt");
                sti.Dictionary.Variables["Doctor"].Value = combodoctor.Text;
                sti.Dictionary.Variables["Date"].Value = ConvertDate(dateTimePickerX2.Text);
                sti.Dictionary.Variables["Price"].Value = dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["Price"].Value.ToString();
                sti.RegBusinessObject("ghabz", GhabzPrint);
               sti.Render();
                sti.Show();
              //  sti.Print();
            }
            catch
            {
                m.myshowdialog("اخطار", "خطایی رخ داده است لطفا دوباره تلاش کنید.", "", false, false);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
