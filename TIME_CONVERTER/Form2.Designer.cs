namespace TIME_CONVERTER
{
    partial class OFFLINEMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OFFLINEMode));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToSystemTimeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeZoneDomian = new System.Windows.Forms.DomainUpDown();
            this.ConvertedTime = new System.Windows.Forms.Label();
            this.UserTimeZoneUpDown = new System.Windows.Forms.DomainUpDown();
            this.HourUpDown = new System.Windows.Forms.NumericUpDown();
            this.minUpDown = new System.Windows.Forms.NumericUpDown();
            this.amPm = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(314, 660);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 118);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToSystemTimeModeToolStripMenuItem});
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // backToSystemTimeModeToolStripMenuItem
            // 
            this.backToSystemTimeModeToolStripMenuItem.Name = "backToSystemTimeModeToolStripMenuItem";
            this.backToSystemTimeModeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.backToSystemTimeModeToolStripMenuItem.Text = "Back To System Time Mode";
            this.backToSystemTimeModeToolStripMenuItem.Click += new System.EventHandler(this.backToSystemTimeModeToolStripMenuItem_Click);
            // 
            // TimeZoneDomian
            // 
            this.TimeZoneDomian.BackColor = System.Drawing.SystemColors.Window;
            this.TimeZoneDomian.Items.Add("EST");
            this.TimeZoneDomian.Items.Add("PST");
            this.TimeZoneDomian.Items.Add("CST");
            this.TimeZoneDomian.Items.Add("HST");
            this.TimeZoneDomian.Items.Add("MST");
            this.TimeZoneDomian.Location = new System.Drawing.Point(893, 295);
            this.TimeZoneDomian.Name = "TimeZoneDomian";
            this.TimeZoneDomian.Size = new System.Drawing.Size(125, 23);
            this.TimeZoneDomian.TabIndex = 4;
            this.TimeZoneDomian.Text = "TimeZoneDomian";
            // 
            // ConvertedTime
            // 
            this.ConvertedTime.Location = new System.Drawing.Point(745, 324);
            this.ConvertedTime.Name = "ConvertedTime";
            this.ConvertedTime.Size = new System.Drawing.Size(420, 91);
            this.ConvertedTime.TabIndex = 5;
            this.ConvertedTime.Text = "label1";
            this.ConvertedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTimeZoneUpDown
            // 
            this.UserTimeZoneUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.UserTimeZoneUpDown.Items.Add("EST");
            this.UserTimeZoneUpDown.Items.Add("PST");
            this.UserTimeZoneUpDown.Items.Add("CST");
            this.UserTimeZoneUpDown.Items.Add("HST");
            this.UserTimeZoneUpDown.Items.Add("MST");
            this.UserTimeZoneUpDown.Location = new System.Drawing.Point(251, 295);
            this.UserTimeZoneUpDown.Name = "UserTimeZoneUpDown";
            this.UserTimeZoneUpDown.Size = new System.Drawing.Size(125, 23);
            this.UserTimeZoneUpDown.TabIndex = 6;
            this.UserTimeZoneUpDown.Text = "User Time Zone";
            // 
            // HourUpDown
            // 
            this.HourUpDown.Location = new System.Drawing.Point(188, 324);
            this.HourUpDown.Name = "HourUpDown";
            this.HourUpDown.Size = new System.Drawing.Size(120, 23);
            this.HourUpDown.TabIndex = 7;
            this.HourUpDown.ValueChanged += new System.EventHandler(this.TimeZoneConversionMethod);
            // 
            // minUpDown
            // 
            this.minUpDown.Location = new System.Drawing.Point(314, 324);
            this.minUpDown.Name = "minUpDown";
            this.minUpDown.Size = new System.Drawing.Size(120, 23);
            this.minUpDown.TabIndex = 8;
            this.minUpDown.ValueChanged += new System.EventHandler(this.TimeZoneConversionMethod);
            // 
            // amPm
            // 
            this.amPm.Items.Add("12");
            this.amPm.Items.Add("24");
            this.amPm.Location = new System.Drawing.Point(443, 324);
            this.amPm.Name = "amPm";
            this.amPm.Size = new System.Drawing.Size(74, 23);
            this.amPm.TabIndex = 9;
            this.amPm.Text = "12";
            this.amPm.TextChanged += new System.EventHandler(this.TimeZoneConversionMethod);
            // 
            // OFFLINEMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1260, 790);
            this.Controls.Add(this.amPm);
            this.Controls.Add(this.minUpDown);
            this.Controls.Add(this.HourUpDown);
            this.Controls.Add(this.UserTimeZoneUpDown);
            this.Controls.Add(this.ConvertedTime);
            this.Controls.Add(this.TimeZoneDomian);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OFFLINEMode";
            this.Text = "Non System Time Mode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modesToolStripMenuItem;
        private ToolStripMenuItem backToSystemTimeModeToolStripMenuItem;
        private DomainUpDown TimeZoneDomian;
        private Label ConvertedTime;
        private DomainUpDown UserTimeZoneUpDown;
        private NumericUpDown HourUpDown;
        private NumericUpDown minUpDown;
        private DomainUpDown amPm;
    }
}