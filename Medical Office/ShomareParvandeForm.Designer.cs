namespace Medical_Office
{
    partial class ShomareParvandeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShomareParvandeForm));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.combodoctor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.symbolBox2 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.txtfile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.labelX1.Location = new System.Drawing.Point(205, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX1.TabIndex = 40;
            this.labelX1.Text = "نام پزشک";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // combodoctor
            // 
            this.combodoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combodoctor.DisplayMember = "Text";
            this.combodoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combodoctor.Enabled = false;
            this.combodoctor.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodoctor.FormattingEnabled = true;
            this.combodoctor.ItemHeight = 22;
            this.combodoctor.Location = new System.Drawing.Point(45, 40);
            this.combodoctor.Name = "combodoctor";
            this.combodoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combodoctor.Size = new System.Drawing.Size(154, 28);
            this.combodoctor.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.combodoctor.TabIndex = 39;
            this.combodoctor.WatermarkFont = new System.Drawing.Font("IRANSansWeb", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodoctor.WatermarkText = "نوع بیمه";
            this.combodoctor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combodoctor_KeyDown);
            // 
            // txtcode
            // 
            this.txtcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtcode.Location = new System.Drawing.Point(357, 40);
            this.txtcode.MaxLength = 11;
            this.txtcode.Name = "txtcode";
            this.txtcode.PreventEnterBeep = true;
            this.txtcode.Size = new System.Drawing.Size(206, 33);
            this.txtcode.TabIndex = 41;
            this.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcode.WatermarkText = "کدملی";
            this.txtcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcode_KeyDown);
            this.txtcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcode_KeyPress);
            // 
            // symbolBox2
            // 
            // 
            // 
            // 
            this.symbolBox2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.symbolBox2.Location = new System.Drawing.Point(320, 40);
            this.symbolBox2.Name = "symbolBox2";
            this.symbolBox2.Size = new System.Drawing.Size(40, 28);
            this.symbolBox2.Symbol = "";
            this.symbolBox2.TabIndex = 42;
            this.symbolBox2.Text = "symbolBox2";
            this.symbolBox2.Click += new System.EventHandler(this.symbolBox2_Click);
            // 
            // txtfile
            // 
            // 
            // 
            // 
            this.txtfile.Border.Class = "ItemPanel";
            this.txtfile.Border.CornerDiameter = 9;
            this.txtfile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtfile.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtfile.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtfile.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtfile.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtfile.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfile.Enabled = false;
            this.txtfile.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfile.Location = new System.Drawing.Point(183, 100);
            this.txtfile.Name = "txtfile";
            this.txtfile.PreventEnterBeep = true;
            this.txtfile.Size = new System.Drawing.Size(206, 33);
            this.txtfile.TabIndex = 44;
            this.txtfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfile.WatermarkText = "شماره پرونده";
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
            this.labelX2.Location = new System.Drawing.Point(569, 45);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.labelX2.TabIndex = 45;
            this.labelX2.Text = "کدملی";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = global::Medical_Office.Properties.Resources.icons8_add_64;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "ایجاد شماره پرونده";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.LightGreen;
            this.xuiButton3.CornerRadius = 10;
            this.xuiButton3.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(183, 149);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(207, 36);
            this.xuiButton3.TabIndex = 46;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            this.xuiButton3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xuiButton3_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Medical_Office.Properties.Resources.icons8_cancel_256__2_;
            this.pictureBox1.Location = new System.Drawing.Point(698, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.combodoctor);
            this.groupBox4.Controls.Add(this.labelX1);
            this.groupBox4.Controls.Add(this.xuiButton3);
            this.groupBox4.Controls.Add(this.txtcode);
            this.groupBox4.Controls.Add(this.labelX2);
            this.groupBox4.Controls.Add(this.symbolBox2);
            this.groupBox4.Controls.Add(this.txtfile);
            this.groupBox4.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(44, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(648, 223);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "کد ملی و نام دکتر را وارد کنید تا شماره پرونده ایجاد شود";
            // 
            // ShomareParvandeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(791, 337);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShomareParvandeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم شماره پرونده";
            this.Load += new System.EventHandler(this.ShomareParvandeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtcode;
        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtfile;
        public DevComponents.DotNetBar.Controls.ComboBoxEx combodoctor;
        private DevComponents.DotNetBar.LabelX labelX2;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}