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
            this.UNInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UNInput
            // 
            this.UNInput.AcceptsReturn = true;
            this.UNInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UNInput.ForeColor = System.Drawing.SystemColors.Window;
            this.UNInput.Location = new System.Drawing.Point(38, 335);
            this.UNInput.Margin = new System.Windows.Forms.Padding(2);
            this.UNInput.MaxLength = 100;
            this.UNInput.Name = "UNInput";
            this.UNInput.Size = new System.Drawing.Size(277, 20);
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
            this.EmailInput.Location = new System.Drawing.Point(38, 378);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(2);
            this.EmailInput.MaxLength = 100;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(277, 20);
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
            this.OpenFileButton.Location = new System.Drawing.Point(180, 453);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(133, 34);
            this.OpenFileButton.TabIndex = 3;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Visible = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(38, 453);
            this.NewFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(138, 34);
            this.NewFileButton.TabIndex = 4;
            this.NewFileButton.Text = "New File";
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Visible = false;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 535);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.UNInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox UNInput;
        public System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button NewFileButton;
    }
}