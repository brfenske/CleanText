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

        public static string GetKeyDisplayValue(string keyCode)
        {
            string result = string.Empty;
            switch (keyCode)
            {
                case "Oem7": result = "Quote"; break;
                case "Cancel": result = "Pause"; break;
                case "Next": result = "PageDown"; break;
                case "Subtract": result = "NumpadSubtract"; break;
                case "OemMinus": result = "Minus/Underscore"; break;
                case "Oemplus": result = "="; break;
                case "Oemtilde": result = "~"; break;
                case "Oem6": result = "]"; break;
                case "Oem5": result = "\\"; break;
                case "OemOpenBrackets": result = "["; break;
                case "Oem1": result = ";"; break;
                case "OemQuestion": result = "/"; break;
                case "OemPeriod": result = "."; break;
                case "Oemcomma": result = ","; break;
                default: result = keyCode; break;
            }

            return result;
        }

        public static bool UseAltModifier(int modifiers)
        {
            return (modifiers | Constants.ALT) == modifiers;
        }

        public static bool UseControlModifier(int modifiers)
        {
            return (modifiers | Constants.CTRL) == modifiers;
        }

        public static bool UseShiftModifier(int modifiers)
        {
            return (modifiers | Constants.SHIFT) == modifiers;
        }
    }
}
