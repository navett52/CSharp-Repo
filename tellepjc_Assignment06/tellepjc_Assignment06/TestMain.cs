/**Connor Tellep
 * Assignment 06
 * IT3045C Fall 2016
 * AddBinary Class
 * Due 10/06/16
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellepjc_Assignment06
{
    class TestMain
    {
        static void MainX(string[] args)
        {
            // Declares variables to count the passes and fails
            int passCount = 0;
            int failCount = 0;
            // Declares all Test pairs of operators to be used for testing purposes 
            // Normal test case
            string test1_1 = "11011.1001";
            string test1_2 = "1001.01101";

            // Normal test case 
            string test2_1 = "11.101";
            string test2_2 = "1001.01101";

            // Large binary number for a unique test case
            string test3_1 = "10110001010110011110101011.001111101011011011001";
            string test3_2 = "1100000001011101001.00000110111101011100110011";

            // Uses a number without a radix point 
            string test4_1 = "1011";
            string test4_2 = "11.0110";

            // Uses a number with multiple radix points to test validation
            string test5_1 = "11.101";
            string test5_2 = "10.01.01101";

            // Uses a number other than '1', '0', '.' to test validation
            string test6_1 = "11.1201";
            string test6_2 = "1001.01101";

            // Uses a letter to test validation
            string test7_1 = "11.101";
            string test7_2 = "10.01f01101";

            // Tests numbers that are exclusively less than one but add up to more than one
            string test8_1 = "0.101";
            string test8_2 = "0.101101";

            // Tests numbers that are exclusively less than one and add up to less than one
            string test9_1 = "0.00101";
            string test9_2 = "0.0101101";

            // Tests numbers that have no radix points
            string test10_1 = "11101";
            string test10_2 = "100110";

            // tests a number with no radix point and a nmber less than one
            string test11_1 = "11101";
            string test11_2 = "0.100101101";

            // tests numbers that begin with a radix point
            string test12_1 = ".0101";
            string test12_2 = ".01101";

            // tests a number with no radix point and a number that begins with a radix point
            string test13_1 = "11101";
            string test13_2 = ".01101";

            // The folowing lines of code run each pair of test values through the AddBinary method
            // All test cases have a pretested answer to validate the return
            // The results are trimmed of excess 0's to ensure proper validation of the results
            // The actual results along with the expected results are printed
            // if the test passes, then a counter is incremented
            // if the test fails, then a counter is incremented
            string result = Binary.AddBinary(test1_1, test1_2);            
            Console.WriteLine("Test1 result is " + result + ": Expected result 100100.11111");
            result.Trim('0');
            if (result.Equals("100100.11111"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test2_1, test2_2);
            Console.WriteLine("Test2 result is " + result + ": Expected result 1101.00001");
            result.Trim('0');
            if (result.Equals("1101.00001"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test3_1, test3_2);
            Console.WriteLine("Test3 result is " + result + ": Expected result 10110010110110101010010100.01000101101011001001010011");
            result.Trim('0');
            if (result.Equals("10110010110110101010010100.01000101101011001001010011"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test4_1, test4_2);
            Console.WriteLine("Test4 result is " + result + ": Expected result 1110.0110");
            result.Trim('0');
            if (result.Equals("1110.0110"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test5_1, test5_2);
            Console.WriteLine("Test5 result is " + result + ": Expected result Invalid Input");
            result.Trim('0');
            if (result.Equals("Invalid Input"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test6_1, test6_2);
            Console.WriteLine("Test6 result is " + result + ": Expected result Invalid Input");
            result.Trim('0');
            if (result.Equals("Invalid Input"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test7_1, test7_2);
            Console.WriteLine("Test7 result is " + result + ": Expected result Invalid Input");
            result.Trim('0');
            if (result.Equals("Invalid Input"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test8_1, test8_2);
            Console.WriteLine("Test8 result is " + result + ": Expected result 1.010101");
            result.Trim('0');
            if (result.Equals("1.010101"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test9_1, test9_2);
            Console.WriteLine("Test9 result is " + result + ": Expected result 0.1000001");
            result.Trim('0');
            if (result.Equals("0.1000001"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test10_1, test10_2);
            Console.WriteLine("Test10 result is " + result + ": Expected result 1000011.0");
            result.Trim('0');
            if (result.Equals("1000011.0"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test11_1, test11_2);
            Console.WriteLine("Test11 result is " + result + ": Expected result 11101.100101101");
            result.Trim('0');
            if (result.Equals("11101.100101101"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test12_1, test12_2);
            Console.WriteLine("Test12 result is " + result + ": Expected result 0.10111");
            result.Trim('0');
            if (result.Equals("0.10111"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            result = Binary.AddBinary(test13_1, test13_2);
            Console.WriteLine("Test13 result is " + result + ": Expected result 11101.01101");
            result.Trim('0');
            if (result.Equals("11101.01101"))
            {
                Console.WriteLine("Test Passed");
                passCount++;
            }
            else
            {
                Console.WriteLine("Test Failed");
                failCount++;
            }

            
            // prints a summary of the tests that were run
            Console.WriteLine();
            Console.WriteLine(passCount + " out of 13 Tests Passed");
            Console.WriteLine(failCount + " out of 13 Tests Failed");
        }
    }
}
