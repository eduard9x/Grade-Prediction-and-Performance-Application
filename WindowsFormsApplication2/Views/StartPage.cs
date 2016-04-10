using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GradePredictionApplication.Controllers;

namespace GradePredictionApplication.Views
{
    public partial class StartPage : Form
    {
        String name = "Visitor";
        EntryPointController bla;

        public StartPage()
        {
            InitializeComponent();
        }

        public void setControllerForNextFrame(EntryPointController bla)
        {
            this.bla = bla;
        }


        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" <<<< START with name: " + name);
            //this.Hide();
            //todo NEED to close application on exit of other forms
            bla.EntryPointView();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            TextBox nameHolder = (TextBox) sender;
            name = nameHolder.Text;
        }
    }
}
