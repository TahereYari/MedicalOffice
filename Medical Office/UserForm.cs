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
using System.Windows;

namespace Medical_Office
{
    public partial class UserForm : Form
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
        public UserForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
        //    this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region Definations

        User u = new User();
        UserBLL ubll = new UserBLL();
        int id;
        UserGroupBLL ugbll = new UserGroupBLL();
        OpenFileDialog ofp = new OpenFileDialog();
        UserGroup ug = new UserGroup();
        MainWindow mf = new MainWindow();
        msgBox m = new msgBox();
        System.Windows.Forms.DialogResult res = new System.Windows.Forms.DialogResult();
        #endregion

        #region Methodes

        void DataFill()
        {
            try
            {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = ubll.Read();
            dataGridViewX1.Columns["id"].Visible = false;
            dataGridViewX1.Columns[0].Width = 50;
            DGVPersian();
            txtname.Focus();
            }
            catch { }
        }
        public void DGVPersian()
        {
            try
            { 
            dataGridViewX1.Columns["Name"].HeaderText = "نام و نام خانوادگی";
            dataGridViewX1.Columns["UserName"].HeaderText = "نام کاربری";
            dataGridViewX1.Columns["CodeMelli"].HeaderText = "کد ملی";
            dataGridViewX1.Columns["title"].HeaderText = "نوع کاربری";
            }
            catch { }

        }
        void emptytext()
        {
            try
            { 
            txtCodeMelli.Text = "";
            txtname.Text = "";
            txtPass.Text = "";
            txtrepPass.Text = "";
            txtUserName.Text = "";
            comboAccess.Text = "";
            txtCodeMelli.WatermarkText = "کدملی";
            txtname.WatermarkText = "نام و نام خانوادگی";
            txtPass.WatermarkText = "رمز عبور";
            txtrepPass.WatermarkText = "تکرار رمز عبور";
            txtUserName.WatermarkText = "نام کاربری";
            comboAccess.WatermarkText = "نوع کاربری";
            txtname.Focus();
            }
            catch { }

        }
        string SavePic(string UserName)
        {
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\userpic\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //Random rnd = new Random();
            //string s = rnd.Next(1000000).ToString();
         
           
            //    s = rnd.Next(1000000).ToString();
            
            string PicName = UserName + ".jpg";
            try
            {
                string picpath = ofp.FileName;
                File.Copy(picpath, path + PicName, true);

            }
            catch (Exception e)
            {
                m.myshowdialog("", "سیستم قادر به ذخیره عکس نمیباشد:\n" + e.Message, "", false, false);
            }
            return path + PicName;
        }
     
        #endregion
        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataFill();

