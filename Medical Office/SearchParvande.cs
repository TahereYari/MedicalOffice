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

namespace Medical_Office
{
    public partial class SearchParvande : Form
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
        public SearchParvande()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
         //   this.BackColor = Color.FromArgb(169, 214, 229);
        }

        ShomareParvandeBLL shbll = new ShomareParvandeBLL();
        ShomareParvande shp = new ShomareParvande();
        msgBox m = new msgBox();
        FileBLL fbll = new FileBLL();
        private void SearchParvande_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewX1.Columns["FullName"].HeaderText = "نام و نام خانوادگی بیمار";
                dataGridViewX1.Columns["FilesNumber"].HeaderText = "شماره پرونده";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
                textBoxX2.Focus();

                //AutoCompleteStringCollection CodeMeliis = new AutoCompleteStringCollection();
                //foreach (var item in fbll.ReadCodeMelii())
                //{
                //    CodeMeliis.Add(item);
                //}
                //textBoxX2.AutoCompleteCustomSource = CodeMeliis;
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
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewX1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                dataGridViewX1.Columns[0].Width = 50;
            }
            catch
            { }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                //if (ubll.Access(u1, "جستجوی شماره پرونده", 2))
                //{
                    dataGridViewX1.DataSource = null;
                    dataGridViewX1.DataSource = shbll.Search(textBoxX2.Text);
                    dataGridViewX1.Columns[0].Width = 50;

                    dataGridViewX1.Columns["FullName"].HeaderText = "نام و نام خانوادگی بیمار";
                    dataGridViewX1.Columns["FilesNumber"].HeaderText = "شماره پرونده";
                    dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
                //}

                //else
                //{

                //    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                //}

            }
            catch
            {

            }
        }
    }
}
