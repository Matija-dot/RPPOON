using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    /* Task 4
    class DiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = new ConsoleLogger();
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultForEachRoll);
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
        public void SetLogger (ILogger logger)
        {
            this.logger = logger;
        }
        public void LogRollingResults()
        {
            logger.Log(this.ToString());
        }
        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("ROLL RESULTS\n");
            int i = 0;
            foreach (int result in this.resultForEachRoll)
            {
                i++;
                stringBuilder.Append("Die " + i.ToString() + ": " + result.ToString() + "\n");
            }
            return stringBuilder.ToString();
        }
    }
    */

    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = new ConsoleLogger();
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultForEachRoll);
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
        public void SetLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public void LogRollingResults()
        {
            logger.Log(this);
        }
        public string GetStringRepresentation()
        {
            return this.ToString();
        }
        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Dice Roller - ROLL RESULTS\n");
            int i = 0;
            foreach (int result in this.resultForEachRoll)
            {
                i++;
                stringBuilder.Append(" Die " + i.ToString() + " with " + dice[i - 1].NumberOfSides.ToString() + " sides: " + result.ToString() + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
