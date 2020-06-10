using WebAvantTest.Core;
using Xunit;

namespace UnitTestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestOneNumber()
        {
            const int N = 1;
            long[,] resul = new long[N + 1, N + 1] {
                     {4,6} ,   /*  initializers for row indexed by 0 */
                     {6,9}
                };

            Assert.Equal(resul, new PrimeNumbersTable(FindPrimeNumber.findPrimes(N)).matrix);
        }
        [Fact]
        public void TestTwoNumber()
        {
            const int N = 2;
            long[,] resul = new long[N + 1, N + 1] {
                     {4,6,10} ,   /*  initializers for row indexed by 0 */
                     {6,9,15},   /*  initializers for row indexed by 1 */
                     {10,15,25}   /*  initializers for row indexed by 2 */
                };

            Assert.Equal(resul, new PrimeNumbersTable(FindPrimeNumber.findPrimes(N)).matrix);  
        }
        [Fact]
        public void TestThreeNumber()
        {
            const int N = 3;
            long[,] resul = new long[N + 1, N + 1] {
                     {4,6,10,14} ,   /*  initializers for row indexed by 0 */
                     {6,9,15,21} ,   /*  initializers for row indexed by 1 */
                     {10,15,25,35},   /*  initializers for row indexed by 2 */
                     {14,21,35,49}   /*  initializers for row indexed by 3 */
                };
            Assert.Equal(resul, new PrimeNumbersTable(FindPrimeNumber.findPrimes(N)).matrix);
        }

    }
}
