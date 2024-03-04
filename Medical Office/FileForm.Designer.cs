namespace Medical_Office
{
    partial class FileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.txtcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtphone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.combosex = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
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
            this.groupBox2.Location = new System.Drawing.Point(51, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 295);
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
            this.textBoxX1.Location = new System.Drawing.Point(6, 19);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(742, 33);
            this.textBoxX1.TabIndex = 14;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX1.WatermarkText = "جستجو براساس کد ملی  بیمار";
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
            this.radif});
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
            this.dataGridViewX1.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(742, 231);
            this.dataGridViewX1.TabIndex = 13;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            this.dataGridViewX1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewX1_CellFormatting);
            // 
            // radif
            // 
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            // 
            // comboItem3
            // 
            this.comboItem3.FontSize = 9F;
            this.comboItem3.Text = "زن";
            this.comboItem3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xuiButton3);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.combosex);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(51, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(754, 151);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  مشخصات بیمار";
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = global::Medical_Office.Properties.Resources.icons8_add_64;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "ثبت اطلاعات";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.LightGreen;
            this.xuiButton3.CornerRadius = 10;
            this.xuiButton3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(125, 93);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(145, 36);
            this.xuiButton3.TabIndex = 3;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            this.xuiButton3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xuiButton3_KeyDown);
            // 
            // txtcode
            // 
            // 
            // 
            // 
            this.txtcode.Border.Class = "ItemPanel";
            this.txtcode.Border.CornerDiameter = 9;
            this.txtcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtcode.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtcode.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtcode.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtcode.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtcode.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(125, 22);
            this.txtcode.MaxLength = 11;
            this.txtcode.Name = "txtcode";
            this.txtcode.PreventEnterBeep = true;
            this.txtcode.Size = new System.Drawing.Size(242, 33);
            this.txtcode.TabIndex = 1;
            this.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcode.WatermarkText = "کدملی";
            this.txtcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcode_KeyDown);
            this.txtcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcode_KeyPress);
            // 
            // txtphone
            // 
            // 
            // 
            // 
            this.txtphone.Border.Class = "ItemPanel";
            this.txtphone.Border.CornerDiameter = 9;
            this.txtphone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtphone.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtphone.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtphone.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtphone.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtphone.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(388, 65);
            this.txtphone.MaxLength = 11;
            this.txtphone.Name = "txtphone";
            this.txtphone.PreventEnterBeep = true;
            this.txtphone.Size = new System.Drawing.Size(242, 33);
            this.txtphone.TabIndex = 2;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtphone.WatermarkText = "شماره تلفن";
            this.txtphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtphone_KeyDown);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.BorderBottomColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemExpandedText;
            this.labelX3.BackgroundStyle.CornerDiameter = 10;
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.labelX3.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(306, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "جنسیت";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.Border.Class = "ItemPanel";
            this.txtname.Border.CornerDiameter = 9;
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtname.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtname.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtname.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtname.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtname.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(388, 22);
            this.txtname.Name = "txtname";
            this.txtname.PreventEnterBeep = true;
            this.txtname.Size = new System.Drawing.Size(242, 33);
            this.txtname.TabIndex = 0;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.WatermarkText = "نام و نام خانوادگی";
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // combosex
            // 
            this.combosex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combosex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combosex.DisplayMember = "Text";
            this.combosex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combosex.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosex.FormattingEnabled = true;
            this.combosex.ItemHeight = 22;
            this.combosex.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4});
            this.combosex.Location = new System.Drawing.Point(125, 59);
            this.combosex.Name = "combosex";
            this.combosex.Size = new System.Drawing.Size(175, 28);
            this.combosex.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.combosex.TabIndex = 3;
            this.combosex.WatermarkFont = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosex.WatermarkText = "جنسیت";
            this.combosex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combosex_KeyDown);
            // 
            // comboItem4
            // 
            this.comboItem4.FontSize = 9F;
            this.comboItem4.Text = "مرد";
            this.comboItem4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem4.TextLineAlignment = System.Drawing.StringAlignment.Center;
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
            this.pictureBox1.Location = new System.Drawing.Point(811, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بیماران";
            this.Load += new System.EventHandler(this.FileForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.Editors.ComboItem comboItem3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtphone;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        private DevComponents.DotNetBar.Controls.ComboBoxEx combosex;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        public DevComponents.DotNetBar.Controls.TextBoxX txtcode;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}