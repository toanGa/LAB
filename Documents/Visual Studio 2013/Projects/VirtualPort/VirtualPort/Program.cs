using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualPort.BaiTapLon;
using VirtualPort.Booling;
using VirtualPort.BaiTapLon;
using VirtualPort.UART;

namespace VirtualPort
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UART.UART());
        }
    }
}
