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


namespace Medical_Office
{
    public partial class SetTime : Form
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
        public SetTime()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }

        #region Definations
        msgBox m = new msgBox();

        Time ti = new Time();
        TimeBLL tibll = new TimeBLL();

        Date da = new Date();
        DateBLL dabll = new DateBLL();

        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();

        List<Time> liti = new List<Time>();
        List<Date> lida = new List<Date>();
        Time t1 = new Time();
        UserBLL ubll = new UserBLL();

        public List<string> Timess = new List<string>();


        int id2;
        int id1;
        #endregion

        void filldrid1()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = tibll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                dataGridViewX1.Columns["time1"].HeaderText = "ساعت";
            }
            catch { }
      
        }

        void filldrid2()
        {
            try
            {

                dataGridViewX2.DataSource = null;
            dataGridViewX2.DataSource = dabll.Search(ConvertDate(dateTimePickerX3.Text),combodoctor2.Text);
            dataGridViewX2.Columns[0].Width = 50;
                dataGridViewX2.Columns["id"].Visible = false;
                dataGridViewX2.Columns["Times1"].HeaderText = "ساعت";
                dataGridViewX2.Columns["Name"].HeaderText = "نام دکتر";
                dataGridViewX2.Columns["date1"].HeaderText = "تاریخ نوبت دهی";
 

            }
            catch { }
        }
         string ConvertDate(string date1)
        {
            try
            {
                DateTime date2 = Convert.ToDateTime(date1);
                PersianCalendar c = new PersianCalendar();
               string date3= c.GetYear(date2).ToString("####/") + c.GetMonth(date2).ToString("0#/") + c.GetDayOfMonth(date2).ToString("0#");
                return date3;
            }
            catch (Exception)
            {
                dateTimePickerX2.Focus();
                return m.myshowdialog("", "لطفا در ورود تاریخ دقت نمایید", "", false, false).ToString();

            }
        }
        void ReadTime()
        {
            try
            {
                combTime.DataSource = tibll.ReadTime();
                combTime.DisplayMember = "time1";
                combTime.ValueMember = "id";
            }
            catch { }
            
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
        private void SetTime_Load(object sender, EventArgs e)
        {
            try {
                ReadTime();

            combodoctor.DataSource = dbll.ReadName();
            combodoctor.DisplayMember = "Name";
            combodoctor.ValueMember = "id";
          //  combodoctor.Focus();

            combodoctor2.DataSource = dbll.ReadName();
            combodoctor2.DisplayMember = "Name";
            combodoctor2.ValueMember = "id";
                filldrid1();
            }
            catch { }
        }
        private void symbolBox2_Click(object sender, EventArgs e)
        {
            //try
            //{
                listBox1.Items.Add(combTime.Text);
                t1 = tibll.Readt(combTime.GetItemText(combTime.SelectedItem));
                string t2 = combTime.Text;
           
                 liti.Add(t1);
            //foreach (var it in Timess)
            //{
            //    string Search_Str = it.ToString();
            //    if(Search_Str.Count()>1)
            //    {
            //        Timess.Remove(Search_Str);
            //    }
            //    else
            //    {
            //        listBox1.Items.Add(combTime.Text);
            //    }
                //int Index = listBox1.FindString(Search_Str, -1);
                //if (Index != -1)
                //{
                //    // listBox1.SetSelected(Index, true);
                //    listBox1.Items.Remove(Search_Str);

                //}
           // }


            //}
            //catch
            //{}

        }

        private void symbolBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ti.time1 = maskedTextBox2.Text;
                tibll.Create(ti);
                //  m.myshowdialog("ثبت اطلاعات","اطلاعات ثبت شد." , "", false, false);
                maskedTextBox2.Text = "";
                filldrid1();
                ReadTime();

            }
            catch { m.myshowdialog("اخطار", "لطفا به وجود آمده است لطفا دوباره تلاش کنید.", "", false, true); }
           
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
        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;

                if (ubll.Access(u1, "تنظیم تاریخ حضور پزشک", 2))
                {
                    string d1 = ConvertDate(dateTimePickerX1.Text);
                    string d2 = ConvertDate(dateTimePickerX2.Text);
                    int days = GetPersianDayesDiffDate(d1, d2);
                    DateTime d11 = Convert.ToDateTime(d1);
                    string s;
                    d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));
                    if (days <= 0)
                    {
                        m.myshowdialog("اخطار", "لطفا در ورود تاریخ دقت نمایید.", "", false, false);
                    }
                    else
                    {
                        for (int i = 0; i <= days; i++)
                        {
                            foreach (var item in listBox1.Items)
                            {
                                DateTime d0 = d11.AddDays(i);
                                da.date1 = ConvertDate(d0.ToString());
                                s = item.ToString();
                                dabll.Create(da, s, d);
                            }

                        }
                        m.myshowdialog("ثبت اطلاعات", "اطلاعات با موفقیت ثبت شد", "", false, false);
                        combTime.Text = "";
                    }
                }


                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

                
            
                listBox1.Items.Clear();
        }
            catch
            {
                m.myshowdialog("اخطار", "لطفا در ثبت اطلاعات دقت نمایید", "", false, false);
            }

}
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            try { filldrid2(); }
            catch { }
          
        }

        private void dataGridViewX2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX2.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                dataGridViewX2.Columns[0].Width = 50;
            }
            catch
            {

            }
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                contextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);
                id2 = Convert.ToInt32(dataGridViewX2.Rows[dataGridViewX2.CurrentRow.Index].Cells["id"].Value);
            }
            catch
            {

            }
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
                id1 = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["id"].Value);
            }
            catch
            {

            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new DialogResult();
                res = m.myshowdialog("حذف اطلاعات", "آیا از حذف اطمینان دارید؟", "", true, false);
                if (res == DialogResult.Yes)
                {
                    m.myshowdialog("حذف اطلاعات", tibll.Delete(id1), "", false, false);
                }
                ReadTime();
            }
            catch (Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }

            filldrid1();
        }

        private void حذفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "بخش تعرفه", 4))
                {
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("حذف اطلاعات", "آیا از حذف اطمینان دارید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {
                        m.myshowdialog("حذف اطلاعات", dabll.Delete(id2), "", false, false);
                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

               
                filldrid1();
            }
            catch (Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }

           
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try { listBox1.Items.Remove(listBox1.SelectedItem); }
            catch { }
          
        }

        private void maskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    symbolBox1_Click(sender, e);

                }
            }
            catch { }
         
        }

        private void combTime_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    symbolBox2_Click(sender, e);
                }
            }
            catch { }
           
        }



        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
            //چرا 1- قرار دادم یعنی جایی که هیچ عنصری وجود ندارد
            //اگر مخالف 1- بود یعنی یک چیزی را پیدا کرده است————–


        }
    }
}
