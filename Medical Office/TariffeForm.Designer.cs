namespace Medical_Office
{
    partial class TariffeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariffeForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboservices = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cominsure = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtpartionO = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpartionI = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxX1);
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(54, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 344);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "ItemPanel";
            this.textBoxX1.Border.CornerDiameter = 9;
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX1.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX1.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX1.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX1.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX1.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(6, 17);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(636, 33);
            this.textBoxX1.TabIndex = 38;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX1.WatermarkText = "جستجو براساس نام  بیمه یا نوع خدمات";
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewX1.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(636, 282);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            this.dataGridViewX1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewX1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ردیف";
            this.Column1.Name = "Column1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboservices);
            this.groupBox1.Controls.Add(this.cominsure);
            this.groupBox1.Controls.Add(this.textBoxX2);
            this.groupBox1.Controls.Add(this.xuiButton3);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.txtpartionO);
            this.groupBox1.Controls.Add(this.txtpartionI);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(54, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(648, 167);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  مشخصات";
            // 
            // comboservices
            // 
            this.comboservices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboservices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboservices.DisplayMember = "Text";
            this.comboservices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboservices.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboservices.FormattingEnabled = true;
            this.comboservices.ItemHeight = 22;
            this.comboservices.Location = new System.Drawing.Point(18, 39);
            this.comboservices.Name = "comboservices";
            this.comboservices.Size = new System.Drawing.Size(217, 28);
            this.comboservices.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.comboservices.TabIndex = 57;
            this.comboservices.WatermarkFont = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboservices.WatermarkText = "خدمات";
            this.comboservices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboservices_KeyDown_1);
            // 
            // cominsure
            // 
            this.cominsure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cominsure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cominsure.DisplayMember = "Text";
            this.cominsure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cominsure.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cominsure.FormattingEnabled = true;
            this.cominsure.ItemHeight = 22;
            this.cominsure.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cominsure.Location = new System.Drawing.Point(331, 39);
            this.cominsure.Name = "cominsure";
            this.cominsure.Size = new System.Drawing.Size(226, 28);
            this.cominsure.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cominsure.TabIndex = 56;
            this.cominsure.WatermarkFont = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cominsure.WatermarkText = "نوع بیمه";
            this.cominsure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cominsure_KeyDown_1);
            // 
            // comboItem1
            // 
            this.comboItem1.FontSize = 9F;
            this.comboItem1.Text = "زن";
            this.comboItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem2
            // 
            this.comboItem2.FontSize = 9F;
            this.comboItem2.Text = "مرد";
            this.comboItem2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "ItemPanel";
            this.textBoxX2.Border.CornerDiameter = 9;
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX2.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX2.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX2.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX2.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX2.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX2.Location = new System.Drawing.Point(18, 73);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(281, 33);
            this.textBoxX2.TabIndex = 3;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX2.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBoxX2.WatermarkText = "سهم بیمار";
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            this.textBoxX2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxX2_KeyDown);
            this.textBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX2_KeyPress);
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = global::Medical_Office.Properties.Resources.icons8_add_64;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "ثبت اطلاعات";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.LightGreen;
            this.xuiButton3.CornerRadius = 10;
            this.xuiButton3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(18, 115);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(145, 36);
            this.xuiButton3.TabIndex = 5;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            this.xuiButton3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xuiButton3_KeyDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.labelX1.BackgroundStyle.CornerDiameter = 10;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.labelX1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(250, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "نوع خدمات";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtpartionO
            // 
            // 
            // 
            // 
            this.txtpartionO.Border.Class = "ItemPanel";
            this.txtpartionO.Border.CornerDiameter = 9;
            this.txtpartionO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionO.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionO.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionO.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionO.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionO.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartionO.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartionO.Location = new System.Drawing.Point(331, 115);
            this.txtpartionO.Name = "txtpartionO";
            this.txtpartionO.PreventEnterBeep = true;
            this.txtpartionO.Size = new System.Drawing.Size(297, 33);
            this.txtpartionO.TabIndex = 4;
            this.txtpartionO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpartionO.WatermarkText = "سایر هزینه ها";
            this.txtpartionO.TextChanged += new System.EventHandler(this.txtpartionO_TextChanged);
            this.txtpartionO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpartionO_KeyDown);
            this.txtpartionO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpartionO_KeyPress);
            // 
            // txtpartionI
            // 
            // 
            // 
            // 
            this.txtpartionI.Border.Class = "ItemPanel";
            this.txtpartionI.Border.CornerDiameter = 9;
            this.txtpartionI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionI.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionI.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionI.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionI.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtpartionI.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartionI.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartionI.Location = new System.Drawing.Point(331, 73);
            this.txtpartionI.Name = "txtpartionI";
            this.txtpartionI.PreventEnterBeep = true;
            this.txtpartionI.Size = new System.Drawing.Size(297, 33);
            this.txtpartionI.TabIndex = 2;
            this.txtpartionI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpartionI.WatermarkText = "سهم بیمه";
            this.txtpartionI.TextChanged += new System.EventHandler(this.txtpartionI_TextChanged);
            this.txtpartionI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpartionI_KeyDown);
            this.txtpartionI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpartionI_KeyPress);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.labelX2.BackgroundStyle.CornerDiameter = 10;
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.labelX2.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(563, 44);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "نوع بیمه";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 52);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::Medical_Office.Properties.Resources.edit;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::Medical_Office.Properties.Resources.delete__2_;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Medical_Office.Properties.Resources.icons8_cancel_256__2_;
            this.pictureBox1.Location = new System.Drawing.Point(708, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TariffeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TariffeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم تعرفه";
            this.Load += new System.EventHandler(this.TariffeForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpartionO;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpartionI;
        private DevComponents.DotNetBar.LabelX labelX1;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cominsure;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboservices;
    }
}