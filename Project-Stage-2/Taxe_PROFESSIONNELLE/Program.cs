using System;
using System.Windows.Forms;
using Taxe_PROFESSIONNELLE;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm: new Login_1());
        }
    }
}