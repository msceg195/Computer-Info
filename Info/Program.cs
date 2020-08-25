using System;
using System.Threading;
using System.Windows.Forms;

namespace Computer_Info
{
    static class Program
    {
        private static Mutex mutex = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            const string appName = "Computer Info";
            mutex = new Mutex(true, appName, out bool createdNew);

            if (!createdNew)
            {
                //app is already running! Exiting the application  
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
