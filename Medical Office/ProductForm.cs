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
    public partial class ProductForm : Form
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
        public ProductForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
            this.BackColor = Color.FromArgb(169, 214, 229);
        }
     
        #region definations
        Product p = new Product();
        ProductBLL pbll = new ProductBLL();
        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();
        int id;
       // DialogResult res = new DialogResult();
        #endregion

        #region Methodes
        //void FillGrid1()
        //{
        //    dataGridViewX1.DataSource = null;
        //    dataGridViewX1.DataSource = pbll.Read();
        //    dataGridViewX1.Columns["شناسه"].Visible = false;
        //}
        void EmptyControls1()
        {
            txtcod.Text = "";
            txttahvil.Text = "";
            txtname.Text = "";
            combodocName.Text = "";
        }
        void EmptyControls2()
        {
            txtcodeOue.Text = "";
            txtnameOut.Text = "";
            txtGirande.Text = "";
            comboDocNameOut.Text = "";
        }

        #endregion
        private void Product_Load(object sender, EventArgs e)
        {

            //combodocName.DataSource = dbll.ReadName();
            //combodocName.DisplayMember = "Name";
            //combodocName.ValueMember = "id";

          //  FillGrid1();
        }

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dataGridViewX2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            id = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["شناسه"].Value);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            p.Code = txtcod.Text;
            p.Name = txtname.Text;
            p.NameDeliver = txttahvil.Text;
      //   d = dbll.ReadN(int.Parse(combodocName.SelectedValue.ToString()));

            //try
            //{
                if (labelX4.Text == "ثبت اطلاعات")
                {

                    MessageBox.Show(pbll.Create(p, d));
                }

                else
                {
                    MessageBox.Show(pbll.Update(p, id,d));
                    labelX4.Text = "ثبت اطلاعات";

                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("لطفا در ورود اطلاعات دقت نمایید.");
            //}

          //  FillGrid1();
            EmptyControls1();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
