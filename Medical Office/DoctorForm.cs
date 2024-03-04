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
using System.IO;
using System.Globalization;

namespace Medical_Office
{
    public partial class DoctorForm : Form
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
        public DoctorForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region  Definations
        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();
        OpenFileDialog ofp = new OpenFileDialog();
        msgBox m = new msgBox();
        int id;
        #endregion

        #region Methodes
        string SavePic(string UserName)
        {
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\userpic\";
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
               m.myshowdialog("","سیستم قادر به ذخیره عکس نمیباشد:\n" + e.Message,"",false,false);
            }
            return path + PicName;
        }
        void FillDataGrid()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = dbll.Read();
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
                dataGridViewX1.Columns["Name"].HeaderText = "نام پزشک";
            dataGridViewX1.Columns["CodeMelli"].HeaderText = "شماره ملی";
            dataGridViewX1.Columns["DoctorNumber"].HeaderText = "کدنظام پزشکی";
            dataGridViewX1.Columns["Phone"].HeaderText = "شماره تلفن";
            dataGridViewX1.Columns["sex"].HeaderText = "جنسیت";
            dataGridViewX1.Columns["takhasos"].HeaderText = "تخصص";
        }
            catch { }
        }

        void emptyControls()
        {
            try
            {
                txtname.Focus();
                txtname.Text = "";
                txtadd.Text = "";
                txtcode1.Text = "";
                txtdcodeN.Text = "";
                txtphone.Text = "";
                combosex.Text = "";
                dtbirthday.Text = "";
                txttakhasos.Text = "";

                txtname.WatermarkText = "نام و نام خانوادگی";
                txtadd.WatermarkText = "آدرس";
                txtcode1.WatermarkText = "کدملی";
                txtdcodeN.WatermarkText = "شماره نظام پزشکی";
                txtphone.WatermarkText = "شماره تلفن";
                combosex.WatermarkText = "جنسیت";
            }
            catch { }


        }

        string ConvertDate(string date1)
        {
          
            DateTime date2 = Convert.ToDateTime(date1);
            PersianCalendar pc = new PersianCalendar();
            return date2.ToString("yyyy/MM/dd");
          
        }

        #endregion

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtname.Focus();
                FillDataGrid();
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
            catch { }
            
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtfamily_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtadd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtdcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "اطلاعات پزشکان", 3))
                {

                    Doctor d = new Doctor();
                    d = dbll.Read(id);

                    DialogResult res = new DialogResult();

                    res = m.myshowdialog("", "میخواهید اطلاعات را ویرایش کنید؟", "", true, false);
                if (res == DialogResult.Yes)
                {
                        txtname.Text = d.Name;
                        //  txtfamily.Text = d.Family;
                        txtphone.Text = d.Phone;
                        txtdcodeN.Text = d.DoctorNumber;
                        txtcode1.Text = d.CodeMelli;
                        txtadd.Text = d.Address;
                        combosex.Text = d.sex;
                        txttakhasos.Text = d.takhasos;
                        dtbirthday.Text = ConvertDate(d.birhthday).ToString();

                        if (d.Pic != null)
                        {
                          pictureBox2.ImageLocation = System.Windows.Forms.Application.StartupPath +@"\userpic\" + d.Pic;
                    //   pictureBox2.ImageLocation =  d.Pic;
                    }


                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
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

                if (ubll.Access(u1, "اطلاعات پزشکان", 4))
                {
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("", "آیا از حذف اطمینان دارید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {
                        m.myshowdialog("حذف اطلاعات", dbll.Delete(id), "", false, false);

                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

              
            FillDataGrid();
                txtname.Focus();

              }
            catch(Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
            
           
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = dbll.Search(textBoxX2.Text);
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                DGVPersian();
            }
            catch { }

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pictureBox2.ImageLocation);
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) +@"\userpic\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            pictureBox2.Image.Save(path + imageName);

            if (xuiButton3.ButtonText == "ثبت اطلاعات")
            {
                    if(txtcode1.TextLength<11 || txtphone.TextLength<11)
                    {
                        m.myshowdialog("", " لطفا در ورود کد ملی و شماره تلفن دقت نمایید", "", false, false);
                    }
                    else
                    {
                        MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                        User u1 = new User();
                        u1 = mf.loggedinuser;
                        UserBLL ubll = new UserBLL();

                        if (ubll.Access(u1, "اطلاعات پزشکان", 2))
                        {
                            d.Name = txtname.Text;
                            d.Phone = txtphone.Text;
                            d.CodeMelli = txtcode1.Text;
                            d.Address = txtadd.Text;
                            d.DoctorNumber = txtdcodeN.Text;
                            d.birhthday = ConvertDate(dtbirthday.Text);
                            d.sex = combosex.Text;
                            d.RegDate = DateTime.Now;
                            d.takhasos = txttakhasos.Text;
                            if (pictureBox2.Image != null)
                            {
                            d.Pic = imageName;
                                //d.Pic = SavePic(txtdcodeN.Text);
                            }
                            else
                            {
                                m.myshowdialog("اخطار", "تصویر کاربر انتخاب نشده است.", "", false, false);

                                d.Pic = null;

                            }
                            m.myshowdialog("ثبت اطلاعات", dbll.create(d), "", false, false);
                        }

                        else
                        {

                            m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                        }

                    }




                }

                else
                {
                    if (txtcode1.TextLength < 11 || txtphone.TextLength < 11)
                    {
                        m.myshowdialog("", " لطفا در ورود کد ملی و شماره تلفن دقت نمایید", "", false, false);
                    }
                    else
                    {

                        d.Name = txtname.Text;
                        d.Phone = txtphone.Text;
                        d.CodeMelli = txtcode1.Text;
                        d.Address = txtadd.Text;
                        d.DoctorNumber = txtdcodeN.Text;
                        d.birhthday = ConvertDate(dtbirthday.Text);
                        d.sex = combosex.Text;
                        d.takhasos = txttakhasos.Text;
                       
                        if (pictureBox2.Image != null)
                        {

                            d.Pic = imageName;
                        }
                        else
                        {
                            m.myshowdialog("اخطار", "تصویر کاربر انتخاب نشده است.", "", false, false);
                            d.Pic = null;

                        }
                        m.myshowdialog("ویرایش اطلاعات", dbll.Update(d, id), "", false, false);
                        xuiButton3.ButtonText = "ثبت اطلاعات";
                        xuiButton3.ButtonImage = Properties.Resources.icons8_join_64;

                    }
                }
               
                FillDataGrid();
                emptyControls();
            }
            catch (Exception)
            {
                m.myshowdialog("اخطار", "لطفا در ورود اطلاعات دقت نمایید:\n", "", false, false);
            }

            pictureBox2.Image = null;
            xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
            FillDataGrid();
            emptyControls();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtcode1.Focus();

                }
            }
            catch { }
            
        }

        private void txtcode1_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            if (e.KeyCode == Keys.Enter)
            {
                txtphone.Focus();

            }
        }
            catch { }
        }

        private void txtphone_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            if (e.KeyCode == Keys.Enter)
            {
                txtadd.Focus();

            }
        }
            catch { }
        }

        private void txtadd_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            if (e.KeyCode == Keys.Enter)
            {
                txtdcodeN.Focus();

            }
            }
            catch { }

        }

        private void txtdcodeN_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            if (e.KeyCode == Keys.Enter)
            {
                txttakhasos.Focus();

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
                dtbirthday.Focus();

            }
        }
            catch { }
        }

        private void dtbirthday_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void xuiButton3_KeyDown(object sender, KeyEventArgs e)
        {
            try { xuiButton3_Click(sender, e);}
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Image Pic;
                //ofp.Filter = "JPG(*.JPG)|*.JPG";
                //ofp.Title = "تصویر کاربر  را انتخاب کنید.";
                if (ofp.ShowDialog() == DialogResult.OK)
                {
                    //Pic = Image.FromFile(ofp.FileName);
                    //pictureBox2.Image = Pic;
                    //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                   
                    pictureBox2.ImageLocation = ofp.FileName;
                    xuiButton3.Focus();
                    xuiButton3.BackgroundColor = Color.FromArgb(173, 182, 196);

                }
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttakhasos_KeyDown(object sender, KeyEventArgs e)
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
    }
}
