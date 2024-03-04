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
using BLL;
using BE;
using DAL;
using PagedList;
using System.Windows.Documents;
using Stimulsoft.Report;


namespace Medical_Office
{
    public partial class InsuranceForm : Form
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
        public InsuranceForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region definations
        InsuaranceBLL ibll = new InsuaranceBLL();
        Insuarance i = new Insuarance();
      //  int pagenumber=1;
       // int pagesize = 10;
        int id;
       /// IPagedList<Insuarance> List;
        DB db = new DB();
        msgBox m = new msgBox();
        #endregion

        #region Methode
        private  void  FillGrid()
          {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = ibll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                DGVPersian();
                //List = await ibll. getpagedListAsync(pagenumber,pagesize);
                //picpre.Enabled = List.HasPreviousPage;
                //dataGridViewX1.DataSource = List.ToList();
                //labpagenumber.Text = string.Format("page  {0}/{1}", pagenumber, List.PageCount);
            }
            catch
            {

            }
           

        }

        public void DGVPersian()
        {
            try
            {
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns["NameOfInsutance"].HeaderText = "نوع بیمه";
                dataGridViewX1.Columns["Code"].HeaderText = "کدبیمه";
            }
            catch
            {

            }
           
        }
        void emptycontrols()
        {
            try
            {
                txtcode.Text = "";
                txtname.Text = "";

                txtname.Focus();

                txtname.WatermarkText = "نام بیمه";
                txtcode.WatermarkText = "کدبیمه";
            }
            catch { }
        }
       
        #endregion


        private  void InsuranceForm_Load(object sender, EventArgs e)
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
            {

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

                if (ubll.Access(u1, "بخش بیمه", 4))
                {
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("اخطار", "آیا از حذف اطمینان دارید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {
                        m.myshowdialog("حذف اطلاعات", ibll.Delete(id), "", false, false);

                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }


              
                FillGrid();
                txtname.Focus();
        }
            catch(Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
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

                if (ubll.Access(u1, "بخش بیمه", 3))
                {
                    Insuarance i = new Insuarance();
                    i = ibll.Read(id);
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("", "آیا میخواهید ویرایش انجام دهید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {
                        txtcode.Text = i.Code;
                        txtname.Text = i.NameOfInsutance;
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

 

        //private async void picpre_Click(object sender, EventArgs e)
        //{
        //    //if (List.HasPreviousPage)
        //    //{
        //    //    List = await ibll. getpagedListAsync(--pagenumber,pagesize);
        //    //    picpre.Enabled = List.HasPreviousPage;
        //    //    dataGridViewX1.DataSource = List.ToList();
        //    //    labpagenumber.Text = string.Format("page  {0}/{1}", pagenumber, List.PageCount);
        //    //}
        //}

        //private async void picnext_Click(object sender, EventArgs e)
        //{
        //    //if (List.HasNextPage)
        //    //{
        //    //    List = await ibll. getpagedListAsync(++pagenumber,pagesize);
        //    //    picpre.Enabled = List.HasPreviousPage;
        //    //    dataGridViewX1.DataSource = List.ToList();
        //    //    labpagenumber.Text = string.Format("page  {0}/{1}", pagenumber, List.PageCount);
        //    //}
        //}

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = ibll.Search(textBoxX1.Text);
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

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {

            try
            {
                i.RegDate = DateTime.Now;
                if (xuiButton3.ButtonText == "ثبت اطلاعات")
                {
                    MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                    User u1 = new User();
                    u1 = mf.loggedinuser;
                    UserBLL ubll = new UserBLL();

                    if (ubll.Access(u1, "بخش بیمه", 2))
                    {
                        i.NameOfInsutance = txtname.Text;
                        i.Code = txtcode.Text;
                        m.myshowdialog("ثبت اطلاعات", ibll.Create(i), "", false, false);
                    }

                    else
                    {

                        m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                    }

                   
                }

                else
                {
                    i.NameOfInsutance = txtname.Text;
                    i.Code = txtcode.Text;
                    m.myshowdialog("ویرایش اطلاعات", ibll.Update(i, id), "", false, false);
                    xuiButton3.ButtonText = "ثبت اطلاعات";
                    xuiButton3.ButtonImage = Properties.Resources.icons8_add_64;
                  
                }

            }
            catch (Exception)
            {
                m.myshowdialog("", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }

            xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
            FillGrid();
            emptycontrols();
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
