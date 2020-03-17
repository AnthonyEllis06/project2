using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace DataStructures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByOriginalFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToAddNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToRemoveNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToSortNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameListViewBox = new System.Windows.Forms.GroupBox();
            this.NamesListView = new System.Windows.Forms.ListView();
            this.BlankColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NumNamesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.VersionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RemoveTab = new System.Windows.Forms.TabPage();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveGroup = new System.Windows.Forms.GroupBox();
            this.NameToRemove = new System.Windows.Forms.TextBox();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddPartGroup = new System.Windows.Forms.GroupBox();
            this.AddPartsSuff = new System.Windows.Forms.TextBox();
            this.AddPartsLast = new System.Windows.Forms.TextBox();
            this.AddPartsFirst = new System.Windows.Forms.TextBox();
            this.AddGroup = new System.Windows.Forms.GroupBox();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.NameTabControl = new System.Windows.Forms.TabControl();
            this.EditTab = new System.Windows.Forms.TabPage();
            this.EditSuffGroup = new System.Windows.Forms.GroupBox();
            this.EditSuffText = new System.Windows.Forms.TextBox();
            this.EditLastGroup = new System.Windows.Forms.GroupBox();
            this.EditLastText = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditRestGroup = new System.Windows.Forms.GroupBox();
            this.EditRestText = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            this.NameListViewBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.RemoveTab.SuspendLayout();
            this.RemoveGroup.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.AddPartGroup.SuspendLayout();
            this.AddGroup.SuspendLayout();
            this.NameTabControl.SuspendLayout();
            this.EditTab.SuspendLayout();
            this.EditSuffGroup.SuspendLayout();
            this.EditLastGroup.SuspendLayout();
            this.EditRestGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(1, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 0);
            this.MainMenuStrip.Size = new System.Drawing.Size(946, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editNameToolStripMenuItem,
            this.editFileToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editNameToolStripMenuItem
            // 
            this.editNameToolStripMenuItem.Name = "editNameToolStripMenuItem";
            this.editNameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editNameToolStripMenuItem.Text = "Edit Name";
            // 
            // editFileToolStripMenuItem
            // 
            this.editFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameFirstToolStripMenuItem,
            this.lastToolStripMenuItem,
            this.sortByOriginalFormatToolStripMenuItem});
            this.editFileToolStripMenuItem.Name = "editFileToolStripMenuItem";
            this.editFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editFileToolStripMenuItem.Text = "Sort Names";
            // 
            // firstNameFirstToolStripMenuItem
            // 
            this.firstNameFirstToolStripMenuItem.Name = "firstNameFirstToolStripMenuItem";
            this.firstNameFirstToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.firstNameFirstToolStripMenuItem.Text = "Sort by First Name";
            // 
            // lastToolStripMenuItem
            // 
            this.lastToolStripMenuItem.Name = "lastToolStripMenuItem";
            this.lastToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.lastToolStripMenuItem.Text = "Sort by Last Name";
            // 
            // sortByOriginalFormatToolStripMenuItem
            // 
            this.sortByOriginalFormatToolStripMenuItem.Name = "sortByOriginalFormatToolStripMenuItem";
            this.sortByOriginalFormatToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sortByOriginalFormatToolStripMenuItem.Text = "Sort by Original Format";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastFirstToolStripMenuItem,
            this.firstLastToolStripMenuItem,
            this.originalToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // lastFirstToolStripMenuItem
            // 
            this.lastFirstToolStripMenuItem.Name = "lastFirstToolStripMenuItem";
            this.lastFirstToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.lastFirstToolStripMenuItem.Text = "Last, First";
            // 
            // firstLastToolStripMenuItem
            // 
            this.firstLastToolStripMenuItem.Name = "firstLastToolStripMenuItem";
            this.firstLastToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.firstLastToolStripMenuItem.Text = "First, Last";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.originalToolStripMenuItem.Text = "Original";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AboutProgramMenuItem
            // 
            this.AboutProgramMenuItem.Name = "AboutProgramMenuItem";
            this.AboutProgramMenuItem.Size = new System.Drawing.Size(160, 22);
            this.AboutProgramMenuItem.Tag = "";
            this.AboutProgramMenuItem.Text = "About NameList";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToEditToolStripMenuItem,
            this.howToAddNamesToolStripMenuItem,
            this.howToRemoveNamesToolStripMenuItem,
            this.howToSortNamesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToEditToolStripMenuItem
            // 
            this.howToEditToolStripMenuItem.Name = "howToEditToolStripMenuItem";
            this.howToEditToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.howToEditToolStripMenuItem.Text = "How to Edit";
            // 
            // howToAddNamesToolStripMenuItem
            // 
            this.howToAddNamesToolStripMenuItem.Name = "howToAddNamesToolStripMenuItem";
            this.howToAddNamesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.howToAddNamesToolStripMenuItem.Text = "How to Add Names";
            // 
            // howToRemoveNamesToolStripMenuItem
            // 
            this.howToRemoveNamesToolStripMenuItem.Name = "howToRemoveNamesToolStripMenuItem";
            this.howToRemoveNamesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.howToRemoveNamesToolStripMenuItem.Text = "How to Remove Names";
            // 
            // howToSortNamesToolStripMenuItem
            // 
            this.howToSortNamesToolStripMenuItem.Name = "howToSortNamesToolStripMenuItem";
            this.howToSortNamesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.howToSortNamesToolStripMenuItem.Text = "How to Sort Names";
            // 
            // NameListViewBox
            // 
            this.NameListViewBox.AccessibleDescription = "";
            this.NameListViewBox.AccessibleName = "";
            this.NameListViewBox.AutoSize = true;
            this.NameListViewBox.Controls.Add(this.NamesListView);
            this.NameListViewBox.ForeColor = System.Drawing.Color.Ivory;
            this.NameListViewBox.Location = new System.Drawing.Point(2, 27);
            this.NameListViewBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameListViewBox.Name = "NameListViewBox";
            this.NameListViewBox.Padding = new System.Windows.Forms.Padding(2);
            this.NameListViewBox.Size = new System.Drawing.Size(381, 549);
            this.NameListViewBox.TabIndex = 1;
            this.NameListViewBox.TabStop = false;
            this.NameListViewBox.Text = "Names";
            // 
            // NamesListView
            // 
            this.NamesListView.AutoArrange = false;
            this.NamesListView.BackColor = System.Drawing.SystemColors.MenuText;
            this.NamesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BlankColumn});
            this.NamesListView.ForeColor = System.Drawing.SystemColors.Window;
            this.NamesListView.GridLines = true;
            this.NamesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.NamesListView.HideSelection = false;
            this.NamesListView.LabelWrap = false;
            this.NamesListView.Location = new System.Drawing.Point(7, 15);
            this.NamesListView.Margin = new System.Windows.Forms.Padding(2);
            this.NamesListView.MultiSelect = false;
            this.NamesListView.Name = "NamesListView";
            this.NamesListView.ShowGroups = false;
            this.NamesListView.Size = new System.Drawing.Size(370, 517);
            this.NamesListView.TabIndex = 0;
            this.NamesListView.UseCompatibleStateImageBehavior = false;
            this.NamesListView.View = System.Windows.Forms.View.Details;
            this.NamesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.NamesListView_ItemSelectionChanged);
            // 
            // BlankColumn
            // 
            this.BlankColumn.Name = "BlankColumn";
            this.BlankColumn.Text = "";
            this.BlankColumn.Width = this.NameListViewBox.Width;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(1, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 564);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumNamesLabel,
            this.VersionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(4, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(943, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NumNamesLabel
            // 
            this.NumNamesLabel.Name = "NumNamesLabel";
            this.NumNamesLabel.Size = new System.Drawing.Size(464, 17);
            this.NumNamesLabel.Spring = true;
            this.NumNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(464, 17);
            this.VersionLabel.Spring = true;
            this.VersionLabel.Text = "Version: 16.4.29905.134";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RemoveTab
            // 
            this.RemoveTab.BackColor = System.Drawing.Color.Black;
            this.RemoveTab.Controls.Add(this.RemoveButton);
            this.RemoveTab.Controls.Add(this.RemoveGroup);
            this.RemoveTab.Location = new System.Drawing.Point(4, 22);
            this.RemoveTab.Name = "RemoveTab";
            this.RemoveTab.Padding = new System.Windows.Forms.Padding(3);
            this.RemoveTab.Size = new System.Drawing.Size(548, 510);
            this.RemoveTab.TabIndex = 2;
            this.RemoveTab.Text = "Remove Name";
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(375, 85);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(168, 24);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove Name";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveGroup
            // 
            this.RemoveGroup.Controls.Add(this.NameToRemove);
            this.RemoveGroup.ForeColor = System.Drawing.Color.White;
            this.RemoveGroup.Location = new System.Drawing.Point(3, 20);
            this.RemoveGroup.Name = "RemoveGroup";
            this.RemoveGroup.Size = new System.Drawing.Size(540, 39);
            this.RemoveGroup.TabIndex = 1;
            this.RemoveGroup.TabStop = false;
            this.RemoveGroup.Text = "Name To Remove";
            // 
            // NameToRemove
            // 
            this.NameToRemove.BackColor = System.Drawing.Color.Black;
            this.NameToRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameToRemove.ForeColor = System.Drawing.Color.White;
            this.NameToRemove.Location = new System.Drawing.Point(6, 16);
            this.NameToRemove.Name = "NameToRemove";
            this.NameToRemove.Size = new System.Drawing.Size(527, 13);
            this.NameToRemove.TabIndex = 0;
            this.NameToRemove.TextChanged += new System.EventHandler(this.NameToRemove_TextChanged);
            // 
            // AddTab
            // 
            this.AddTab.BackColor = System.Drawing.Color.Black;
            this.AddTab.Controls.Add(this.AddButton);
            this.AddTab.Controls.Add(this.AddPartGroup);
            this.AddTab.Controls.Add(this.AddGroup);
            this.AddTab.Location = new System.Drawing.Point(4, 22);
            this.AddTab.Name = "AddTab";
            this.AddTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTab.Size = new System.Drawing.Size(548, 510);
            this.AddTab.TabIndex = 1;
            this.AddTab.Text = "Add Name";
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(368, 384);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(168, 24);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add Name";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // AddPartGroup
            // 
            this.AddPartGroup.Controls.Add(this.AddPartsSuff);
            this.AddPartGroup.Controls.Add(this.AddPartsLast);
            this.AddPartGroup.Controls.Add(this.AddPartsFirst);
            this.AddPartGroup.ForeColor = System.Drawing.Color.White;
            this.AddPartGroup.Location = new System.Drawing.Point(3, 152);
            this.AddPartGroup.Name = "AddPartGroup";
            this.AddPartGroup.Size = new System.Drawing.Size(540, 210);
            this.AddPartGroup.TabIndex = 4;
            this.AddPartGroup.TabStop = false;
            this.AddPartGroup.Text = "Name Break Down";
            // 
            // AddPartsSuff
            // 
            this.AddPartsSuff.BackColor = System.Drawing.Color.Black;
            this.AddPartsSuff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddPartsSuff.ForeColor = System.Drawing.Color.White;
            this.AddPartsSuff.Location = new System.Drawing.Point(6, 164);
            this.AddPartsSuff.Name = "AddPartsSuff";
            this.AddPartsSuff.ReadOnly = true;
            this.AddPartsSuff.Size = new System.Drawing.Size(527, 13);
            this.AddPartsSuff.TabIndex = 2;
            this.AddPartsSuff.Text = "Suffix";
            this.AddPartsSuff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPartsLast
            // 
            this.AddPartsLast.BackColor = System.Drawing.Color.Black;
            this.AddPartsLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddPartsLast.ForeColor = System.Drawing.Color.White;
            this.AddPartsLast.Location = new System.Drawing.Point(6, 103);
            this.AddPartsLast.Name = "AddPartsLast";
            this.AddPartsLast.ReadOnly = true;
            this.AddPartsLast.Size = new System.Drawing.Size(527, 13);
            this.AddPartsLast.TabIndex = 1;
            this.AddPartsLast.Text = "Last";
            this.AddPartsLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPartsFirst
            // 
            this.AddPartsFirst.BackColor = System.Drawing.Color.Black;
            this.AddPartsFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddPartsFirst.ForeColor = System.Drawing.Color.White;
            this.AddPartsFirst.Location = new System.Drawing.Point(6, 44);
            this.AddPartsFirst.Name = "AddPartsFirst";
            this.AddPartsFirst.ReadOnly = true;
            this.AddPartsFirst.Size = new System.Drawing.Size(527, 13);
            this.AddPartsFirst.TabIndex = 0;
            this.AddPartsFirst.Text = "First";
            this.AddPartsFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddGroup
            // 
            this.AddGroup.Controls.Add(this.AddTextBox);
            this.AddGroup.ForeColor = System.Drawing.Color.White;
            this.AddGroup.Location = new System.Drawing.Point(3, 16);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(540, 39);
            this.AddGroup.TabIndex = 3;
            this.AddGroup.TabStop = false;
            this.AddGroup.Text = "Name To Add";
            // 
            // AddTextBox
            // 
            this.AddTextBox.BackColor = System.Drawing.Color.Black;
            this.AddTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddTextBox.ForeColor = System.Drawing.Color.White;
            this.AddTextBox.Location = new System.Drawing.Point(6, 19);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(527, 13);
            this.AddTextBox.TabIndex = 0;
            this.AddTextBox.TextChanged += new System.EventHandler(this.AddTextBox_TextChanged);
            // 
            // NameTabControl
            // 
            this.NameTabControl.Controls.Add(this.EditTab);
            this.NameTabControl.Controls.Add(this.AddTab);
            this.NameTabControl.Controls.Add(this.RemoveTab);
            this.NameTabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameTabControl.Location = new System.Drawing.Point(388, 27);
            this.NameTabControl.Name = "NameTabControl";
            this.NameTabControl.SelectedIndex = 0;
            this.NameTabControl.Size = new System.Drawing.Size(556, 536);
            this.NameTabControl.TabIndex = 5;
            this.NameTabControl.TabStop = false;
            // 
            // EditTab
            // 
            this.EditTab.BackColor = System.Drawing.Color.Black;
            this.EditTab.Controls.Add(this.EditSuffGroup);
            this.EditTab.Controls.Add(this.EditLastGroup);
            this.EditTab.Controls.Add(this.EditButton);
            this.EditTab.Controls.Add(this.EditRestGroup);
            this.EditTab.Location = new System.Drawing.Point(4, 22);
            this.EditTab.Name = "EditTab";
            this.EditTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditTab.Size = new System.Drawing.Size(548, 510);
            this.EditTab.TabIndex = 3;
            this.EditTab.Text = "Edit Tab";
            // 
            // EditSuffGroup
            // 
            this.EditSuffGroup.Controls.Add(this.EditSuffText);
            this.EditSuffGroup.ForeColor = System.Drawing.Color.White;
            this.EditSuffGroup.Location = new System.Drawing.Point(6, 162);
            this.EditSuffGroup.Name = "EditSuffGroup";
            this.EditSuffGroup.Size = new System.Drawing.Size(540, 39);
            this.EditSuffGroup.TabIndex = 10;
            this.EditSuffGroup.TabStop = false;
            this.EditSuffGroup.Text = "Suffix";
            // 
            // EditSuffText
            // 
            this.EditSuffText.BackColor = System.Drawing.Color.Black;
            this.EditSuffText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditSuffText.ForeColor = System.Drawing.Color.White;
            this.EditSuffText.Location = new System.Drawing.Point(6, 16);
            this.EditSuffText.Name = "EditSuffText";
            this.EditSuffText.Size = new System.Drawing.Size(527, 13);
            this.EditSuffText.TabIndex = 0;
            // 
            // EditLastGroup
            // 
            this.EditLastGroup.Controls.Add(this.EditLastText);
            this.EditLastGroup.ForeColor = System.Drawing.Color.White;
            this.EditLastGroup.Location = new System.Drawing.Point(6, 92);
            this.EditLastGroup.Name = "EditLastGroup";
            this.EditLastGroup.Size = new System.Drawing.Size(540, 39);
            this.EditLastGroup.TabIndex = 9;
            this.EditLastGroup.TabStop = false;
            this.EditLastGroup.Text = "Last Name";
            // 
            // EditLastText
            // 
            this.EditLastText.BackColor = System.Drawing.Color.Black;
            this.EditLastText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditLastText.ForeColor = System.Drawing.Color.White;
            this.EditLastText.Location = new System.Drawing.Point(6, 16);
            this.EditLastText.Name = "EditLastText";
            this.EditLastText.Size = new System.Drawing.Size(527, 13);
            this.EditLastText.TabIndex = 0;
            // 
            // EditButton
            // 
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(375, 218);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(168, 24);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit Name";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // EditRestGroup
            // 
            this.EditRestGroup.Controls.Add(this.EditRestText);
            this.EditRestGroup.ForeColor = System.Drawing.Color.White;
            this.EditRestGroup.Location = new System.Drawing.Point(6, 28);
            this.EditRestGroup.Name = "EditRestGroup";
            this.EditRestGroup.Size = new System.Drawing.Size(540, 39);
            this.EditRestGroup.TabIndex = 7;
            this.EditRestGroup.TabStop = false;
            this.EditRestGroup.Text = "First and Middle Name";
            // 
            // EditRestText
            // 
            this.EditRestText.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EditRestText.BackColor = System.Drawing.Color.Black;
            this.EditRestText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditRestText.ForeColor = System.Drawing.Color.White;
            this.EditRestText.Location = new System.Drawing.Point(6, 16);
            this.EditRestText.Name = "EditRestText";
            this.EditRestText.Size = new System.Drawing.Size(527, 13);
            this.EditRestText.TabIndex = 0;
            this.EditRestText.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(948, 589);
            this.Controls.Add(this.NameTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.NameListViewBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 42);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.Text = " NameList";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.NameListViewBox.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.RemoveTab.ResumeLayout(false);
            this.RemoveGroup.ResumeLayout(false);
            this.RemoveGroup.PerformLayout();
            this.AddTab.ResumeLayout(false);
            this.AddPartGroup.ResumeLayout(false);
            this.AddPartGroup.PerformLayout();
            this.AddGroup.ResumeLayout(false);
            this.AddGroup.PerformLayout();
            this.NameTabControl.ResumeLayout(false);
            this.EditTab.ResumeLayout(false);
            this.EditSuffGroup.ResumeLayout(false);
            this.EditSuffGroup.PerformLayout();
            this.EditLastGroup.ResumeLayout(false);
            this.EditLastGroup.PerformLayout();
            this.EditRestGroup.ResumeLayout(false);
            this.EditRestGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox NameListViewBox;
        private System.Windows.Forms.ListView NamesListView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NumNamesLabel;
        private System.Windows.Forms.ToolStripStatusLabel VersionLabel;
        private ToolStripMenuItem AboutProgramMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem howToEditToolStripMenuItem;
        private ToolStripMenuItem howToAddNamesToolStripMenuItem;
        private ToolStripMenuItem howToRemoveNamesToolStripMenuItem;
        private ToolStripMenuItem howToSortNamesToolStripMenuItem;
        private ToolStripMenuItem firstNameFirstToolStripMenuItem;
        private ToolStripMenuItem lastToolStripMenuItem;
        private ToolStripMenuItem sortByOriginalFormatToolStripMenuItem;
        private TabPage RemoveTab;
        private Button RemoveButton;
        private GroupBox RemoveGroup;
        private TextBox NameToRemove;
        private TabPage AddTab;
        private Button AddButton;
        private GroupBox AddPartGroup;
        private TextBox AddPartsSuff;
        private TextBox AddPartsLast;
        private TextBox AddPartsFirst;
        private GroupBox AddGroup;
        private TextBox AddTextBox;
        private TabControl NameTabControl;
        private TabPage EditTab;
        private GroupBox EditSuffGroup;
        private TextBox EditSuffText;
        private GroupBox EditLastGroup;
        private TextBox EditLastText;
        private Button EditButton;
        private GroupBox EditRestGroup;
        private TextBox EditRestText;
        private ColumnHeader BlankColumn;
    }
}