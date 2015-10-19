﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    class Bettor
    {
        private string Name; // The guy's name
        private Bet MyBet; // An instance of Bet that has his bet
        private int Cash; // How much cash he has
                         // The last two fields are the guy’s GUI controls on the form
        public RadioButton MyRadioButton; // My RadioButton
        public Label MyLabel; // My Label

        public Bettor(string name, int cash, RadioButton radiobutton, Label label)
        {
            this.Name = name;
            this.Cash = cash;
            this.MyRadioButton = radiobutton;
            this.MyLabel = label;
            MyRadioButton.Text = name + " has " + Cash + " bucks";
            MyLabel.Text = name + " has not placed a bet yet"; 
        }

        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
        }
        public void ClearBet() {
            MyBet.setAmount(0); // Reset my bet so it’s zero
        } 
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            return false;
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
        }

        public string getName()
        {
            return Name;
        }

        public void setBet(Bet bet)
        {
            this.MyBet = bet;
        }
    }
}
