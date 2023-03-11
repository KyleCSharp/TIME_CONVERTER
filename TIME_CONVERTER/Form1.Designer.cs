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
            currentUserTime = new Label();
            PSTButton = new Button();
            newTimeZone = new Label();
            UTCTime = new Label();
            ESTButton = new Button();
            CSTButton = new Button();
            MSTButton = new Button();
            ASTButton = new Button();
            HSTButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // currentUserTime
            // 
            currentUserTime.BackColor = Color.Transparent;
            currentUserTime.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            currentUserTime.Location = new Point(480, 24);
            currentUserTime.Name = "currentUserTime";
            currentUserTime.Size = new Size(313, 48);
            currentUserTime.TabIndex = 1;
            currentUserTime.Text = "Click me to get system local time";
            currentUserTime.TextAlign = ContentAlignment.MiddleCenter;
            currentUserTime.TextChanged += GetUserTime;
            currentUserTime.Click += GetUserTime;
            // 
            // PSTButton
            // 
            PSTButton.BackColor = Color.FromArgb(255, 128, 0);
            PSTButton.Location = new Point(200, 181);
            PSTButton.Name = "PSTButton";
            PSTButton.Size = new Size(125, 38);
            PSTButton.TabIndex = 2;
            PSTButton.Text = "PST";
            PSTButton.UseVisualStyleBackColor = false;
            PSTButton.Click += PSTButton_Click;
            // 
            // newTimeZone
            // 
            newTimeZone.BackColor = Color.White;
            newTimeZone.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            newTimeZone.Location = new Point(200, 280);
            newTimeZone.Name = "newTimeZone";
            newTimeZone.Size = new Size(780, 120);
            newTimeZone.TabIndex = 6;
            newTimeZone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UTCTime
            // 
            UTCTime.BackColor = Color.Transparent;
            UTCTime.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UTCTime.Location = new Point(954, 38);
            UTCTime.Name = "UTCTime";
            UTCTime.Size = new Size(226, 34);
            UTCTime.TabIndex = 8;
            UTCTime.Text = "UTCTime";
            UTCTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ESTButton
            // 
            ESTButton.BackColor = Color.Red;
            ESTButton.Location = new Point(855, 181);
            ESTButton.Name = "ESTButton";
            ESTButton.Size = new Size(125, 38);
            ESTButton.TabIndex = 9;
            ESTButton.Text = "EST";
            ESTButton.UseVisualStyleBackColor = false;
            ESTButton.Click += ESTButton_Click;
            // 
            // CSTButton
            // 
            CSTButton.BackColor = Color.Yellow;
            CSTButton.Location = new Point(462, 181);
            CSTButton.Name = "CSTButton";
            CSTButton.Size = new Size(125, 38);
            CSTButton.TabIndex = 10;
            CSTButton.Text = "CST";
            CSTButton.UseVisualStyleBackColor = false;
            CSTButton.Click += CSTButton_Click;
            // 
            // MSTButton
            // 
            MSTButton.BackColor = Color.FromArgb(0, 192, 0);
            MSTButton.Location = new Point(331, 181);
            MSTButton.Name = "MSTButton";
            MSTButton.Size = new Size(125, 38);
            MSTButton.TabIndex = 11;
            MSTButton.Text = "MST";
            MSTButton.UseVisualStyleBackColor = false;
            MSTButton.Click += MSTButton_Click;
            // 
            // ASTButton
            // 
            ASTButton.BackColor = Color.CornflowerBlue;
            ASTButton.Location = new Point(593, 181);
            ASTButton.Name = "ASTButton";
            ASTButton.Size = new Size(125, 38);
            ASTButton.TabIndex = 12;
            ASTButton.Text = "AST";
            ASTButton.UseVisualStyleBackColor = false;
            ASTButton.Click += ASTButton_Click;
            // 
            // HSTButton
            // 
            HSTButton.BackColor = Color.Fuchsia;
            HSTButton.ForeColor = Color.Black;
            HSTButton.Location = new Point(724, 181);
            HSTButton.Name = "HSTButton";
            HSTButton.Size = new Size(125, 38);
            HSTButton.TabIndex = 13;
            HSTButton.Text = "HST";
            HSTButton.UseVisualStyleBackColor = false;
            HSTButton.Click += HSTButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, 647);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 113);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 513);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(291, 281);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1260, 790);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(HSTButton);
            Controls.Add(ASTButton);
            Controls.Add(MSTButton);
            Controls.Add(CSTButton);
            Controls.Add(ESTButton);
            Controls.Add(UTCTime);
            Controls.Add(newTimeZone);
            Controls.Add(PSTButton);
            Controls.Add(currentUserTime);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Time Viewer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
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
    }
}