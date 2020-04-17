using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    class Die
    {
        /* Task 1
        private int numberOfSides;
        private Random randomGenerator;
        
        public Die(int numberOfSides) 
        { 
            this.numberOfSides = numberOfSides; 
            this.randomGenerator = new Random(); 
        }

        public int Roll() 
        { 
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1); 
            return rolledNumber; 
        }
        */

        /* Task 2
        private int numberOfSides;
        private Random randomGenerator;

        public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }

        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
        */

        private int numberOfSides;

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }

        public int NumberOfSides
        {
            get { return this.numberOfSides; }
        }
        public int Roll()
        {
            RandomGenerator randomGenerator = RandomGenerator.GetInstance();
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
