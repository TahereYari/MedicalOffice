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
using Microsoft.Office.Interop.Excel;
using Stimulsoft.Report;



namespace Medical_Office
{
    public partial class ListForms : Form
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
        public ListForms()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
        }

        #region Definations

        User u = new User();
        UserBLL ubll = new UserBLL();

        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();

        Insuarance i = new Insuarance();
        InsuaranceBLL ibll = new InsuaranceBLL();

        Servieces s = new Servieces();
        ServiceBLL sbll = new ServiceBLL();

        Tariffe t = new Tariffe();
        TariffeBLL tbll = new TariffeBLL();

        Files f = new Files();
        FileBLL fbll = new FileBLL();

        msgBox m = new msgBox();
        StiReport sti = new StiReport();

        DialogResult res = new DialogResult();
        
        #endregion

        #region Methodes

        void DataGridUser()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = ubll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;

                dataGridViewX1.Columns["Name"].HeaderText = "نام و نام خانوادگی";
                dataGridViewX1.Columns["UserName"].HeaderText = "نام کاربری";
                dataGridViewX1.Columns["CodeMelli"].HeaderText = "کد ملی";
                dataGridViewX1.Columns["title"].HeaderText = "نوع کاربری";
            }
            catch { }
        }

        void DataGridDoctor()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = dbll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;

                dataGridViewX1.Columns["Name"].HeaderText = "نام پزشک";
                dataGridViewX1.Columns["CodeMelli"].HeaderText = "شماره ملی";
                dataGridViewX1.Columns["DoctorNumber"].HeaderText = "کدنظام پزشکی";
                dataGridViewX1.Columns["Phone"].HeaderText = "شماره تلفن";
                dataGridViewX1.Columns["sex"].HeaderText = "جنسیت";
                dataGridViewX1.Columns["takhasos"].HeaderText = "تخصص";
            }
            catch { }

        }

        private void DataGridInsutance()
        {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = ibll.Read();
            dataGridViewX1.Columns["id"].Visible = false;
            dataGridViewX1.Columns[0].Width = 50;
            dataGridViewX1.Columns["id"].Visible = false;
            dataGridViewX1.Columns["NameOfInsutance"].HeaderText = "نوع بیمه";
            dataGridViewX1.Columns["Code"].HeaderText = "کدبیمه";
        }


        void DataGridService()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = sbll.ReadForReport();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
                dataGridViewX1.Columns["NameOfService"].HeaderText = "نام سرویس";
                dataGridViewX1.Columns["Code"].HeaderText = "کدخدمات";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
            }
            catch
            {

            }

        }

        private void DataGridTarefe()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = tbll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;
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

        void DataGridFile()
        {
            try
            {
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = fbll.Read();
                dataGridViewX1.Columns["id"].Visible = false;
                dataGridViewX1.Columns[0].Width = 50;

                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["CodeMelli"].HeaderText = "شماره ملی";
                dataGridViewX1.Columns["Phone"].HeaderText = "شماره تلفن";
                dataGridViewX1.Columns["Sex"].HeaderText = "جنسیت";

            }
            catch { }

        }

        #endregion
        private void ListForms_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            }
            catch { }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewX1.Rows.Count<2)
                {
                    m.myshowdialog("", "داده ای برای نمایش وجود ندارد. لطفا دیتا گرید را چک کنید", "", false, false);
                }
                else
                {
                    RightToLeft rtl; rtl = dataGridViewX1.RightToLeft;
                    if (dataGridViewX1.RightToLeft == RightToLeft)
                    {
                        dataGridViewX1.RightToLeft = RightToLeft.No;
                    }
                    dataGridViewX1.SelectAll();
                    DataObject dataObj = dataGridViewX1.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);
                    dataGridViewX1.RightToLeft = rtl;
                    dataGridViewX1.ClearSelection();
                    //---------------------------------------
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Workbook xlWorkBook;
                    Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Microsoft.Office.Interop.Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1]; CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                    xlWorkSheet.Columns.AutoFit();
                    //تنظیم شیت به صورت راست به چپ
                    xlWorkSheet.DisplayRightToLeft = true;
                    //تنظیم چیدمان متن درون ستون ها
                    xlWorkSheet.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    // استایل دهی به صورت جدول ------------------
                    Microsoft.Office.Interop.Excel.Range TableRange = (Microsoft.Office.Interop.Excel.Range)xlexcel.Selection;
                    TableRange.Worksheet.ListObjects.Add(XlListObjectSourceType.xlSrcRange, TableRange, System.Type.Missing, XlYesNoGuess.xlYes, System.Type.Missing).Name = "Table1";
                    TableRange.Select();
                    TableRange.Worksheet.ListObjects["Table1"].TableStyle = "TableStyleMedium14";
                    //--------------------------

                    //ذخیره سازی
                    // xlWorkBook.SaveAs("e:\\DatagridViewToExcell.xlsx");
                    Random rnd = new Random();
                    string s = rnd.Next(1000000).ToString();
                     s = rnd.Next(1000000).ToString();
                   
                    xlWorkBook.SaveAs(System.Windows.Forms.Application.StartupPath+ "\\Excel\\DatagridViewToExcell"+s+".xlsx");

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

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (radiouser.Checked)
                {
                    DataGridUser();
                    res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                    if (res == DialogResult.Yes)
                    {
                        sti.CacheAllData = true;
                    sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportUser.mrt");
                    sti.Render();
                        sti.Show();

                    }
                }
            //***************************************************

            if (radiodoctor.Checked)
            {
                DataGridDoctor();
                res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                if (res == DialogResult.Yes)
                {
                    sti.CacheAllData = true;
                    sti.Load(System.Windows.Forms.Application.StartupPath+ @"//Reports//ReportDoctor.mrt");
                    //  sti.RegBusinessObject("user", dataGridViewX1.DataSource);
                    sti.Render();
                    sti.Show();

                }
            }
            //***************************************************

            if (radioinsure.Checked)
            {
               DataGridInsutance();
                res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                if (res == DialogResult.Yes)
                {
                    sti.CacheAllData = true;
                    sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportInsutance.mrt");
                    //  sti.RegBusinessObject("user", dataGridViewX1.DataSource);
                    sti.Render();
                    sti.Show();

                }
            }
            //***************************************************
            if (radioservice.Checked)
            {
                DataGridService();
                res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                if (res == DialogResult.Yes)
                {
                    sti.CacheAllData = true;
                    sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportService.mrt");
                    sti.Render();
                    sti.Show();

                }
            }
            //***************************************************

            if (radiotarefe.Checked)
            {
               DataGridTarefe();
                res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                if (res == DialogResult.Yes)
                {
                    sti.CacheAllData = true;
                    sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportTarefe.mrt");
                    sti.Render();
                    sti.Show();

                }
            }
            //***************************************************
            if (radiopatiant.Checked)
            {
                DataGridFile();
                res = m.myshowdialog("چاپ اطلاعات", "آیا قصد چاپ اطلاعات رادارید ؟", "", true, false);

                if (res == DialogResult.Yes)
                {
                    sti.CacheAllData = true;
                    sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportFile.mrt");
                    sti.Render();
                    sti.Show();

                }
            }
            //***************************************************
        }
            catch
            {

            }

        }
    }
}
