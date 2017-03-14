/*
 * This program exists to convert ICS calendar files (Moodle's, specifically) into a format that can be plugged into Remember the Milk.
 * by Curtis Moyle, to make things at GTCC more managable.
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ical.Net;

namespace icsToMilk
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
