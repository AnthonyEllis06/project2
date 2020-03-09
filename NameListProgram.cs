using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project2
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
            new NameListProgram();
        }
        #endregion
        #region Form Objects
        MainForm Main;
        SplashScreen Splash;
        #endregion

        public NameListProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
