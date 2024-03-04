namespace Medical_Office
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combodoctor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dateTimePickerX1 = new BehComponents.DateTimePickerX();
            this.dateTimePickerX2 = new BehComponents.DateTimePickerX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewX1.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.Size = new System.Drawing.Size(649, 419);
            this.dataGridViewX1.TabIndex = 18;
            this.dataGridViewX1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewX1_CellFormatting);
            // 
            // radif
            // 
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            // 
            // combodoctor
            // 
            this.combodoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combodoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.combodoctor.DisplayMember = "Text";
            this.combodoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combodoctor.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodoctor.FormattingEnabled = true;
            this.combodoctor.ItemHeight = 22;
            this.combodoctor.Location = new System.Drawing.Point(6, 26);
            this.combodoctor.Name = "combodoctor";
            this.combodoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combodoctor.Size = new System.Drawing.Size(133, 28);
            this.combodoctor.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.combodoctor.TabIndex = 20;
            this.combodoctor.WatermarkFont = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodoctor.WatermarkText = "نام پزشک";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.labelX2.BackgroundStyle.CornerDiameter = 10;
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.labelX2.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(158, 97);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX2.TabIndex = 54;
            this.labelX2.Text = "تا تاریخ";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.labelX1.BackgroundStyle.CornerDiameter = 10;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.labelX1.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(158, 70);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX1.TabIndex = 53;
            this.labelX1.Text = "از تاریخ";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dateTimePickerX1
            // 
            this.dateTimePickerX1.AnchorSize = new System.Drawing.Size(133, 24);
            this.dateTimePickerX1.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerX1.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerX1.CalendarDayRectTickness = 2F;
            this.dateTimePickerX1.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerX1.CalendarDaysFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX1.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerX1.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX1.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX1.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX1.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX1.CalendarShowToday = true;
            this.dateTimePickerX1.CalendarShowTodayRect = true;
            this.dateTimePickerX1.CalendarShowToolTips = false;
            this.dateTimePickerX1.CalendarShowTrailing = true;
            this.dateTimePickerX1.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX1.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX1.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX1.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarTitleFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarTodayFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX1.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerX1.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX1.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerX1.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX1.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX1.CalendarWeekDaysFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX1.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerX1.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX1.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX1.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX1.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX1.ClearButtonImage")));
            this.dateTimePickerX1.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX1.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX1.ClearButtonText = "";
            this.dateTimePickerX1.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.ClearButtonToolTip = "";
            this.dateTimePickerX1.ClearButtonWidth = 17;
            this.dateTimePickerX1.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX1.CustomFormat = "";
            this.dateTimePickerX1.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX1.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX1.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX1.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX1.ForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX1.Format = BehComponents.DateTimePickerX.FormatDate.Short;
            this.dateTimePickerX1.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX1.Location = new System.Drawing.Point(6, 67);
            this.dateTimePickerX1.Margin = new System.Windows.Forms.Padding(14, 46, 14, 46);
            this.dateTimePickerX1.Name = "dateTimePickerX1";
            this.dateTimePickerX1.RightToLeftLayout = true;
            this.dateTimePickerX1.ShowClearButton = false;
            this.dateTimePickerX1.Size = new System.Drawing.Size(133, 24);
            this.dateTimePickerX1.TabIndex = 52;
            this.dateTimePickerX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX1.TextWhenClearButtonClicked = "تاریخ نوبت دهی";
            // 
            // dateTimePickerX2
            // 
            this.dateTimePickerX2.AnchorSize = new System.Drawing.Size(135, 24);
            this.dateTimePickerX2.BackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerX2.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dateTimePickerX2.CalendarDayRectTickness = 2F;
            this.dateTimePickerX2.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dateTimePickerX2.CalendarDaysFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX2.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerX2.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dateTimePickerX2.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dateTimePickerX2.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dateTimePickerX2.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dateTimePickerX2.CalendarShowToday = true;
            this.dateTimePickerX2.CalendarShowTodayRect = true;
            this.dateTimePickerX2.CalendarShowToolTips = false;
            this.dateTimePickerX2.CalendarShowTrailing = true;
            this.dateTimePickerX2.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dateTimePickerX2.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX2.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dateTimePickerX2.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dateTimePickerX2.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX2.CalendarTitleFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX2.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX2.CalendarTodayFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX2.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dateTimePickerX2.CalendarTodayRectTickness = 2F;
            this.dateTimePickerX2.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dateTimePickerX2.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dateTimePickerX2.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dateTimePickerX2.CalendarWeekDaysFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX2.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerX2.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dateTimePickerX2.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX2.ClearButtonBackColor = System.Drawing.Color.White;
            this.dateTimePickerX2.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerX2.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dateTimePickerX2.ClearButtonImage")));
            this.dateTimePickerX2.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dateTimePickerX2.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dateTimePickerX2.ClearButtonText = "";
            this.dateTimePickerX2.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.ClearButtonToolTip = "";
            this.dateTimePickerX2.ClearButtonWidth = 17;
            this.dateTimePickerX2.ClearDateTimeWhenDownDeleteKey = true;
            this.dateTimePickerX2.CustomFormat = "";
            this.dateTimePickerX2.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dateTimePickerX2.DropDownClosedWhenClickOnDays = false;
            this.dateTimePickerX2.DropDownClosedWhenSelectedDateChanged = false;
            this.dateTimePickerX2.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerX2.ForeColor = System.Drawing.Color.Black;
            this.dateTimePickerX2.Format = BehComponents.DateTimePickerX.FormatDate.Short;
            this.dateTimePickerX2.Format4Binding = "yyyy/MM/dd";
            this.dateTimePickerX2.Location = new System.Drawing.Point(6, 97);
            this.dateTimePickerX2.Margin = new System.Windows.Forms.Padding(14, 46, 14, 46);
            this.dateTimePickerX2.Name = "dateTimePickerX2";
            this.dateTimePickerX2.RightToLeftLayout = true;
            this.dateTimePickerX2.ShowClearButton = false;
            this.dateTimePickerX2.Size = new System.Drawing.Size(135, 24);
            this.dateTimePickerX2.TabIndex = 51;
            this.dateTimePickerX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.TextWhenClearButtonClicked = "تاریخ نوبت دهی";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.combodoctor);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.dateTimePickerX1);
            this.groupBox1.Controls.Add(this.dateTimePickerX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(724, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(240, 132);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.labelX3.BackgroundStyle.CornerDiameter = 10;
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.labelX3.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(156, 31);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX3.TabIndex = 59;
            this.labelX3.Text = "نام پزشک";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xuiButton5);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(724, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(240, 319);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton5.ButtonImage = global::Medical_Office.Properties.Resources.printer;
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton5.ButtonText = "نمایش و چاپ اطلاعات";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.xuiButton5.ClickTextColor = System.Drawing.Color.LightGreen;
            this.xuiButton5.CornerRadius = 10;
            this.xuiButton5.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton5.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(23, 267);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(198, 41);
            this.xuiButton5.TabIndex = 59;
            this.xuiButton5.TextColor = System.Drawing.Color.Black;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.Click += new System.EventHandler(this.xuiButton5_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "لیست بیماران براساس نام پزشک";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "لیست تمامی بیماران کلینیک";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewX1);
            this.groupBox3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(57, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(661, 445);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Medical_Office.Properties.Resources.icons8_cancel_256__2_;
            this.pictureBox1.Location = new System.Drawing.Point(970, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست بیماران";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private DevComponents.DotNetBar.Controls.ComboBoxEx combodoctor;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private BehComponents.DateTimePickerX dateTimePickerX1;
        private BehComponents.DateTimePickerX dateTimePickerX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.LabelX labelX3;
        private XanderUI.XUIButton xuiButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}