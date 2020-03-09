namespace project2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameListViewBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1881, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 44);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(208, 44);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.editNameToolStripMenuItem,
            this.editFileToolStripMenuItem,
            this.sortByFirstToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(75, 44);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // editNameToolStripMenuItem
            // 
            this.editNameToolStripMenuItem.Name = "editNameToolStripMenuItem";
            this.editNameToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.editNameToolStripMenuItem.Text = "Edit Name";
            // 
            // editFileToolStripMenuItem
            // 
            this.editFileToolStripMenuItem.Name = "editFileToolStripMenuItem";
            this.editFileToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.editFileToolStripMenuItem.Text = "Sort By Last";
            this.editFileToolStripMenuItem.Click += new System.EventHandler(this.editFileToolStripMenuItem_Click);
            // 
            // sortByFirstToolStripMenuItem
            // 
            this.sortByFirstToolStripMenuItem.Name = "sortByFirstToolStripMenuItem";
            this.sortByFirstToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.sortByFirstToolStripMenuItem.Text = "Sort By First";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastFirstToolStripMenuItem,
            this.firstLastToolStripMenuItem,
            this.originalToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(86, 44);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // lastFirstToolStripMenuItem
            // 
            this.lastFirstToolStripMenuItem.Name = "lastFirstToolStripMenuItem";
            this.lastFirstToolStripMenuItem.Size = new System.Drawing.Size(246, 44);
            this.lastFirstToolStripMenuItem.Text = "Last, First";
            // 
            // firstLastToolStripMenuItem
            // 
            this.firstLastToolStripMenuItem.Name = "firstLastToolStripMenuItem";
            this.firstLastToolStripMenuItem.Size = new System.Drawing.Size(246, 44);
            this.firstLastToolStripMenuItem.Text = "First, Last";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(246, 44);
            this.originalToolStripMenuItem.Text = "Original";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 44);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // NameListViewBox
            // 
            this.NameListViewBox.AccessibleDescription = "";
            this.NameListViewBox.AccessibleName = "";
            this.NameListViewBox.AutoSize = true;
            this.NameListViewBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.NameListViewBox.Location = new System.Drawing.Point(4, 43);
            this.NameListViewBox.Name = "NameListViewBox";
            this.NameListViewBox.Size = new System.Drawing.Size(480, 1088);
            this.NameListViewBox.TabIndex = 1;
            this.NameListViewBox.TabStop = false;
            this.NameListViewBox.Text = "Names";
            this.NameListViewBox.Enter += new System.EventHandler(this.NameListViewBox_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1883, 1135);
            this.Controls.Add(this.NameListViewBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Location = new System.Drawing.Point(0, 42);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox NameListViewBox;
    }
}