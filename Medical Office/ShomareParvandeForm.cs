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

namespace Medical_Office
{
    public partial class ShomareParvandeForm : Form
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
        public ShomareParvandeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
            
        }
        DoctorBLL dbll = new DoctorBLL();
        FileBLL fbll = new FileBLL();
        Doctor d = new Doctor();
        Files fi = new Files();
        ShomareParvande sh = new ShomareParvande();
        ShomareParvandeBLL shbll = new ShomareParvandeBLL();
        msgBox m = new msgBox();
        private void ShomareParvandeForm_Load(object sender, EventArgs e)
        {
            try
            {
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
                txtcode.Focus();

                AutoCompleteStringCollection CodeMeliis = new AutoCompleteStringCollection();
                foreach (var item in fbll.ReadCodeMelii())
                {
                    CodeMeliis.Add(item);
                }
                txtcode.AutoCompleteCustomSource = CodeMeliis;
            }
            catch { }
            

        }

        private void symbolBox2_Click(object sender, EventArgs e)
        {
            try
            {
                //  d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));
                Files fi = new Files();
                fi = fbll.ReadMelli(txtcode.Text);

                if (fi == null)
                {
                    if (txtcode.TextLength < 11)
                    {
                        m.myshowdialog("", " لطفا در ورود کد ملی دقت نمایید", "", false, false);
                    }
                    else
                    {
                        FileForm ff = new FileForm();

                        ff.txtcode.Text = this.txtcode.Text;
                        ff.txtcode.Enabled = false;
                        ff.ShowDialog();
                    }

                    
                }

                combodoctor.Enabled = true;
                combodoctor.Focus();
            }
            catch { }
            

        }

   
        private void xuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                UserBLL ubll = new UserBLL();
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;

                if (ubll.Access(u1, "ایجاد شماره پرونده", 2))
                {
                    Files f = new Files();
                    ShomareParvande sh = new ShomareParvande();
                    f = fbll.ReadMelli(txtcode.Text);
                    d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));
                    sh.RegDate = DateTime.Now;
                    m.myshowdialog("", shbll.Create(sh, f, d), "", false, false);
                    //   shbll.Create(sh, f, d);
                    sh = shbll.ReadSH(f.id);
                    txtfile.Text = sh.FilesNumber;
                    combodoctor.Enabled = false;
                    xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
                }



                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

           
            }
            catch (Exception)
            {
                m.myshowdialog("", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }

        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                symbolBox2_Click(sender,e);
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
