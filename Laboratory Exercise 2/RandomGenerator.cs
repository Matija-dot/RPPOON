using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    class RandomGenerator
    {
        private static RandomGenerator instance; 
        private Random random;
        
        private RandomGenerator()
        {
            this.random = new Random();
        } 

        public static RandomGenerator GetInstance()
        {
            if(instance == null)instance = new RandomGenerator();
            return instance;
        }
        public int NextInt(int lowerBound, int upperBound)
        {
            return random.Next(lowerBound, upperBound);
        }
    }
}
