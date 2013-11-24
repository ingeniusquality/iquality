using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iQuality
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Intro splash = new Intro();
            if(splash.ShowDialog()==DialogResult.OK)
                Application.Run(new principal());
        }
    }
}
