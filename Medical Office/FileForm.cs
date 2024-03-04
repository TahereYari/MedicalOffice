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

namespace Medical_Office
{
    public partial class FileForm : Form
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
        public FileForm()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
          //  this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region definations
        FileBLL fbll = new FileBLL();
        Files f = new Files();
        InsuaranceBLL ibll = new InsuaranceBLL();
        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();
        int id;
        DialogResult res = new DialogResult();
        msgBox m = new msgBox();
        #endregion

        #region Methodes
        void FillGrid()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = fbll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                DGVPersian();

            }
            catch { }
          
        }
        public void DGVPersian()
        {
            try
            {
                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["CodeMelli"].HeaderText = "شماره ملی";
                dataGridViewX1.Columns["Phone"].HeaderText = "شماره تلفن";
                dataGridViewX1.Columns["Sex"].HeaderText = "جنسیت";
            }
            catch
            {

            }
          

        }
        void EmptyControls()
        {
            try
            {
                txtname.Text = "";
                txtphone.Text = "";
                txtcode.Text = "";
                combosex.Text = "";

                txtname.WatermarkText = "نام و نام خانوادگی";
                txtphone.WatermarkText = "شماره تلفن";
                txtcode.WatermarkText = "کدملی";
                combosex.WatermarkText = "جنسیت";

                txtname.Focus();
            }
            catch { }
           
        }

        #endregion
        private void FileForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtname.Focus();

                FillGrid();
            }
            catch
            { 
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

                if (ubll.Access(u1, "ثبت اطلاعات بیماران", 3))
                {
                    f = fbll.Read(id);
                    Doctor d = new Doctor();
                    res = m.myshowdialog("ویرایش اطلاعات", "آیا میخواهید ویرایش انجام دهید؟", "", true, false);

                    if (res == DialogResult.Yes)
                    {
                        txtcode.Text = f.CodeMelli;
                        txtname.Text = f.FullName;
                        txtphone.Text = f.Phone;
                        combosex.Text = f.Sex;

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

                if (ubll.Access(u1, "ثبت اطلاعات بیماران", 4))
                {
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("حذف اطلاعات", "آیا از حذف اطمینان دارید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {
                        m.myshowdialog("حذف اطلاعات", fbll.Delete(id), "", false, false);
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

            FillGrid();
            txtname.Focus();
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

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = fbll.Search(textBoxX1.Text);
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                DGVPersian();
            }
            catch
            {

            }
           
        

        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (xuiButton3.ButtonText == "ثبت اطلاعات")
                {
                    if (txtcode.TextLength < 11 || txtphone.TextLength < 11)
                    {
                        m.myshowdialog("", " لطفا در ورود کد ملی و شماره تلفن دقت نمایید", "", false, false);
                    }
                    else
                    {
                        MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                        User u1 = new User();
                        u1 = mf.loggedinuser;
                        UserBLL ubll = new UserBLL();
                        f.CodeMelli = txtcode.Text;
                        f.RegDate = DateTime.Now;
                        f.FullName = txtname.Text;
                        f.Phone = txtphone.Text;
                        f.Sex = combosex.Text;
                        if (ubll.Access(u1, "ثبت اطلاعات بیماران", 2))
                        {

                            m.myshowdialog("ثبت اطلاعات", fbll.Create(f), "", false, false);
                        }

                        else
                        {

                            m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                        }



                    }

                }
            else
            {
                    if (txtcode.TextLength < 11 || txtphone.TextLength < 11)
                    {
                        m.myshowdialog("", " لطفا در ورود کد ملی و شماره تلفن دقت نمایید", "", false, false);
                    }
                    else
                    {
                        f.CodeMelli = txtcode.Text;
                        f.RegDate = DateTime.Now;
                        f.FullName = txtname.Text;
                        f.Phone = txtphone.Text;
                        f.Sex = combosex.Text;
                        m.myshowdialog("ویرایش اطلاعات", fbll.Update(f, id), "", false, false);
                        xuiButton3.ButtonText = "ثبت اطلاعات";
                        xuiButton3.ButtonImage = Properties.Resources.icons8_add_64;
                    }
                   
                }
                xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
                FillGrid();
                EmptyControls();

            }
            catch (Exception)
            {
                m.myshowdialog("ثبت اطلاعات", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }
       
        }



        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtcode.Focus();
                }
            }
            catch { }
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtphone.Focus();
            }
        }

        private void txtphone_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { 
                if (e.KeyCode == Keys.Enter)
                {
                    combosex.Focus();
                }
            }
            catch { }

        }

        private void combosex_KeyDown(object sender, KeyEventArgs e)
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
            try { xuiButton3_Click(sender, e); }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
