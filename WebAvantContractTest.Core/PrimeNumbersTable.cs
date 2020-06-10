using System;

namespace WebAvantTest.Core
{
    public class PrimeNumbersTable
    {
        public int x { get; set; }
        public int[] primeNumbers { get; set; }
        public long[,] matrix { get; set; }
        public PrimeNumbersTable(int[] input)
        {
            this.x = input.Length;
            this.primeNumbers = input;
            this.matrix = new long[x, x];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                    matrix[i, j] = input[i] * input[j];

            }
        }

    }
}
