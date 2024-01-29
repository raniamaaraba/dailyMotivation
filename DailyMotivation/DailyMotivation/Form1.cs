/**
 * Project: Daily Motivation
 * Programmer: Rania Maaraba
 * Date: Septemner 2022
 * Description: For the five work days, each day providies a different insparational message.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DailyMotivation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mondayButton_Click(object sender, EventArgs e)
        {
            // Display the motivation message for Monday.

            messageLabel.Text = "Beauty is hidden in everything, just learn to observe.";
        }

        private void tuesdayButton_Click(object sender, EventArgs e)
        {
            // Display the motivation message for Tuesday.

            messageLabel.Text = "The struggle you're in today is developing the strength you need for tommorow.";
        }

        private void wednesdayButton_Click(object sender, EventArgs e)
        {
            // Display the motivation message for Wednesday.

            messageLabel.Text = "Be the reason someone else smiles today.";
        }

        private void thursdayButton_Click(object sender, EventArgs e)
        {
            // Display the motivation message for Thursday.

            messageLabel.Text = "Start each day with a greateful heart.";
        }

        private void fridayButton_Click(object sender, EventArgs e)
        {
            // Display the motivation message for Friday.

            messageLabel.Text = "1 year = 365 possibilities.";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}