/**
 * Created by Evan Tellep
 * Assignment 04
 * Due: 9/20/2016
 * IT3045C (Contemporary Programming)
 * A Main to test my isPrime method for BigIntegers
 * Ref:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class MainBigIntPrimeness
    {
        static void Main(string[] args)
        {
            //Making a true BigInteger to use as a test case
            BigInteger largePrime = BigInteger.Parse("48112959837082048697");
            //Making a test array
            BigInteger[] test = new BigInteger[11] {1,2,3,5,7,21,53, 32416190071,456586747456, 32416188257, largePrime};
            //Making the array with the expected answers
            bool[] expected = new bool[11] {false,true,true,true,true,false,true,true,false,true, true};
            //Cycling through the test array and comparing the results from the isPrime() method to the expected results array
            for (int i = 0; i < test.Length; i++)
            {
                if (BigIntPrimeChecker.isPrime(test[i]) == expected[i])
                {
                    Console.WriteLine("PASS: The test of " + test[i] + " matched the expected value of " + expected[i] + ".");
                } else
                {
                    Console.WriteLine("FAIL: The test of " + test[i] + " didn't match the expected value of " + expected[i] + ".");
                }
            }
        }
    }
}
