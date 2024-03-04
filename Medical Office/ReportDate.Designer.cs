namespace Medical_Office
{
    partial class ReportDate
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDate));
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.combodoctor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dateTimePickerX1 = new BehComponents.DateTimePickerX();
            this.dateTimePickerX2 = new BehComponents.DateTimePickerX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart2.BackSecondaryColor = System.Drawing.Color.Navy;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.Maroon;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.AliceBlue;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea1.BorderColor = System.Drawing.Color.DodgerBlue;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(36, 49);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2.Name = "chart2";
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            this.chart2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.LightGray;
            series1.YValuesPerPoint = 4;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(669, 443);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "نتیجه گزارش";
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton5.ButtonImage = global::Medical_Office.Properties.Resources.mprovement;
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton5.ButtonText = "نمایش ";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.xuiButton5.ClickTextColor = System.Drawing.Color.LightGreen;
            this.xuiButton5.CornerRadius = 10;
            this.xuiButton5.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton5.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(21, 254);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(198, 46);
            this.xuiButton5.TabIndex = 58;
            this.xuiButton5.TextColor = System.Drawing.Color.Black;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.Click += new System.EventHandler(this.xuiButton5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.xuiButton5);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(711, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(240, 320);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(59, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 24);
            this.radioButton1.TabIndex = 60;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "تعداد پذیرش توسط هر کاربر";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(165, 131);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 24);
            this.radioButton4.TabIndex = 59;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "درآمد";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(198, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "تعداد بیماران پذیرش شده هر پزشک";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(711, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(240, 122);
            this.groupBox1.TabIndex = 57;
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
            this.labelX3.Location = new System.Drawing.Point(167, 27);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX3.TabIndex = 61;
            this.labelX3.Text = "نام پزشک";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.combodoctor.Location = new System.Drawing.Point(17, 22);
            this.combodoctor.Name = "combodoctor";
            this.combodoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combodoctor.Size = new System.Drawing.Size(133, 28);
            this.combodoctor.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.combodoctor.TabIndex = 60;
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
            this.labelX2.Location = new System.Drawing.Point(169, 87);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX2.TabIndex = 54;
            this.labelX2.Text = "تا تاریخ";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.dateTimePickerX1.Location = new System.Drawing.Point(17, 57);
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
            this.dateTimePickerX2.Location = new System.Drawing.Point(17, 87);
            this.dateTimePickerX2.Margin = new System.Windows.Forms.Padding(14, 46, 14, 46);
            this.dateTimePickerX2.Name = "dateTimePickerX2";
            this.dateTimePickerX2.RightToLeftLayout = true;
            this.dateTimePickerX2.ShowClearButton = false;
            this.dateTimePickerX2.Size = new System.Drawing.Size(135, 24);
            this.dateTimePickerX2.TabIndex = 51;
            this.dateTimePickerX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateTimePickerX2.TextWhenClearButtonClicked = "تاریخ نوبت دهی";
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
            this.labelX1.Location = new System.Drawing.Point(169, 60);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX1.TabIndex = 53;
            this.labelX1.Text = "از تاریخ";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Medical_Office.Properties.Resources.icons8_cancel_256__2_;
            this.pictureBox1.Location = new System.Drawing.Point(957, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(37, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(182, 24);
            this.radioButton3.TabIndex = 61;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "تعداد پذیرش شده در تاریخ امروز";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ReportDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart2);
            this.Font = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمودار";
            this.Load += new System.EventHandler(this.ReportDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private XanderUI.XUIButton xuiButton5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private BehComponents.DateTimePickerX dateTimePickerX1;
        private BehComponents.DateTimePickerX dateTimePickerX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx combodoctor;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}