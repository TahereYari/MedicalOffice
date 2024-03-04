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
using Stimulsoft.Report;

namespace Medical_Office
{
    public partial class ServiecesForm : Form
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
        public ServiecesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
            //this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region definations
        Servieces s = new Servieces();
        ServiceBLL sbll = new ServiceBLL();
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
                dataGridViewX1.DataSource = sbll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                DGVPersian();
            }
            catch
            {

            }
            
     }
        public void DGVPersian()
        {
            try
            {
                dataGridViewX1.Columns["NameOfService"].HeaderText = "نوع بیمه";
                dataGridViewX1.Columns["Code"].HeaderText = "کدخدمات";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
            }
            catch
            {

            }
 
        
        }
        void EmptyControls()
        {
            try
            {
                txtName.Focus();
                txtcode.Text = "";
                txtName.Text = "";
                combodoctor.Text = "";

                txtcode.WatermarkText = "کدخدمات";
                txtName.WatermarkText = "نام خدمات";
                combodoctor.WatermarkText = "نام دکتر";
            }
            catch
            {

            }
     
        }

        #endregion
        private void ServiecesForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtName.Focus();
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
                FillGrid();
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

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "خدمات", 3))
                {
                    s = sbll.Read(id);
                    Doctor d = new Doctor();

                    res = m.myshowdialog("", "آیا میخواهید ویرایش انجام دهید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {
                        txtcode.Text = s.Code;
                        txtName.Text = s.NameOfService;
                        combodoctor.Text = s.Doctor.Name;
                        xuiButton3.ButtonText = "ویرایش اطلاعات";
                        xuiButton3.ButtonImage = Properties.Resources.icons8_pencil_64;
                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

               
            }
            catch
            {
                m.myshowdialog("", "مشکلی پیش آمده است دوباره تلاش کنید.", "", true, false);
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

                if (ubll.Access(u1, "خدمات", 4))
                {
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("اخطار", "آیا از حذف اطمینان دارید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {
                        m.myshowdialog("حذف اطلاعات", sbll.Delete(id), "", false, false);
                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

              
            txtName.Focus();
            FillGrid();
            }
            catch
            {
                m.myshowdialog("", "مشکلی پیش آمده است دوباره تلاش کنید.", "", true, false);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = sbll.Search(txtsearch.Text);
                dataGridViewX1.Columns["id"].Visible = false;
                DGVPersian();
            }
            catch { }
           
        }

  
        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
             //   MainWindow mf = new MainWindow();
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "خدمات", 2))
                {
                    //  Servieces sd = new Servieces();
                    s.Code = txtcode.Text;
                    s.Regdate = DateTime.Now;
                    s.NameOfService = txtName.Text;
                    d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));
                    // sd = sbll.ReadName(txtName.Text);
                    //  d.Servieces.Add(sd);
                    //   d = dbll.ReadN(int.Parse(combodocName.SelectedValue.ToString()));
                    // d = dbll.ReadN(int.Parse(combodoctor.GetItemText(combodoctor.SelectedValue.ToString())));


                    if (xuiButton3.ButtonText == "ثبت اطلاعات")
                    {
                        m.myshowdialog("ثبت اطلاعات", sbll.Create(s, d), "", false, false);

                    }
                    else
                    {
                        s.Code = txtcode.Text;
                        s.NameOfService = txtName.Text;

                        m.myshowdialog("ویرایش اطلاعات", sbll.Update(s, id, d), "", false, false);
                        xuiButton3.ButtonText = "ثبت اطلاعات";
                        xuiButton3.ButtonImage = Properties.Resources.icons8_add_64;

                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

              

            }
            catch (Exception)
            {
                m.myshowdialog("ثبت اطلاعات", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }
            FillGrid();
            EmptyControls();
            xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtcode.Focus();
                }
            }
            catch
            {

            }
          
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    combodoctor.Focus();
                }
            }
            catch
            {

            }
         
        }

        private void combodoctor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    xuiButton3.Focus();
                    xuiButton3.BackgroundColor = Color.FromArgb(173, 182, 196);
                }
            }
            catch
            {

            }
           
           
        }

        private void xuiButton3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                xuiButton3_Click(sender, e);
            }
            catch { }
          
        }


        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
