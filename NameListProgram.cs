using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataStructures
{
    class NameListProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        #region Main Method
        static void Main()
        {
            ShortcutMain();
        }
        #endregion
        #region Form Objects
        SplashScreen Splash;
        MainForm mainForm;
        #endregion

        public NameListProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Splash = new SplashScreen();
            Application.Run(Splash);
            Application.Run(Splash.main);

        }

        static void ShortcutMain()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm testMain = new MainForm(Tools.OpenDialog("NameList File", "text files|*.txt"));
            Application.Run(testMain);
        }
    }
}
