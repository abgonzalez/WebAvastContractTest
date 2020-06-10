using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WebAvantTest.Core
{
    public class FindPrimeNumber
    {

        public static int[] findPrimes(int N)
        {
            IList<int> result = new List<int>();
            for (int i = 1; result.Count() < N + 1; i++)
            {
                if (isPrime(i))
                    result.Add(i);

            }
            return result.ToArray();
        }

        public static Boolean isPrime(int n)
        {
            if (n == 1)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
