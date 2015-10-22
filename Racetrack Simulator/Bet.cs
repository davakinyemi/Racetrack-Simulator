using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racetrack_Simulator
{
    class Bet
    {
        private int Amount; // The amount of cash that was bet
        private int Dog; // The number of the dog the bet is on
        private Bettor bettor; // The guy who placed the bet

        public Bet(int amount, int dog, Bettor bettor)
        {
            this.Amount = amount;
            this.Dog = dog;
            this.bettor = bettor;
        }

        public string GetDescription()
        {
            // Return a string that says who placed the bet, how much
            // cash was bet, and which dog he bet on ("Joe bets 8 on
            // dog #4"). If the amount is zero, no bet was placed
            // ("Joe hasn’t placed a bet").
            return bettor.getName() + " bets " + Amount + " on dog #" + Dog;
        }
        public int PayOut(int Winner)
        {
            // The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of
            // the amount bet.
            return 0;
        }

        public void setAmount(int x)
        {
            Amount = x;
        }

        public int getAmount()
        {
            return Amount;
        }
    }
}
