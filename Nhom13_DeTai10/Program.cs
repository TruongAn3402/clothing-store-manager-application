﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom13_DeTai10
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

            Application.Run(new frmLogin());

            //Application.Run(new frmQuanLy());
            //Application.Run(new frmAdmin());
            //Application.Run(new GameCaro());
            //Application.Run(new frmHoaDon());
        }
    }
}
