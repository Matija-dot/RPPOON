using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    class ClosedDiceRoller : IDiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public ClosedDiceRoller(int diceCount, int numberOfSides)
        {
            this.dice = new List<Die>(); 
            for (int i = 0; i < diceCount; i++) 
            { 
                this.dice.Add(new Die(numberOfSides)); 
            }
            this.resultForEachRoll = new List<int>();
        }

        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();            
            int i = 0;
            stringBuilder.Append("Closed Dice Roller (" + dice[i].NumberOfSides + " sided) - ROLL RESULTS\n");
            foreach (int result in this.resultForEachRoll)
            {
                i++;
                stringBuilder.Append(" Die " + i.ToString() + ": " + result.ToString() + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
