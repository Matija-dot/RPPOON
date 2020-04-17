using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    class FlexibleDiceRoller : IDiceRoller, IFlexibleDice
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public FlexibleDiceRoller()
        { 
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }

        public void InsertDie(Die die)
        { 
            dice.Add(die);
        }
        public void RemoveAllDice() 
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RemoveDiceWithSidesCount(int numberOfSides)
        {
            for (int i = 0; i < this.dice.Count; i++)
            {
                if (this.dice[i].NumberOfSides == numberOfSides)
                {
                    this.dice.RemoveAt(i);
                    this.resultForEachRoll.RemoveAt(i);
                    i--;
                }
            }
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
            stringBuilder.Append("Flexible Dice Roller - ROLL RESULTS\n");
            int i = 0;
            foreach (int result in this.resultForEachRoll)
            {
                i++;
                stringBuilder.Append(" Die " + i.ToString() + " with " + dice[i-1].NumberOfSides.ToString() + " sides: " + result.ToString() + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
