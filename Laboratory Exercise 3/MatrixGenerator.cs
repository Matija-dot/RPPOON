using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_3
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;

        private MatrixGenerator()
        {
            this.generator = new Random();
        }

        public static MatrixGenerator GetInstance() 
        { 
            if (instance == null) 
            { 
                instance = new MatrixGenerator();               
            } 
            return instance; 
        }
        public double[][] Next(int rowCount, int columnCount)
        {
            double[][] matrix = new double[rowCount][];
            for(int i = 0; i < rowCount; i++)
            {
                matrix[i] = new double[columnCount];
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            }
            return matrix;
        }
    }
}
