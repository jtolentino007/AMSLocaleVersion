using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS;
using DevExpress.Skins;

namespace AMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.C:\Users\jdevb\Source\Workspaces\Attendance Monitoring System (Locale Version)\AMS v1\Attendance Monitoring V1\PrintRibbonControllerResources.resx
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new Attendance_Summary_Report());
        }
    }
}
