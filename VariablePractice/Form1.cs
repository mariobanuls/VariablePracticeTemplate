
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            outputLabel.Text += $"\n{playerName} is number {playerNumber}";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double hours = 25;
            double pay = 18.75;
            double earned = hours * pay;
            outputLabel.Text += $"\n{hours} hours at {pay} per hour equals {earned}";


        }
    }
}
