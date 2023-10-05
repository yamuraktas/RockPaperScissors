using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
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
            Application.Run(new FormIntro());

            Tas tas1 = new Tas(20, 0, 2);
            Tas tas2 = new Tas(20, 0, 2);
            Tas tas3 = new Tas(20, 0, 2);
            Tas tas4 = new Tas(20, 0, 2);
            Tas tas5 = new Tas(20, 0, 2);

            Kagit kagit1 = new Kagit(20, 0, 2);
            Kagit kagit2 = new Kagit(20, 0, 2);
            Kagit kagit3 = new Kagit(20, 0, 2);
            Kagit kagit4 = new Kagit(20, 0, 2);
            Kagit kagit5 = new Kagit(20, 0, 2);

            Makas makas1 = new Makas(20, 0, 2);
            Makas makas2 = new Makas(20, 0, 2);
            Makas makas3 = new Makas(20, 0, 2);
            Makas makas4 = new Makas(20, 0, 2);
            Makas makas5 = new Makas(20, 0, 2);

        }
    }
}
