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
using System.Runtime.InteropServices;
using System.Globalization;

namespace Medical_Office
{
    public partial class SavabeghForm : Form
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
        public SavabeghForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }

        #region definations
        Savabegh sa = new Savabegh();
        SavabeghBLL sabll = new SavabeghBLL();

        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();


        Files f = new Files();
        FileBLL fbll = new FileBLL();

        int id;
        DialogResult res = new DialogResult();
        int fid;
        Files fi = new Files();

        ShomareParvande sh = new ShomareParvande();
        ShomareParvandeBLL shbll = new ShomareParvandeBLL();

        msgBox m = new msgBox();

        #endregion


        #region Methodes
        void FillGrid()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = sabll.ReadNumber(txtfile.Text);
                dataGridViewX1.Columns["id"].Visible = false;
                DGVPersian();
            }
            catch { }
           
        }
        public void DGVPersian()
        {
            try
            {
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
                dataGridViewX1.Columns["visiDate"].HeaderText = "تاریخ ویزیت";
            }
            catch { }
       
        }
        void EmptyControls()
        {
            labname.Text = "";
            labPhone.Text = "";
            labcode.Text = "";
            txtfile.Text = "";
            labsex.Text = "";
            //combinsureance.Text = "";
            combodoctor.Text = "";
            combodoctor.Focus();
            dateTimePickerX2.Text = "";
            txtType.Text = "";
            richmedicin.Text = "";
            richBio.Text = "";
            //txtname.WatermarkText = "نام و نام خانوادگی";
            //txtphone.WatermarkText = "شماره تلفن";
            //txtcode.WatermarkText = "کد ملی";
            txtfile.WatermarkText = "شماره پرونده";
            //combinsureance.WatermarkText = "نوع بیمه";
            combodoctor.WatermarkText = "نام دکتر";
            groupBox4.Enabled = false;
            dateTimePickerX2.Enabled = false;

        }
        #endregion
        private void SavabeghForm_Load(object sender, EventArgs e)
        {
            try
            {
                groupBox4.Enabled = false;
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
                combodoctor.Focus();

               

            }
            catch { }
           
            ////FillGrid();
        }


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
        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "سوابق بیماران", 3))
                {
                    sa = sabll.Read(id);
                    Doctor d = new Doctor();
                    res = m.myshowdialog("ویرایش اطلاعات", "آیا میخواهید ویرایش انجام دهید؟", "", true, false);

                    if (res == DialogResult.Yes)
                    {
                        // txtcode.Text = f.CodeMelli;
                        groupBox4.Enabled = true;
                        txtfile.Enabled = false;
                        combodoctor.Enabled = false;
                        labname.Enabled = false;
                        labPhone.Enabled = false;
                        labsex.Enabled = false;

                        dateTimePickerX2.Enabled = false;

                        richmedicin.Enabled = true;
                        richBio.Enabled = true;
                        richBio.Text = sa.Biography;
                        richmedicin.Text = sa.medicine;
                        txtType.Text = sa.TypeOfMedical;

                        xuiButton3.ButtonText = "ویرایش اطلاعات";
                        xuiButton3.ButtonImage = Properties.Resources.icons8_pencil_64;
                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

               
            }

            catch (Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "سوابق بیماران", 4))
                {

                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("حذف اطلاعات", "آیا از حذف اطمینان دارید؟", "", true, false);

                    if (res == DialogResult.Yes)
                    {
                        m.myshowdialog("حذف اطلاعات", sabll.Delete(id), "", false, false);

                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

            }
            catch (Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }
            combodoctor.Focus();
           FillGrid();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
                id = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["id"].Value);
             
            }
            catch
            {

            }

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
       
        private void symbolBox3_Click(object sender, EventArgs e)
        {
            try
            {
                FileBLL fbll = new FileBLL();
                ShomareParvande sh = new ShomareParvande();
                ShomareParvandeBLL shbll = new ShomareParvandeBLL();
                d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));

                sh = shbll.ReadSHD(txtfile.Text, d);

                if (sh != null)
                {
                    fid = sh.Filee.id;
                    fi = fbll.Read(fid);
                    if(fi==null)
                    {
                        m.myshowdialog("", "اطلاعات بیمار موجود نمیباشد", "", false, false);
                        groupBox4.Enabled = false;
                        dateTimePickerX2.Enabled = false;
                    }
                    else
                    {
                        groupBox4.Enabled = true;
                        dateTimePickerX2.Enabled = true;
                        labname.Text = fi.FullName;
                        labPhone.Text = fi.Phone;
                        labsex.Text = fi.Sex;
                        labcode.Text = fi.CodeMelli;
                    }
                  
                }
                else
                {
                    txtfile.Text = "";
                    ShomareParvandeForm shf = new ShomareParvandeForm();
                    shf.combodoctor.Text = this.combodoctor.Text;
                    shf.ShowDialog();
                 //   shf.combodoctor.Enabled = false;

                    this.txtfile.Text = shf.txtfile.Text;
                }
                FillGrid();
                txtfile.Enabled = false;
               
                dateTimePickerX2.Focus();


            }
            catch { }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

              

                if (xuiButton3.ButtonText == "ثبت اطلاعات")
                 {
                    if (ubll.Access(u1, "سوابق بیماران", 2))
                    {
                        sa.RegDate = DateTime.Now;
                        sh = shbll.ReadFilesNumber(txtfile.Text);
                        sa.visiDate = ConvertDate(dateTimePickerX2.Text);
                        sa.TypeOfMedical = txtType.Text;
                        sa.Biography = richBio.Text;
                        sa.medicine = richmedicin.Text;
                        m.myshowdialog("ثبت اطلاعات", sabll.Create(sa, d, fi, sh), "", false, false);
                        labcode.Enabled = false;
                    }

                    else
                    {

                        m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                    }

                    
                  }
            else
            {
                sa.Biography = richBio.Text;
                sa.medicine = richmedicin.Text;
                sa.TypeOfMedical = txtType.Text;
                    m.myshowdialog("ویرایش اطلاعات", sabll.Update(sa, id, d, fi, sh), "", false, false);
                xuiButton3.ButtonText = "ثبت اطلاعات";
                xuiButton3.ButtonImage = Properties.Resources.icons8_add_64;
               
               // combodoctor.Enabled = true;
            }

            }
            catch (Exception)
            {
                m.myshowdialog("ثبت اطلاعات", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }
            txtfile.Enabled = true;
            FillGrid();
            EmptyControls();
            xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
        }

        private void txtfile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

     



        

        private void لیستداروهاوشرححالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "سوابق بیماران", 3))
                {
                    Savabegh smb = new Savabegh();
                    smb = sabll.Read(id);
                    Medical_Bio mb = new Medical_Bio();
                    mb.richBio.Text = smb.Biography;
                    mb.richmedicin.Text = smb.medicine;
                    mb.labDate.Text = smb.visiDate;
                    mb.ShowDialog();

                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

               
            }
            catch { }
           
        }

        private void combodoctor_KeyDown(object sender, KeyEventArgs e)
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

        private void txtfile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    symbolBox3_Click(sender, e);
                }

            }
            catch { }
           
         
        }

        private void dateTimePickerX2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    richmedicin.Focus();
                }
            }
            catch { }
           
        }

        private void richmedicin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Tab)
                {
                    richBio.Focus();
                }
            }
            catch { }
           
        }

        private void richBio_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    xuiButton3.Focus();
                    xuiButton3.BackgroundColor = Color.FromArgb(173, 182, 196);
                }
            }
            catch { }

           
        }

        private void xuiButton3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    xuiButton3_Click(sender, e);
                }
            }
            catch { }

           
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    حذفToolStripMenuItem_Click(sender, e);
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

        private void txtfile_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void symbolBox1_Click(object sender, EventArgs e)
        {
            try
            {
                AutoCompleteStringCollection Shomare = new AutoCompleteStringCollection();
                foreach (var item in shbll.ReadShomare(combodoctor.Text))
                {
                    Shomare.Add(item);
                }
                txtfile.AutoCompleteCustomSource = Shomare;
                txtfile.Enabled = true;
                txtfile.Focus();
            }
            catch { }
           
        }
    }
}
