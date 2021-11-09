using shutdown.frontend;
using System;
using System.Windows.Forms;

namespace shutdown
{
    internal static class Program
    {
        public static bool Close { get; set; } = false;
        public static Tray Tray { get; set; }


        [STAThread]
        private static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                FrmMain frm = new FrmMain();

                Tray = new Tray(frm);
                Tray.Run();

                Application.Run(frm);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}