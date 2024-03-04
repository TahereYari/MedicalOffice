namespace Medical_Office
{
    partial class UCLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.txtusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxX1);
            this.panel2.Controls.Add(this.buttonX2);
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(31, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 245);
            this.panel2.TabIndex = 8;
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxX1.Location = new System.Drawing.Point(53, 141);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxX1.Size = new System.Drawing.Size(158, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 7;
            this.checkBoxX1.Text = "مرا به خاطر بسپار";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(101, 179);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX2.Size = new System.Drawing.Size(122, 31);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "ورود به حساب";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // txtusername
            // 
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtusername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtusername.Border.Class = "ItemPanel";
            this.txtusername.Border.CornerDiameter = 9;
            this.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtusername.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtusername.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtusername.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtusername.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtusername.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.DisabledBackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(50, 63);
            this.txtusername.Name = "txtusername";
            this.txtusername.PreventEnterBeep = true;
            this.txtusername.Size = new System.Drawing.Size(250, 33);
            this.txtusername.TabIndex = 0;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.WatermarkText = "نام کاربری";
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPass.Border.Class = "ItemPanel";
            this.txtPass.Border.CornerDiameter = 9;
            this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPass.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPass.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPass.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPass.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPass.Border.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.DisabledBackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(50, 102);
            this.txtPass.Name = "txtPass";
            this.txtPass.PreventEnterBeep = true;
            this.txtPass.Size = new System.Drawing.Size(250, 33);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WatermarkText = "رمز عبور";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "برای ورود به حساب کاربری اطلاعات خود را وارد نمایید";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Office.Properties.Resources.icons8_user_96;
            this.pictureBox1.Location = new System.Drawing.Point(120, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(425, 526);
            this.Load += new System.EventHandler(this.UCLogin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
    }
}
