using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureDatabase // No access specifiers.
{
    static class Program // Internal access specifier by default (can access it only within current project), or can be switched to public. No other access specifiers are allowed.
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() // Private access specifier by default. Special method --> Can be called by the compiler even if it is private.
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Movies());
        }
    }
}
