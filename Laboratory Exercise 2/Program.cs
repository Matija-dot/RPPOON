using System;

namespace Laboratory_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task 1
            DiceRoller diceRoller = new DiceRoller();
            Random randomGenerator = new Random();
            for (int i=0; i < 20; i++) 
            {
                diceRoller.InsertDie(new Die(randomGenerator.NextInt(4, 16)));
            }
            diceRoller.RollAllDice();
            Console.WriteLine(diceRoller);
            */

            /* Task 2
            DiceRoller diceRoller = new DiceRoller();
            Random randomGenerator = new Random();
            for (int i = 0; i < 20; i++)
            {
                diceRoller.InsertDie(new Die(randomGenerator.NextInt(4, 16)));
            }
            diceRoller.RollAllDice();
            Console.WriteLine(diceRoller);
            */

            /* Task 3
            DiceRoller diceRoller = new DiceRoller();
            RandomGenerator randomGenerator = RandomGenerator.GetInstance();
            for (int i = 0; i < 20; i++)
            {
                diceRoller.InsertDie(new Die(randomGenerator.NextInt(4, 16)));
            }
            diceRoller.RollAllDice();
            Console.WriteLine(diceRoller);
            */

            DiceRoller diceRoller = new DiceRoller();
            RandomGenerator randomGenerator = RandomGenerator.GetInstance();
            for (int i = 0; i < 20; i++)
            {
                diceRoller.InsertDie(new Die(randomGenerator.NextInt(4, 16)));
            }
            diceRoller.RollAllDice();
            diceRoller.LogRollingResults();
            FileLogger fileLogger = new FileLogger(Environment.CurrentDirectory + @"\RollingResults.txt");
            diceRoller.SetLogger(fileLogger);
            diceRoller.LogRollingResults();

            ClosedDiceRoller closedDiceRoller = new ClosedDiceRoller(10, 10);
            closedDiceRoller.RollAllDice();
            Console.WriteLine(closedDiceRoller);
            FlexibleDiceRoller flexibleDiceRoller = new FlexibleDiceRoller();
            for (int i = 0; i < 10; i++)
            {
                flexibleDiceRoller.InsertDie(new Die(randomGenerator.NextInt(4, 16)));
            }
            flexibleDiceRoller.RollAllDice();
            Console.WriteLine(flexibleDiceRoller);

            for (int numberOfSides = 4; numberOfSides <= 16; numberOfSides += 2)
            {
                flexibleDiceRoller.RemoveDiceWithSidesCount(numberOfSides);
            }
            Console.WriteLine(flexibleDiceRoller + "(only odd-sided dice rolls)");
        }
    }
}
