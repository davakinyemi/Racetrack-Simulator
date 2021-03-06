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
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
            if (MyBet == null || MyBet.getAmount() == 0)
                MyLabel.Text = Name + " has not placed a bet yet";
            else
                MyLabel.Text = MyBet.GetDescription();

            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }
        public void ClearBet() {
            if(MyBet != null)
                MyBet.setAmount(0); // Reset my bet so it’s zero
        } 
        public void PlaceBet(int BetAmount, int DogToWin)
        {
            if(Cash >= BetAmount)
            {
                MyBet = new Bet(BetAmount, DogToWin, this);
                if(MyLabel.Text.Equals(Name + " has not placed a bet yet"))
                    Cash -= MyBet.getAmount();
            } else
            {
                MyLabel.Text = Name + "does not have enough cash to place bet";
            }
            UpdateLabels();
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my labels
            if(MyBet != null && MyBet.getAmount() != 0)
                Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }

        public string getName()
        {
            return Name;
        }
        
    }
}
