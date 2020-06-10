using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAvantTest.Core;

namespace WebAvantTest.Models
{
    public class MatrixViewModel
    {
        public int[] PrimeNumbers { get; set; }
        public long[,] Matrix { get; set; }

        //public MatrixViewModel(long[,] matrix, int[] primesNumbers)
        //{
        //    this.matrix = matrix;
        //    this.PrimesNumbers = primesNumbers;
        //}
        //public MatrixViewModel(int[] primesNumbers)
        //{
        //    //this.matrix = primesNumbers.matrix;
        //    //this.PrimesNumbers = primesNumbers.primesNumbers;
        //}
        public MatrixViewModel(PrimeNumbersTable primesNumbers)
        {
            this.Matrix = primesNumbers.matrix;
            this.PrimeNumbers = primesNumbers.primeNumbers;
        }

    }
}
