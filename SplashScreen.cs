using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class SplashScreen : Form
    {
        Name userName { get; set; }
        String UserEmail { get; set; }
        public MainForm main { get; private set; }
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void StartingProgress_Click(object sender, EventArgs e)
        {

        }

        private void UNInput_Leave(object sender, EventArgs e)
        {
            Name userName = new Name(UNInput.Text);
        }

        private void EmailInput_Leave(object sender, EventArgs e)
        {
            ValidateUserEmail();
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            if(EmailInput.BackColor != System.Drawing.SystemColors.ActiveCaptionText)
                EmailInput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void UNInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                EmailInput.Focus();
        }

        private void EmailInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ValidateUserEmail();
            if (EmailInput.BackColor != Color.Red)
            {
                EmailInput.Visible = false;
                UNInput.Visible = false;
                OpenFileButton.Visible = true;
                NewFileButton.Visible = true;
            }

        }

        private void ValidateUserEmail()
        {
            Regex EmailPattern = new Regex(@"([\w\W]+)(@)([\w]+)[\.](com|edu)"); // Regex pattern for emails
            Match m = EmailPattern.Match(EmailInput.Text);
            if (!m.Success)
                EmailInput.BackColor = Color.Red;
            else
            {
                UserEmail = EmailInput.Text;
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            String FileName = Tools.OpenDialog("NameList File", "text files|*.txt");
            main = new MainForm(FileName);
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            main = new MainForm();
        }
    }
}
