/**
 * Created by Evan Tellep
 * Assignment 03
 * Due: 9/15/2016
 * IT3045C (Contemporary Programming)
 * The test main to see if the isPalindrome method works
 * Ref:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellepet_Assignment03
{
    class TestMain
    {
        static void Main(string[] args)
        {
            Double[] testCases = new Double[18] { 9999, 10000, 10001, 16461, 14941, 24442, 36763, 40504, 30303, 50000, 52525, 67876, 70607, 89798, 100001, 45678, 34675, 23654};
            Boolean[] expectedAnswers = new Boolean[18] { false, false, true, true, true, true, true, true, true, false, true, true, true, true, false, false, false, false };
            int failCount = 0;
            int passCount = 0;
            //Looping through the test cases and comparing them to the expected answers
            for (int i = 0; i < testCases.Length; i++)
            {
                Boolean returnedAnswer = Assignment03a.isPalindrome(testCases[i]);
                if (testCases[i] < 10000)
                {
                    Console.WriteLine("The test case of " + testCases[i] + " is less than 10,000.");
                    Console.WriteLine("The test passed!");
                    passCount++;
                }
                else if (testCases[i] >= 100000)
                {
                    Console.WriteLine("The test case of " + testCases[i] + " is greater than 100,000.");
                    Console.WriteLine("The test passed!");
                    passCount++;
                }
                else if (returnedAnswer == expectedAnswers[i])
                {
                    Console.WriteLine("The returned result of " + returnedAnswer + " for number " + testCases[i] + " matches the expected result of " + expectedAnswers[i] + ".");
                    Console.WriteLine("The test passed!");
                    passCount++;
                }
                else
                {
                    Console.WriteLine("The returned result of " + returnedAnswer + " for number " + testCases[i] + " does not match the expected result of " + expectedAnswers[i] + ".");
                    Console.WriteLine("The test failed!");
                    failCount++;
                }
            }
            //Telling the user how many tests passed and how many tests failed.
            Console.WriteLine("The method passed a total of: " + passCount + " tests.");
            Console.WriteLine("The method failed a total of: " + failCount + " tests.");
        }
    }
}
