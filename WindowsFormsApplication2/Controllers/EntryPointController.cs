using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradePredictionApplication.Models;
using GradePredictionApplication.Views;
using System.Windows.Forms;

namespace GradePredictionApplication.Controllers
{
    public class EntryPointController
    {
        public EntryPointController()
        {
            Console.WriteLine(" <<<< Controller has been created.");
        }

        public void EntryPointView()
        {
            Console.WriteLine(" <<<< New Entry Point View.");

            EntryPoint EntryPointForm = new EntryPoint();
            EntryPointForm.Show();
            //EntryPointForm.Hide();


        }

        public void DatabaseManager()
        {
            DatabaseManager DB = new DatabaseManager();
        }


    }
}
