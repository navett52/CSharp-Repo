/**
 * Created by Evan Tellep
 * Assignment 04
 * Due: 9/20/2016
 * IT3045C (Contemporary Programming)
 * Writing a method to check if a BigInteger is prime
 * Ref: Stack overflow - http://stackoverflow.com/questions/3432412/calculate-square-root-of-a-biginteger-system-numerics-biginteger
 *      Microsoft for examples and equivalents of C# code
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class BigIntPrimeChecker
    {
        /// <summary>
        /// Checks to see if a BigInteger is prime or not
        /// </summary>
        /// <param name="num">The BigInteger to be tested</param>
        /// <returns>True if the BigInt is prime</returns>
        public static bool isPrime(BigInteger num)
        {
            BigInteger two = new BigInteger(2);
            BigInteger limit = new BigInteger(0);
            if (num.CompareTo(two) != 0)
            {
                if (num % two == BigInteger.Zero) return false;
            }
            //Checks to see if 1 is entered. 1 is skipped over in the loop so we make a special case for 1.
            //Normally I would try to avoid special cases but this is the only one we need
            if (num == 1)
            {
                return false;
            }
            //Setting the limit 
            limit = Sqrt(num) + BigInteger.One;

            //Cycle through all numbers, starting from 2 (since all numbers are divisible by 1), smaller than the number to be checked
            for (BigInteger i = new BigInteger(3); i.CompareTo(limit) < 0; i = i + two)
            {
                //If a number is found that returns 0 as remainder the number is not prime and returns false
                if (num % i == BigInteger.Zero)
                    return false;
            }
            //If no number is found that returns a 0 remainder the number is prime.
            return true;
        }

        /// <summary>
        /// Finds the squareroot of a BigInteger number
        /// </summary>
        /// <param name="n">A BigInteger number</param>
        /// <returns>The squareroot of the BigInteger</returns>
        /// Gotten from http://stackoverflow.com/questions/3432412/calculate-square-root-of-a-biginteger-system-numerics-biginteger
        public static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        /// <summary>
        /// Checks to see if it is the squreroot
        /// </summary>
        /// <param name="n">The BigInteger number</param>
        /// <param name="root">The possible root</param>
        /// <returns>True if it is the squreroot</returns>
        /// Gotten from http://stackoverflow.com/questions/3432412/calculate-square-root-of-a-biginteger-system-numerics-biginteger
        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

    }
}
