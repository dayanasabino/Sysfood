﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFood
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

            Forms.FrmLogin login = new Forms.FrmLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }
        }
    }
}
