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
using System.Globalization;
using System.Windows;

namespace Medical_Office
{
    public partial class PatiantForm : Form
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
        public PatiantForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(30, 30, Width, Height, 30, 30));
           // this.BackColor = Color.FromArgb(169, 214, 229);
        }
        #region definations
        Servieces s = new Servieces();
        ServiceBLL sbll = new ServiceBLL();

        Doctor d = new Doctor();
        DoctorBLL dbll = new DoctorBLL();
       
        Insuarance i = new Insuarance();
        InsuaranceBLL ibll = new InsuaranceBLL();

        Patiant p = new Patiant();
        PationtBLL pbll = new PationtBLL();

        Files f = new Files();
        FileBLL fbll = new FileBLL();

        int id;
        System.Windows.Forms.DialogResult res = new System.Windows.Forms.DialogResult();

        public List<Servieces> Serviecess = new List<Servieces>();
      

        Servieces ss = new Servieces();
        Insuarance ii = new Insuarance();
        Tariffe output = new Tariffe();

        List<BE.Dto.TarrefeServiceVM> outputdto = new List<BE.Dto.TarrefeServiceVM>();
        BE.Dto.TarrefeServiceVM outputdto1 = new BE.Dto.TarrefeServiceVM();
        BE.Dto.TarrefeServiceVM out1 = new BE.Dto.TarrefeServiceVM();
        List<BE.Dto.TarrefeServiceVM> Listtarrefe1 = new List<BE.Dto.TarrefeServiceVM>();


        public List<Tariffe> listTareefe = new List<Tariffe>();
        public List<Tariffe> outputlist = new List<Tariffe>();

        Tariffe t = new Tariffe();
        TariffeBLL tbll = new TariffeBLL();
        msgBox m = new msgBox();
      public DataTable Output3 = new DataTable();

        PersianCalendar c = new PersianCalendar();

        Ghobooz gh = new Ghobooz();
        GhoboozBLL ghbll = new GhoboozBLL();
        double Price = 0;
        public object output1 { get; private set; }

        Noabat n = new Noabat();
        NoabatBLL nbll = new NoabatBLL();

        Date da = new Date();
        DateBLL dabll = new DateBLL();
        


        #endregion


        #region Methodes
        void FillGrid()
        {
            try
            {
                
                string date=  c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#");
                dataGridViewX1.DataSource = null;
                dataGridViewX1.DataSource = pbll.Read(date);
                dataGridViewX1.Columns["id"].Visible = false;

                DGVPersian();
            }
            catch
            {

            }
          
        }

        void FillComboHozor()
        {
            try
            {
                string date = c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#");
                comboh.DataSource = dabll.Search(date, combodoctor.Text);
                comboh.DisplayMember = "Times1";
                comboh.ValueMember = "id";

            }
            catch
            {

            }

        }


        public void DGVPersian()
        {
            try
            {
                dataGridViewX1.Columns["FullName"].HeaderText = "نام بیمار";
                dataGridViewX1.Columns["Name"].HeaderText = "نام دکتر";
                dataGridViewX1.Columns["Hozor"].HeaderText = "ساعت حضور";
            }
            catch { }
           
        }
        void EmptyControls()
        {
            try
            {
                labname.Text = "";
                labPhone.Text = "";
                txtcode.Text = "";
                txtsex.Text = "";
                combinsureance.Text = "";
                combodoctor.Text = "";
                comboservice.Text = "";
                dateTimePickerX2.Text = c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#"); ;
                comboh.Text = "";
                listBox1.Items.Clear();
                checkPay.Checked = false;


                combinsureance.Enabled = false;
                dateTimePickerX2.Enabled = false;
                comboservice.Enabled = false;
                listBox1.Enabled = false;
                comboh.Enabled = false;
                txtcode.Enabled = false;
                checkPay.Enabled = false;
                txtcode.WatermarkText = "کد ملی";
                // txtfile.WatermarkText = "شماره پرونده";
                combinsureance.WatermarkText = "نوع بیمه";
                combodoctor.WatermarkText = "نام دکتر";

            }
            catch
            { }
           
        }

        public string ConvertDate(string date1)
        {
            try
            {
                DateTime date2 = Convert.ToDateTime(date1);
                PersianCalendar c = new PersianCalendar();
                string date3 = c.GetYear(date2).ToString("####/") + c.GetMonth(date2).ToString("0#/") + c.GetDayOfMonth(date2).ToString("0#");
                return date3;
            }
            catch (Exception)
            {
                dateTimePickerX2.Focus();
                return m.myshowdialog("", "لطفا در ورود تاریخ دقت نمایید", "", false, false).ToString();

            }
        }
        public DateTime ConvertDate1(string date1)
        {

             int year1 = Convert.ToInt16(date1.Substring(0, 4));
         
          int month1 = Convert.ToInt16(date1.Substring(5, 2));
          
            int day1 = Convert.ToInt16(date1.Substring(8, 2));
          
            PersianCalendar c = new PersianCalendar();
             DateTime d1 = c.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
            //// DateTime date2 = Convert.ToDateTime(date1);
            // string s = d1.ToString("yyyy/MM/dd");
            // return Convert.ToDateTime(s);
       //  string s=   c.GetYear(Convert.ToDateTime(date1)).ToString("####/") + c.GetMonth(Convert.ToDateTime(date1)).ToString("0#/") + c.GetDayOfMonth(Convert.ToDateTime(date1)).ToString("0#");
            return d1;
        }


        #endregion
        private void PatiantForm_Load(object sender, EventArgs e)
        {
            try
            {
                groupBox4.Enabled = false;
                combodoctor.DataSource = dbll.ReadName();
                combodoctor.DisplayMember = "Name";
                combodoctor.ValueMember = "id";
                combodoctor.Focus();
                FillGrid();
                groupBox4.Enabled = false;

                AutoCompleteStringCollection CodeMeliis = new AutoCompleteStringCollection();
                foreach (var item in fbll.ReadCodeMelii())
                {
                    CodeMeliis.Add(item);
                }
                txtcode.AutoCompleteCustomSource = CodeMeliis;
            }
            catch
            {

            }
         

        }

        public string GetDate()
        {
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            string year = p.GetYear(DateTime.Now.Date).ToString();
            string month = p.GetMonth(DateTime.Now.Date).ToString();
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            string day = p.GetDayOfMonth(DateTime.Now.Date).ToString();
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            return year + "/" + month + "/" + day;
        }

      
        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                dataGridViewX1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                dataGridViewX1.Columns[0].Width = 50;

            }
            catch
            { }


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

    

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void symbolBox1_Click(object sender, EventArgs e)
        {
            try
            {
                d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));
                comboservice.DataSource = sbll.ServiceOfDoctor1(d.id);
                comboservice.DisplayMember = "NameOfService";
                comboservice.ValueMember = "id";
                txtcode.Enabled = true;
                txtcode.Focus();
              //  FillComboHozor();
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
          
                if (ubll.Access(u1, "پذیرش", 4))
                {
                   
                    res = m.myshowdialog("اخطار", "آیا از حذف اطمینان دارید؟", "", true, false);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        Patiant afterdel = new Patiant();
                        afterdel = pbll.Read(id);
                        dabll.NoabatAfterDel(afterdel.VisitDate, afterdel.Doctor.Name, afterdel.Hozor);
                        m.myshowdialog("حذف اطلاعات", pbll.Delete(id), "", false, false);

                    }
                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }

              

              
              
              FillGrid();
            }
            catch (Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }


        }

        private void symbolBox2_Click(object sender, EventArgs e)
        {
            try
            {
                
                Files fi = new Files();
                d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));

                fi = fbll.ReadMelli(txtcode.Text);

                if (fi != null)
                {
                    string date = c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#");
                 
                    n = nbll.ReadNobatReserve2(date, combodoctor.Text, txtcode.Text);
                    if(n!=null)
                    {
                       comboh.Text=n.Time1;
                    }

                    else
                    {
                        FillComboHozor();
                    }
                    // CombHozor.DataSource=nbll.Search()
                    labname.Text = fi.FullName;
                    labPhone.Text = fi.Phone;
                    txtsex.Text = fi.Sex;
                    combinsureance.Enabled = true;
                    dateTimePickerX2.Enabled = true;
                    comboservice.Enabled = true;
                    listBox1.Enabled = true;
                    comboh.Enabled = true;
                    checkPay.Enabled = true;
                    // combosex.Text = fi.Sex;
                }
                else
                {
                    FileForm ff = new FileForm();
                    ff.txtcode.Enabled = false;
                    ff.txtcode.Text = this.txtcode.Text;
                    ff.ShowDialog();
                }
                groupBox4.Enabled = true;
                combinsureance.DataSource = ibll.ReadName();
                combinsureance.DisplayMember = "NameOfInsutance";
                combinsureance.ValueMember = "id";


                //comboservice.DataSource = sbll.ReadALL();
                //comboservice.DisplayMember = "Name";
                //comboservice.ValueMember = "id";
            
             }
            catch(Exception)
            {
                m.myshowdialog("اخطار", "خطایی به وجود آمده است لطفا دوباره تلاش کنید", "", false, true);
            }


}

        private void ReadNobatReserve(Noabat n)
        {
            throw new NotImplementedException();
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // xuiButton3.ButtonImage = Properties.Resources.icons8_pencil_64;
        }


        private void symbolBox3_Click(object sender, EventArgs e)
        {
            try
            {
                ii = ibll.ReadN(combinsureance.GetItemText(combinsureance.SelectedItem));
                ss = sbll.ReadName(comboservice.GetItemText(comboservice.SelectedItem));

                Serviecess.Add(ss);
                listBox1.Items.Add(ss.NameOfService);
             //  Output3 = tbll.Read1(ii.NameOfInsutance, ss.NameOfService);
               outputdto1 = tbll.ReadView1(ii.NameOfInsutance, ss.NameOfService);
                ////dataGridView1.DataSource = outputdto;
                /////  output = tbll.ServiceTariffe(ii.NameOfInsutance, ss.NameOfService);
                
                if (outputdto1 == null)
                {
                    out1 = tbll.ReadView2(ss.NameOfService);

                    Listtarrefe1.Add(out1);
                    //   m.myshowdialog("", "برای این سرویس هیچ تعرفه ای وجود ندارد.", "", false, false);
                }
                else
                {

                    Listtarrefe1.Add(outputdto1);


                }
            }
            catch
            {

            }
           
            

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            //  d.id = dbll.Getid((combodoctor.GetItemText(combodoctor.SelectedItem)));

            try
            {
                MainWindow mf = (MainWindow)System.Windows.Application.Current.Windows.OfType<System.Windows.Window>().FirstOrDefault();
                User u1 = new User();
                u1 = mf.loggedinuser;
                UserBLL ubll = new UserBLL();

                if (ubll.Access(u1, "پذیرش", 2))
                {

                    d = dbll.ReadN(combodoctor.GetItemText(combodoctor.SelectedItem));
                    f = fbll.ReadName(txtcode.Text);
                    p.RegDate = c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#");
                    p.Hozor = comboh.Text;
                    p.VisitDate = ConvertDate(dateTimePickerX2.Text);

                    foreach (var item in Listtarrefe1)
                    {

                        Price = Price + item.OtherCost;
                    }
                    if (checkPay.Checked)
                    {
                        gh.Ischeck = true;


                    }
                    else
                    {
                        gh.Ischeck = false;
                    }

                    p.Price = Price;


                    //if (xuiButton3.Text == "ثبت اطلاعات")
                    //{
                    txtcode.Enabled = false;
                    if (pbll.Read(p, d, f))
                    {
                        if (listBox1.Text == null)
                        {
                            m.myshowdialog("اخطار", "لطفا نوع خدمات را وارد کنید.", "", false, false);
                        }
                        else
                        {
                            res = m.myshowdialog("ثبت اطلاعات", pbll.Create(p, ii, d, Serviecess, f, u1) + "آیا قصد چاپ قبض رادارید ؟", "", true, false);

                            ghbll.Create(gh, p, d, f);
                          //  dabll.Noabat(ConvertDate(dateTimePickerX2.Text), combodoctor.Text, comboh.Text);
                            dabll.reception(ConvertDate(dateTimePickerX2.Text), d, comboh.Text);
                            if (res == System.Windows.Forms.DialogResult.Yes)
                            {

                                StiReport sti = new StiReport();
                                sti.CacheAllData = true;
                                sti.Load(System.Windows.Forms.Application.StartupPath + @"//Reports//ReportGHabz.mrt");
                                sti.Dictionary.Variables["Doctor"].Value = combodoctor.Text;
                                sti.Dictionary.Variables["Date"].Value = ConvertDate(dateTimePickerX2.Text);
                                sti.Dictionary.Variables["Price"].Value = Price.ToString();
                                sti.RegBusinessObject("ghabz", Listtarrefe1);
                                sti.Render();
                                sti.Show();

                            }
                       
                        }

                    }
                    else
                    {
                        m.myshowdialog("اخطار", "اطلاعات تکراری میباشد.", "", false, false);
                    }


                    //}
                    //else
                    //{
                    //    MessageBox.Show(fbll.Update(f, id, d));
                    //     xuiButton3.Text = "ثبت اطلاعات";

                    // xuiButton3.ButtonImage = Properties.Resources.icons8_add_64;
                    //}

                }

                else
                {

                    m.myshowdialog("محدودیت دسترسی", "شما اجازه ورود به این قسمت را ندارید", "", false, true);
                }



        }
                catch (Exception)
                {
                    m.myshowdialog("اخطار", "لطفا در ورود اطلاعات دقت نمایید.", "", false, false);

                }
            FillGrid();
            EmptyControls();
           Serviecess.Clear();
            Listtarrefe1.Clear();
            Price = 0;
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        
        private void symbolBox4_Click(object sender, EventArgs e)
        {
          
            //foreach (var item in Serviecess)
            //{
              
                // sti.Dictionary.Variables["service"].Value = item.Name;
                // tbll.ServiceTariffe(i.Name, item.Name);
            //}
        }

     
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                //foreach (var item in Serviecess)
                //{
                //    string a = (item.NameOfService).ToString();
                //    if (a == listBox1.SelectedItem)
                //    {
                //        Serviecess.RemoveAt(Convert.ToInt32( a));
                //    }


                //}
                listBox1.Items.Remove(listBox1.SelectedItem);


            }
            catch { }
        
        }

    
        private void combodoctor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {


                if (e.KeyCode == Keys.Enter)
                {
                    symbolBox1_Click(sender, e);

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
                    symbolBox2_Click(sender, e);

                }
            }
            catch { }
        }

        private void comboservice_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    symbolBox3_Click(sender, e);

                }
            }
            catch { }
        }

        private void symbolBox1_KeyDown(object sender, KeyEventArgs e)
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

        private void dateTimePickerX2_MouseClick(object sender, MouseEventArgs e)
        {
            string dateNow = c.GetYear(DateTime.Now).ToString("####/") + c.GetMonth(DateTime.Now).ToString("0#/") + c.GetDayOfMonth(DateTime.Now).ToString("0#");
            string dateTimePicker = ConvertDate(dateTimePickerX2.Text);
            if (dateTimePicker != dateNow)
            {
                comboh.DataSource = dabll.Search(dateTimePicker, combodoctor.Text);
                comboh.DisplayMember = "Times1";
                comboh.ValueMember = "id";
            }
        }
    }
}
