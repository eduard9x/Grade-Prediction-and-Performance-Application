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

            StartPage StartPageForm = new StartPage();
            StartPageForm.setControllerForNextFrame(bla);

            Application.EnableVisualStyles();
            Application.Run(StartPageForm);

            //bla.EntryPointView();

        }
    }
}
