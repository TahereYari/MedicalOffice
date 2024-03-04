using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Medical_Office
{
    public partial class NobatForm : Form
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


        public NobatForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
          //  this.BackColor = Color.FromArgb(169, 214, 229);
        }

        #region Definations

        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();

        Date da = new Date();
        DateBLL dabll = new DateBLL();

        Time ti = new Time();
        TimeBLL tibll = new TimeBLL();
        msgBox m = new msgBox();

        Noabat n = new Noabat();
        NoabatBLL nbll = new NoabatBLL();
        FileBLL fbll = new FileBLL();
        Files f = new Files();


        #endregion

        public string ConvertDate(string date1)
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Nobat_Load(object sender, EventArgs e)
        {
            try
            {
              
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
               dateTimePickerX2.Focus();
                // FillGrid();

                comboDoc2.DataSource = dbll.ReadName();
                comboDoc2.DisplayMember = "Name";
                comboDoc2.ValueMember = "id";

                AutoCompleteStringCollection CodeMeliis = new AutoCompleteStringCollection();
                foreach (var item in fbll.ReadCodeMelii())
                {
                    CodeMeliis.Add(item);
                }
                txtcode.AutoCompleteCustomSource = CodeMeliis;

            }
            catch
            {

            }
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void symbolBox1_Click(object sender, EventArgs e)
        {
            try
            {
                combTime.DataSource = dabll.Search(ConvertDate(dateTimePickerX2.Text), combodoctor.Text);
                combTime.DisplayMember = "Times1";
                combTime.ValueMember = "id";

                combTime.Enabled = true;
                xuiButton3.Enabled = true;
                txtcode.Enabled = true;
            }
            catch { }
         
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {

                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "نوبت دهی", 2))
                {
                    n.Date1 = ConvertDate(dateTimePickerX2.Text);
                    n.doctor = combodoctor.Text;
                    n.Time1 = combTime.Text;
                    n.codeMelii = txtcode.Text;
                    m.myshowdialog("ثبت اطلاعات", nbll.Create(n), "", false, false);
                    dabll.Noabat(ConvertDate(dateTimePickerX2.Text), combodoctor.Text, combTime.Text);
                    combTime.Enabled = false;
                    combTime.Text = "";
                    txtcode.Text = "";

                    xuiButton3.Enabled = false;
                    txtcode.Enabled = false;
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

               
            }
            catch
            {
                m.myshowdialog("اخطار","لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }
        }
        void filldrid2()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = nbll.Search(ConvertDate(dateTimePickerX1.Text), comboDoc2.Text);
                dataGridViewX1.Columns[0].Width = 50;
                dataGridViewX1.Columns["Time1"].HeaderText = "ساعت";
            }
            catch { }
          
        }
     


        private void xuiButton1_Click(object sender, EventArgs e)
        {
            try { filldrid2(); }
            catch { }
            
        }

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                dataGridViewX1.Columns[0].Width = 50;
            }
            catch
            {

            }
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
