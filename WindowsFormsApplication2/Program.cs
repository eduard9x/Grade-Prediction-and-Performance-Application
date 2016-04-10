using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GradePredictionApplication.Controllers;
using GradePredictionApplication.Views;

namespace GradePredictionApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            EntryPointController bla = new EntryPointController();

            bla.DatabaseManager();
            bla.EntryPointView();


            StartPage StartPageForm = new StartPage();

            //Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(StartPageForm);

           

        }
    }
}
