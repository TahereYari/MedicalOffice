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
using DAL;
using PagedList;

namespace Medical_Office
{
    public partial class TariffeForm : Form
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
        public TariffeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
         //   this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region definations
        InsuaranceBLL ibll = new InsuaranceBLL();
        Insuarance i = new Insuarance();
        int id;

        DB db = new DB();
        Tariffe t = new Tariffe();
        TariffeBLL tbll = new TariffeBLL();
        Servieces s = new Servieces();
        ServiceBLL sbll = new ServiceBLL();
        msgBox m = new msgBox();

        User u = new User();
        UserBLL ubll = new UserBLL();
        #endregion

        #region Methodes
     
        private void FillGrid()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = tbll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                DGVPersian();
            }
            catch { }
           

            //List = await tbll.getpagedListAsync(pagenumber, pagesize ,i);
            //picpre.Enabled = List.HasPreviousPage;
            //dataGridViewX1.DataSource = List.ToList();

            // labpagenumber.Text = string.Format("page  {0}/{1}", pagenumber, List.PageCount);
        }
        public void DGVPersian()
        {
            try
            {
                dataGridViewX1.Columns["PortionInsuarance"].DefaultCellStyle.Format = "N0";
                dataGridViewX1.Columns["PortionOrganizatin"].DefaultCellStyle.Format = "N0";
                dataGridViewX1.Columns["OtherCost"].DefaultCellStyle.Format = "N0";

                dataGridViewX1.Columns["NameOfInsutance"].HeaderText = "نوع بیمه";
                dataGridViewX1.Columns["NameOfService"].HeaderText = "نوع خدمات";
                dataGridViewX1.Columns["PortionInsuarance"].HeaderText = "سهم بیمه";
                dataGridViewX1.Columns["PortionOrganizatin"].HeaderText = "سایر هزینه ها";
                dataGridViewX1.Columns["OtherCost"].HeaderText = "سهم بیمار";
            }
            catch { }
       
           


        }
        void EmptyControls()
        {
            try
            {
                textBoxX2.Text = "";
                txtpartionI.Text = "";
                txtpartionO.Text = "";
                cominsure.Text = "";
                comboservices.Text = "";
                cominsure.Focus();

                textBoxX2.WatermarkText = "سهم بیمار";
                txtpartionI.WatermarkText = "سهم بیمه";
                txtpartionO.WatermarkText = "سم سازمان";
                cominsure.WatermarkText = "نوع بیمه";
                comboservices.WatermarkText = "نوع سرویس";
            }
            catch { }
     

        }
        #endregion
        private void TariffeForm_Load(object sender, EventArgs e)
        {
            try
            {
                cominsure.DataSource = ibll.ReadName();
                cominsure.DisplayMember = "NameOfInsutance";
                cominsure.ValueMember = "id";

                comboservices.DataSource = sbll.ReadALL();
                comboservices.DisplayMember = "NameOfService";
                comboservices.ValueMember = "id";
                cominsure.Focus();
                FillGrid();
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

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                dataGridViewX1.Columns[0].Width = 50;
            }
            catch { }
          
        }

        //private async void picpre_Click(object sender, EventArgs e)
        //{
        ////    if (List.HasPreviousPage)
        ////    {
        ////        List = await tbll.getpagedListAsync(--pagenumber, pagesize,i);
        ////        picpre.Enabled = List.HasPreviousPage;
        ////        dataGridViewX1.DataSource = List.ToList();
        ////        labpagenumber.Text = string.Format("page  {0}/{1}", pagenumber, List.PageCount);
        ////    }
        //}

        //private async void picnext_Click(object sender, EventArgs e)
        //{
        //    //if (List.HasNextPage)
        //    //{
        //    //    List = await tbll.getpagedListAsync(++pagenumber,pagesize,i);
        //    //    picpre.Enabled = List.HasPreviousPage;
        //    //    dataGridViewX1.DataSource = List.ToList();
        //    //    labpagenumber.Text = string.Format("page  {0}/{1}", pagenumber, List.PageCount);
        //    //}
        //}

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;

                if (ubll.Access(u1, "بخش تعرفه", 4))
                {
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("اخطار", "آیا از حذف اطمینان دارید؟", "", true, false);

                    if (res == DialogResult.Yes)
                    {
                        m.myshowdialog("حذف اطلاعات", tbll.Delete(id), "", false, false);

                    }
                    FillGrid();
                    cominsure.Focus();
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

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;

                if (ubll.Access(u1, "بخش تعرفه", 3))
                {
                    Tariffe t = new Tariffe();
                    t = tbll.Read(id);
                    DialogResult res = new DialogResult();
                    res = m.myshowdialog("", "آیا میخواهید ویرایش انجام دهید؟", "", true, false);
                    if (res == DialogResult.Yes)
                    {

                        textBoxX2.Text = t.OtherCost.ToString();
                        txtpartionI.Text = t.PortionInsuarance.ToString();
                        txtpartionO.Text = t.PortionOrganizatin.ToString();
                        cominsure.Text = t.Insuarance.NameOfInsutance;
                        comboservices.Text = t.Serviece.NameOfService;
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

        private void txtpartionI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtpartionI.Text.Length > 0)
                {
                    txtpartionI.TextChanged -= txtpartionI_TextChanged;
                    txtpartionI.Text = txtpartionI.Text.Replace(",", "");
                    txtpartionI.Text = String.Format("{0:N0}", long.Parse(txtpartionI.Text));
                    txtpartionI.TextChanged += txtpartionI_TextChanged;
                    txtpartionI.SelectionStart = txtpartionI.Text.Length;
                }
            }
            catch { }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = tbll.Search(textBoxX1.Text);
                dataGridViewX1.Columns["id"].Visible = false;
                DGVPersian();
            }
            catch { }
          
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
 
            try
            {

                if (xuiButton3.ButtonText == "ثبت اطلاعات")
                {
                    MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                    User u1 = new User();
                    u1 = mf.loggedinuser;

                    if (ubll.Access(u1, "بخش تعرفه", 2))
                    {
                        t.PortionInsuarance = Convert.ToDouble(txtpartionI.Text);
                        t.PortionOrganizatin = Convert.ToDouble(txtpartionO.Text);
                        t.OtherCost = Convert.ToDouble(textBoxX2.Text);
                        t.Regdate = DateTime.Now;
                        i = ibll.ReadN(cominsure.GetItemText(cominsure.SelectedItem));
                        s = sbll.ReadName(comboservices.GetItemText(comboservices.SelectedItem));
                        m.myshowdialog("ثبت اطلاعات", tbll.Create(t, i, s), "", false, false);
                    }



                    else
                    {

                        m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                    }
                }
                else

                {
                    t.PortionInsuarance = Convert.ToDouble(txtpartionI.Text);
                    t.PortionOrganizatin = Convert.ToDouble(txtpartionO.Text);
                    t.OtherCost = Convert.ToDouble(textBoxX2.Text);
                    t.Regdate = DateTime.Now;
                    i = ibll.ReadN(cominsure.GetItemText(cominsure.SelectedItem));
                    s = sbll.ReadName(comboservices.GetItemText(comboservices.SelectedItem));
                    m.myshowdialog("ویرایش اطلاعات", tbll.Update(t, id, i, s), "", false, false);
                    xuiButton3.ButtonText = "ثبت اطلاعات";
                    xuiButton3.ButtonImage = Properties.Resources.icons8_add_64;
                }

                xuiButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
                FillGrid();
                EmptyControls();
            }
            catch (Exception)
            {
                m.myshowdialog("", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);
            }

        }

    

      

        private void txtpartionI_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

            
            if (e.KeyCode == Keys.Enter)
            {
                    textBoxX2.Focus();

            }
            }
            catch { }
        }

        private void txtpartionO_KeyDown(object sender, KeyEventArgs e)
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
             xuiButton3_Click(sender, e);
            }
            catch { }
        }

        private void txtpartionI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtpartionO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtpartionO.Text.Length > 0)
                {
                    txtpartionO.TextChanged -= txtpartionO_TextChanged;
                    txtpartionO.Text = txtpartionO.Text.Replace(",", "");
                    txtpartionO.Text = String.Format("{0:N0}", long.Parse(txtpartionO.Text));
                    txtpartionO.TextChanged += txtpartionO_TextChanged;
                    txtpartionO.SelectionStart = txtpartionO.Text.Length;
                }
            }
            catch { }
        }

     
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxX2.Text.Length > 0)
                {
                    textBoxX2.TextChanged -= textBoxX2_TextChanged;
                    textBoxX2.Text = textBoxX2.Text.Replace(",", "");
                    textBoxX2.Text = String.Format("{0:N0}", long.Parse(textBoxX2.Text));
                    textBoxX2.TextChanged += textBoxX2_TextChanged;
                    textBoxX2.SelectionStart = textBoxX2.Text.Length;
                }
            }
            catch { }
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtpartionO.Focus();

                }
            }
            catch { }
        }

        private void txtpartionO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void comboservices_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtpartionI.Focus();

                }
            }
            catch { }
        }

        private void cominsure_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    comboservices.Focus();

                }
            }
            catch { }
        }
    }
}
