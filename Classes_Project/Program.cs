﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlog;

namespace Classes_Project
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

            //run inlogscherm
//            Application.Run(new LoginForm());

            //uncomment dit en maak de regel hierboven een comment om het inlogscherm te omzeilen en direct ingelogd te zijn als een manager
            Application.Run(new MainForm(new Keuken(0, 0, "Developer", "", MedewerkerRol.Manager)));
        }
    }
}
