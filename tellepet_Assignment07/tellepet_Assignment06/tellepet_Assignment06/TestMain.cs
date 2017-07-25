using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Created by Evan Tellep
 * Assignment 06
 * Due: 10/6/2016
 * IT3045C (Contemporary Programming)
 * Test Main to test Binary.cs
 * Ref: Old Code, http://www.exploringbinary.com/binary-calculator/ <- used to get the answers to my test cases
 */

namespace tellepet_Assignment06
{
    class TestMain
    {
        static void MainX(string[] args)
        {
            //Counters to count how many tests were passed and how many were failed
            int passCount = 0;
            int failCount = 0;
            //string arrays holding the op1 valuse, the op2 values, and the correct answers
            string[] testOp1 = new string[20] {"10110.100", "10011.1001.110010101", "100104.110410", "10.1", "0010110110010100101100101001.10010100101001011001",
                "101010010110010100.100101", "100101", ".10010", "1010001.1", "0110001010.0111001", "100101", "", ".", "1010", "1", "0", "00000011010.00101",
                "1100101.011011", "111111111111.1111111111111", "111111111111111.000000000000000"};

            string[] testOp2 = new string[20] { "10010.10", "1", "10010.001011001", "1001.1001", "1001.", ".01001", "0", "1010910", "1001.010", "0100110",
                "0111001101011001.010101100101", "111.", "1001010", "01011001..1001", "0101011001.111111", "01010101010101.010101010", "01001.001", "0102--3=23rk",
                "0111111.00101001", "111100.001010" };

            string[] answers = new string[20] { "101001", "Fail", "Fail", "1100.0001", "10110110010100101100110010.10010100101001011001",
                "101010010110010100.110111", "100101", "Fail", "1011010.11", "110110000.0111001", "111001101111110.010101100101", "Fail",
                "Fail", "Fail", "101011010.111111", "1010101010101.01010101", "100011.01001", "Fail", "1000000111111.0010100011111", "1000000000111011.00101"};
            //Looping through my arrays and testing the answers
            for (int i = 0; i < 20; i++)
            {
                //Console.WriteLine("Test: " + i);
                string result = Binary.AddBinary(testOp1[i], testOp2[i]).Trim('0');
                result = result.Trim('.');
                if (result == answers[i])
                {
                    //Console.WriteLine(answers[i]);
                    Console.WriteLine(testOp1[i] + " + " + testOp2[i] + " = " + answers[i]);
                    Console.WriteLine("PASSED");
                    passCount++;
                } else if (result == "caught") {
                    Console.WriteLine("An Error was caught.");
                    Console.WriteLine("PASSED");
                    passCount++;
                } else
                {
                    Console.WriteLine("FAILED");
                    failCount++;
                }
            }
            Console.WriteLine("You have PASSED: " + passCount + " tests.");
            Console.WriteLine("You have FAILED: " + failCount + " tests.");
        }
    }
}
