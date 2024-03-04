namespace Medical_Office
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelWelcom = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // circularProgress1
            // 
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(143, 73);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.PieBorderDark = System.Drawing.Color.Green;
            this.circularProgress1.PieBorderLight = System.Drawing.Color.Green;
            this.circularProgress1.ProgressColor = System.Drawing.Color.Blue;
            this.circularProgress1.Size = new System.Drawing.Size(104, 50);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelWelcom
            // 
            this.labelWelcom.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelWelcom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelWelcom.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcom.Location = new System.Drawing.Point(89, 31);
            this.labelWelcom.Name = "labelWelcom";
            this.labelWelcom.Size = new System.Drawing.Size(255, 44);
            this.labelWelcom.TabIndex = 1;
            this.labelWelcom.Text = "به نرم افزار مدیریت مطب خوش آمدید";
            this.labelWelcom.Click += new System.EventHandler(this.labelWelcom_Click);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 154);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.labelWelcom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private DevComponents.DotNetBar.LabelX labelWelcom;
    }
}