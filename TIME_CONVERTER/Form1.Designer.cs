namespace TIME_CONVERTER
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentUserTime = new System.Windows.Forms.Label();
            this.PSTButton = new System.Windows.Forms.Button();
            this.newTimeZone = new System.Windows.Forms.Label();
            this.UTCTime = new System.Windows.Forms.Label();
            this.ESTButton = new System.Windows.Forms.Button();
            this.CSTButton = new System.Windows.Forms.Button();
            this.MSTButton = new System.Windows.Forms.Button();
            this.ASTButton = new System.Windows.Forms.Button();
            this.HSTButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonSystemTimeModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentUserTime
            // 
            this.currentUserTime.BackColor = System.Drawing.Color.Transparent;
            this.currentUserTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentUserTime.Location = new System.Drawing.Point(480, 24);
            this.currentUserTime.Name = "currentUserTime";
            this.currentUserTime.Size = new System.Drawing.Size(313, 48);
            this.currentUserTime.TabIndex = 1;
            this.currentUserTime.Text = "Click me to get system loacal time";
            this.currentUserTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentUserTime.TextChanged += new System.EventHandler(this.GetUserTime);
            this.currentUserTime.Click += new System.EventHandler(this.GetUserTime);
            // 
            // PSTButton
            // 
            this.PSTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PSTButton.Location = new System.Drawing.Point(200, 181);
            this.PSTButton.Name = "PSTButton";
            this.PSTButton.Size = new System.Drawing.Size(125, 38);
            this.PSTButton.TabIndex = 2;
            this.PSTButton.Text = "PST";
            this.PSTButton.UseVisualStyleBackColor = false;
            this.PSTButton.Click += new System.EventHandler(this.PSTButton_Click);
            // 
            // newTimeZone
            // 
            this.newTimeZone.BackColor = System.Drawing.Color.White;
            this.newTimeZone.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newTimeZone.Location = new System.Drawing.Point(200, 280);
            this.newTimeZone.Name = "newTimeZone";
            this.newTimeZone.Size = new System.Drawing.Size(780, 120);
            this.newTimeZone.TabIndex = 6;
            this.newTimeZone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UTCTime
            // 
            this.UTCTime.BackColor = System.Drawing.Color.Transparent;
            this.UTCTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UTCTime.Location = new System.Drawing.Point(954, 38);
            this.UTCTime.Name = "UTCTime";
            this.UTCTime.Size = new System.Drawing.Size(226, 34);
            this.UTCTime.TabIndex = 8;
            this.UTCTime.Text = "UTCTime";
            this.UTCTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ESTButton
            // 
            this.ESTButton.BackColor = System.Drawing.Color.Red;
            this.ESTButton.Location = new System.Drawing.Point(855, 181);
            this.ESTButton.Name = "ESTButton";
            this.ESTButton.Size = new System.Drawing.Size(125, 38);
            this.ESTButton.TabIndex = 9;
            this.ESTButton.Text = "EST";
            this.ESTButton.UseVisualStyleBackColor = false;
            this.ESTButton.Click += new System.EventHandler(this.ESTButton_Click);
            // 
            // CSTButton
            // 
            this.CSTButton.BackColor = System.Drawing.Color.Yellow;
            this.CSTButton.Location = new System.Drawing.Point(462, 181);
            this.CSTButton.Name = "CSTButton";
            this.CSTButton.Size = new System.Drawing.Size(125, 38);
            this.CSTButton.TabIndex = 10;
            this.CSTButton.Text = "CST";
            this.CSTButton.UseVisualStyleBackColor = false;
            this.CSTButton.Click += new System.EventHandler(this.CSTButton_Click);
            // 
            // MSTButton
            // 
            this.MSTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MSTButton.Location = new System.Drawing.Point(331, 181);
            this.MSTButton.Name = "MSTButton";
            this.MSTButton.Size = new System.Drawing.Size(125, 38);
            this.MSTButton.TabIndex = 11;
            this.MSTButton.Text = "MST";
            this.MSTButton.UseVisualStyleBackColor = false;
            this.MSTButton.Click += new System.EventHandler(this.MSTButton_Click);
            // 
            // ASTButton
            // 
            this.ASTButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ASTButton.Location = new System.Drawing.Point(593, 181);
            this.ASTButton.Name = "ASTButton";
            this.ASTButton.Size = new System.Drawing.Size(125, 38);
            this.ASTButton.TabIndex = 12;
            this.ASTButton.Text = "AST";
            this.ASTButton.UseVisualStyleBackColor = false;
            this.ASTButton.Click += new System.EventHandler(this.ASTButton_Click);
            // 
            // HSTButton
            // 
            this.HSTButton.BackColor = System.Drawing.Color.Fuchsia;
            this.HSTButton.ForeColor = System.Drawing.Color.Black;
            this.HSTButton.Location = new System.Drawing.Point(724, 181);
            this.HSTButton.Name = "HSTButton";
            this.HSTButton.Size = new System.Drawing.Size(125, 38);
            this.HSTButton.TabIndex = 13;
            this.HSTButton.Text = "HST";
            this.HSTButton.UseVisualStyleBackColor = false;
            this.HSTButton.Click += new System.EventHandler(this.HSTButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 647);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 113);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 513);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 281);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nonSystemTimeModesToolStripMenuItem});
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.modesToolStripMenuItem.Text = "Modes";
            // 
            // nonSystemTimeModesToolStripMenuItem
            // 
            this.nonSystemTimeModesToolStripMenuItem.Name = "nonSystemTimeModesToolStripMenuItem";
            this.nonSystemTimeModesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.nonSystemTimeModesToolStripMenuItem.Text = "Non System Time Modes";
            this.nonSystemTimeModesToolStripMenuItem.Click += new System.EventHandler(this.NonSystemTimeModesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1260, 790);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HSTButton);
            this.Controls.Add(this.ASTButton);
            this.Controls.Add(this.MSTButton);
            this.Controls.Add(this.CSTButton);
            this.Controls.Add(this.ESTButton);
            this.Controls.Add(this.UTCTime);
            this.Controls.Add(this.newTimeZone);
            this.Controls.Add(this.PSTButton);
            this.Controls.Add(this.currentUserTime);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Time Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label currentUserTime;
        private Button PSTButton;
        private Label newTimeZone;
        private Label UTCTime;
        private Button ESTButton;
        private Button CSTButton;
        private Button MSTButton;
        private Button ASTButton;
        private Button HSTButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modesToolStripMenuItem;
        private ToolStripMenuItem nonSystemTimeModesToolStripMenuItem;
    }
}