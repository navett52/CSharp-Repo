using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Evan Tellep
/// Prof. Bill Nicholson
/// Assignment 08
/// 11/3/2016
/// The entry point for the application
/// Ref:
/// </summary>

namespace tellepet_Assignment08
{
    static class MainX
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Binary_Calculator());
        }
    }
}
