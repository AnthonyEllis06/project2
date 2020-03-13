namespace DataStructures
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
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
            this.StartingProgress.Location = new System.Drawing.Point(50, 512);
            this.StartingProgress.Margin = new System.Windows.Forms.Padding(2);
            this.StartingProgress.Name = "StartingProgress";
            this.StartingProgress.Size = new System.Drawing.Size(367, 16);
            this.StartingProgress.TabIndex = 0;
            this.StartingProgress.Visible = false;
            this.StartingProgress.Click += new System.EventHandler(this.StartingProgress_Click);
            // 
            // UNInput
            // 
            this.UNInput.AcceptsReturn = true;
            this.UNInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UNInput.ForeColor = System.Drawing.SystemColors.Window;
            this.UNInput.Location = new System.Drawing.Point(50, 412);
            this.UNInput.Margin = new System.Windows.Forms.Padding(2);
            this.UNInput.MaxLength = 100;
            this.UNInput.Name = "UNInput";
            this.UNInput.Size = new System.Drawing.Size(368, 22);
            this.UNInput.TabIndex = 1;
            this.UNInput.Tag = "NameTag";
            this.UNInput.Text = "Name";
            this.UNInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UNInput.WordWrap = false;
            this.UNInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UNInput_KeyDown);
            this.UNInput.Leave += new System.EventHandler(this.UNInput_Leave);
            // 
            // EmailInput
            // 
            this.EmailInput.AcceptsReturn = true;
            this.EmailInput.AllowDrop = true;
            this.EmailInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailInput.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailInput.ImeMode = System.Windows.Forms.ImeMode.On;
            this.EmailInput.Location = new System.Drawing.Point(50, 465);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmailInput.MaxLength = 100;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(368, 22);
            this.EmailInput.TabIndex = 2;
            this.EmailInput.Tag = "EmailTag";
            this.EmailInput.Text = "Email";
            this.EmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailInput.WordWrap = false;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            this.EmailInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailInput_KeyDown);
            this.EmailInput.Leave += new System.EventHandler(this.EmailInput_Leave);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(240, 558);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(177, 42);
            this.OpenFileButton.TabIndex = 3;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Visible = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(50, 558);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(184, 42);
            this.NewFileButton.TabIndex = 4;
            this.NewFileButton.Text = "New File";
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Visible = false;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 659);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.UNInput);
            this.Controls.Add(this.StartingProgress);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ProgressBar StartingProgress;
        public System.Windows.Forms.TextBox UNInput;
        public System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button NewFileButton;
    }
}