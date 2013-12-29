using System;
using System.Threading;
using System.Windows.Forms;

namespace CleanText
{
    static class Program
    {
        private static string appGuid = "D0A2B602-837C-42EF-BB27-0672C4BE02B4";

        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    return;
                }

                GC.Collect();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
