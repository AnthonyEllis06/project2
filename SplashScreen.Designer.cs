namespace project2
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StartingProgress = new System.Windows.Forms.ProgressBar();
            this.UNInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartingProgress
            // 
            this.StartingProgress.AccessibleName = "ProgressBar";
            this.StartingProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StartingProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartingProgress.BackColor = System.Drawing.Color.Black;
            this.StartingProgress.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.StartingProgress.ForeColor = System.Drawing.Color.Aqua;
            this.StartingProgress.Location = new System.Drawing.Point(75, 800);
            this.StartingProgress.Name = "StartingProgress";
            this.StartingProgress.Size = new System.Drawing.Size(550, 25);
            this.StartingProgress.TabIndex = 0;
            this.StartingProgress.Visible = false;
            this.StartingProgress.Click += new System.EventHandler(this.StartingProgress_Click);
            // 
            // UNInput
            // 
            this.UNInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UNInput.ForeColor = System.Drawing.SystemColors.Window;
            this.UNInput.Location = new System.Drawing.Point(75, 643);
            this.UNInput.MaxLength = 100;
            this.UNInput.Name = "UNInput";
            this.UNInput.Size = new System.Drawing.Size(550, 31);
            this.UNInput.TabIndex = 1;
            this.UNInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UNInput.Visible = false;
            this.UNInput.WordWrap = false;
            this.UNInput.TextChanged += new System.EventHandler(this.UNInput_TextChanged);
            // 
            // EmailInput
            // 
            this.EmailInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailInput.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailInput.Location = new System.Drawing.Point(75, 727);
            this.EmailInput.MaxLength = 100;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(550, 31);
            this.EmailInput.TabIndex = 2;
            this.EmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailInput.Visible = false;
            this.EmailInput.WordWrap = false;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 1029);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.UNInput);
            this.Controls.Add(this.StartingProgress);
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ProgressBar StartingProgress;
        private System.Windows.Forms.TextBox UNInput;
        private System.Windows.Forms.TextBox EmailInput;
    }
}