                comboAccess.DataSource = ugbll.ReadGroup();
                comboAccess.DisplayMember = "title";
                //  comboAccess.ValueMember = "id";
                txtname.Focus();
            }
            catch 
            {
               
            }
           
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
            User u1 = new User();
            u1 = mf.loggedinuser;

                if (ubll.Access(u1, "اطلاعات کاربران", 3))
                {
                    res = m.myshowdialog("", "میخواهید اطلاعات را ویرایش کنید؟", "", true, false);
                if (res == System.Windows.Forms.DialogResult.Yes)

                {
                    u = ubll.Read(id);
                    txtname.Text = u.Name;
                    txtUserName.Text = u.UserName;
                    txtCodeMelli.Text = u.CodeMelli;
                   comboAccess.Text = u.UserGroup.title;
                    //txtPass.Text = u.Password;
                    //txtrepPass.Text = u.Password;
                    txtPass.Enabled = false;
                    txtrepPass.Enabled = false;

                    xuiButton3.ButtonText = "ویرایش اطلاعات";
                    xuiButton3.ButtonImage = Properties.Resources.icons8_pencil_64;
                if (u.Pic != null)
                {
                            //pictureBox5.Image = Image.FromFile(u.Pic);
                            //pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox5.ImageLocation = System.Windows.Forms.Application.StartupPath + @"\userpic\" + u.Pic; 
                        }
                else
                    {
                        pictureBox5.Image = null;
                    }
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

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            }
            catch { }
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
                id = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["id"].Value);
                User unactive = new User();
                unactive = ubll.Read(id);
                if (unactive.Active == true)
                {
                     فعالغیرفعالToolStripMenuItem.Image = Properties.Resources.active;
                }
                else
                {
                    فعالغیرفعالToolStripMenuItem.Image = Properties.Resources.deactive;
                }
            }
            catch
            {

            }
         }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
            User u1 = new User();
            u1 = mf.loggedinuser;

                if (ubll.Access(u1, "اطلاعات کاربران", 4))
                {

                    res = m.myshowdialog("", "آیا از حذف اطمینان دارید؟", "", true, false);
                if (res == System.Windows.Forms.DialogResult.Yes)

                {

                    m.myshowdialog("حذف اطلاعات", ubll.Delete(id), "", false, false);
                }
                }
                else
                {
                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
                DataFill();
            }
            catch(Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }
           
        }

    
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxX8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = ubll.Search(textBoxX8.Text);
                dataGridViewX1.Columns["id"].Visible = false;
                DGVPersian();
             
                dataGridViewX1.Columns[0].Width = 50;
                DGVPersian();
               
            }
            catch
            {

            }
           
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                ug = ugbll.ReadByTitle(comboAccess.Text);
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pictureBox5.ImageLocation);

                string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\userpic\";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pictureBox5.Image.Save(path + imageName);

                if (xuiButton3.ButtonText == "ثبت اطلاعات")
                {
                    if (txtCodeMelli.TextLength < 11)
                    {
                        m.myshowdialog("", " لطفا در ورود کد ملی و شماره تلفن دقت نمایید", "", false, false);
                    }
                    else
                    {
                        if (ubll.Access(u1, "اطلاعات کاربران", 2))
                        {
                            if (txtPass.Text == txtrepPass.Text)
                            {
                                u.Password = txtrepPass.Text;
                            }
                            else
                            {
                                m.myshowdialog("اخطار", "تکرار کلمه عبور نادرست است.", "", false, false);

                            }
                            u.Name = txtname.Text;
                            u.UserName = txtUserName.Text;
                            u.CodeMelli = txtCodeMelli.Text;
                          

                            u.RegDate = DateTime.Now;


                            if (pictureBox5.Image != null)
                            {

                                //   u.Pic = SavePic(txtUserName.Text);
                                u.Pic = imageName;
                            }
                            else
                            {
                                m.myshowdialog("اخطار", "تصویر کاربر انتخاب نشده است.", "", false, false);
                                u.Pic = null;


                            }
                            m.myshowdialog("ثبت اطلاعات", ubll.Create(u, ug), "", false, false);
                        }
                        else
                        {

                            m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                        }


                    }


                }
                    else
                {

                    if (txtCodeMelli.TextLength < 11)
                    {
                        m.myshowdialog("", " لطفا در ورود کد ملی دقت نمایید", "", false, false);
                    }
                    else
                    {
                       
                        u.Name = txtname.Text;
                        u.UserName = txtUserName.Text;
                        u.CodeMelli = txtCodeMelli.Text;
                      // u.Pic = SavePic(txtUserName.Text);
                        //   u.Password = txtrepPass.Text;
                        if (pictureBox5.Image != null)
                        {

                            u.Pic = imageName;
                        }
                        else
                        {
                            m.myshowdialog("اخطار", "تصویر کاربر انتخاب نشده است.", "", false, false);
                            u.Pic = null;


                        }
                        m.myshowdialog("ویرایش اطلاعات", ubll.Update(u, id), "", false, false);

                        xuiButton3.ButtonText = "ثبت اطلاعات";
                        xuiButton3.ButtonImage = Properties.Resources.icons8_join_64;
                    }
    
            }
                txtPass.Enabled = true;
                txtrepPass.Enabled = true;
                pictureBox5.Image = null;
                DataFill();
                emptytext();
                xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
            }
            catch (Exception)
            {
                m.myshowdialog("اخطار", "لطفا در ورود اطلاعات دقت نمایید:\n", "", false, false);
            }

        }

        private void فعالغیرفعالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                User uactive = new User();
                uactive = ubll.Read(id);
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                if (ubll.Access(u1, "اطلاعات کاربران", 4))
                {
                    if (uactive.Active == true)
                {
                    res = m.myshowdialog("", "کاربر فعال است آیا میخواهید آن را غیر فعال کنید؟", "", true, false);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        ubll.ReadActive(id, false);
                        m.myshowdialog("", "کاربر غیرفعال شد.", "", false, false);
                            فعالغیرفعالToolStripMenuItem.Image = Properties.Resources.deactive;
                            DataFill();
                    }

                   


                }
                else
                {
                    res = m.myshowdialog("", "کاربر غیرفعال است آیا میخواهید آن را  فعال کنید؟", "", true, false);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        ubll.ReadActive(id, true);
                        m.myshowdialog("", "کاربر فعال شد.", "", false, false);
                            فعالغیرفعالToolStripMenuItem.Image = Properties.Resources.active;
                            DataFill();
                    }

                

                }
                }
                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }
                DataFill();
            }
            catch(Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }
         
        }

     

        private void txtCodeMelli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

     

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCodeMelli.Focus();
                }
            }
            catch { }
           
        }

        private void txtCodeMelli_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { 
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
            }
            catch { }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

            if (e.KeyCode == Keys.Enter)
            {
                txtrepPass.Focus();
            }
            }
            catch { }
        }

        private void txtrepPass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { 
            if (e.KeyCode == Keys.Enter)
            {
                txtUserName.Focus();
            }
            }
            catch { }
        }


        private void xuiButton3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { xuiButton3_Click(sender, e);
            }
            catch { }
        }

        private void comboAccess_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { 
            if (e.KeyCode == Keys.Enter)
            {
                linkLabel1_LinkClicked(sender,e);
            }
            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtUserName_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            { 
            if (e.KeyCode == Keys.Enter)
            {
                comboAccess.Focus();
            }
            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Image Pic;
                //ofp.Filter = "JPG(*.JPG)|*.JPG";
                //ofp.Title = "تصویر کاربر  را انتخاب کنید.";
                if (ofp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Pic = Image.FromFile(ofp.FileName);
                    //pictureBox5.Image = Pic;
                    //pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.ImageLocation = ofp.FileName;
                

                    xuiButton3.Focus();
                    xuiButton3.BackgroundColor = Color.FromArgb(173, 182, 196);
                }
            }
            catch (Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
