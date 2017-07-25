using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Edited by: Evan Tellep
/// Author: Prof. Bill Nicholson
/// Contemporary Programming
/// Final Project
/// 12/6/2016
/// Ref: 
/// </summary>

namespace tellepet_CSharpFinal
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


            Application.Run(new EvNav());
        }
    }
}
