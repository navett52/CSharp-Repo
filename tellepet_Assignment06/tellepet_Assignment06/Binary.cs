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
 * A class used to verify and add binary numbers
 * Ref: Old Code, MSDN
 */

namespace tellepet_Assignment06
{
    class Binary
    {
        /// <summary>
        /// Adds two binary numbers together.
        /// </summary>
        /// <param name="op1">The first number.</param>
        /// <param name="op2">The second number.</param>
        /// <returns>The added value in binary.</returns>
        public static string AddBinary(string op1, string op2)
        {
            //Instantiating a result to then be returned 
            string result = "";
            //Checks if the numbers entered are valid
            if (validateNumber(op1) == "true" && validateNumber(op2) == "true")
            {
                //Aligns the numbers based on radix point
                string[] numbers = alignBinaryNumbers(op1, op2);
                //Grabbing the aligned numbers out of the returned array
                op1 = numbers[0];
                op2 = numbers[1];
                //declaring values to build the sequences made from stacking the aligned binary numbers
                string char1 = "";
                string char2 = "";
                string carry = "0";
                string sequence = "";
                //Loops through the numbers generating sequences and adding them
                for (int i = op1.Length - 1; i >= 0; i--)
                {
                    //Checks for the radix point and adds it at the appropriate index
                    if (op1[i] != '.') {
                        //instantiating the string that build the sequence
                        char1 = op1[i] + "";
                        char2 = op2[i] + "";
                        sequence = char1 + char2 + carry;
                        //Checks the sequence to find the matching sequence
                        //When a match is found the addition occurs and the result is generated case by case
                        switch (sequence)
                        {
                            case "000":
                                {
                                    result = "0" + result;
                                    carry = "0";
                                    break;
                                }
                            case "001":
                                {
                                    result = "1" + result;
                                    carry = "0";
                                    break;
                                }
                            case "010":
                                {
                                    result = "1" + result;
                                    carry = "0";
                                    break;
                                }
                            case "011":
                                {
                                    result = "0" + result;
                                    carry = "1";
                                    break;
                                }
                            case "100":
                                {
                                    result = "1" + result;
                                    carry = "0";
                                    break;
                                }
                            case "101":
                                {
                                    result = "0" + result;
                                    carry = "1";
                                    break;
                                }
                            case "110":
                                {
                                    result = "0" + result;
                                    carry = "1";
                                    break;
                                }
                            case "111":
                                {
                                    result = "1" + result;
                                    carry = "1";
                                    break;
                                }
                        }
                    }
                    else
                    {
                        result = "." + result;
                    }
                }
                if (carry == "1")
                {
                    result = "1" + result;
                }
            } else
            {
                if (validateNumber(op1) != "true")
                {
                    Console.WriteLine(validateNumber(op1));
                    result = "caught";
                } else
                {
                    Console.WriteLine(validateNumber(op2));
                    result = "caught";
                }
            }
            return result;
        }

        /// <summary>
        /// Takes two binary numbers and aligns them based on their radix points.
        /// </summary>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        /// <returns></returns>
        private static string[] alignBinaryNumbers(string op1, string op2)
        {
            //a counter to check for a radix
            int radixCheck = 0;
            //Checking for a radix in op1
            foreach (char num in op1)
            {
                if (num == '.')
                {
                    radixCheck++;
                }
            }
            //Add a radix to the very right if no radix in op1 is found
            if (radixCheck == 0)
            {
                op1 = op1 + ".";
            }

            radixCheck = 0;
            //Checking for a radix in op2
            foreach (char num in op2)
            {
                if (num == '.')
                {
                    radixCheck++;
                }
            }
            //Add a radix to the very right if no radix in op2 is found
            if (radixCheck == 0)
            {
                op2 = op2 + ".";
            }
            //Grabbing all numbers left of the radix point for each number
            string op1Left = op1.Substring(0, op1.IndexOf('.'));
            string op2Left = op2.Substring(0, op2.IndexOf('.'));
            //Checks to see if the left side of each number is of the same length
            if (op1Left.Length != op2Left.Length)
            {
                //If they are not of the same length we need to add zeros until they are the same length
                while (op1Left.Length < op2Left.Length)
                {
                    op1Left = "0" + op1Left;
                }
                while (op1Left.Length > op2Left.Length)
                {
                    op2Left = "0" + op2Left;
                }
            }
            //Grabbing all numbers right of the radix point for each number
            string op1Right = op1.Substring(op1.IndexOf('.'), op1.Length - op1.IndexOf('.'));
            string op2Right = op2.Substring(op2.IndexOf('.'), op2.Length - op2.IndexOf('.'));
            //Checks to see if the right side of each number is of the same length
            if (op1Right.Length != op2Right.Length)
            {
                //If they are not of the same length we need to add zeros until they are the same length
                while (op1Right.Length < op2Right.Length)
                {
                    op1Right = op1Right + "0";
                }
                while (op1Right.Length > op2Right.Length)
                {
                    op2Right = op2Right + "0";
                }
            }

            //Adding the left and right side of each number back together
            op1 = op1Left + op1Right;
            op2 = op2Left + op2Right;
            //Returns a string array that holds the now aligned binary numbers
            return new string[2] {op1, op2};
        }

        /// <summary>
        /// Validates if a string entered is in the format of a correct binary number.
        /// </summary>
        /// <param name="op">The operator to check.</param>
        /// <returns>True if it is a valid binary number.</returns>
        /// <author>Evan Tellep</author>
        private static string validateNumber(string op)
        {
            //Create a result to be returned. Assume correctness
            string result = "true";
            //Creating a variable to count how many radix points are in a number
            int radixCounter = 0;
            //Checking if the entered value is just a radix point.
            if (op == ".")
            {
                result = "The entered value is just a radix point";
            }
            //If the number entered has too many characters
            if (op.Length >= 1073741823) //This number is the max amount of chars that a string can have (http://stackoverflow.com/questions/140468/what-is-the-maximum-possible-length-of-a-net-string)
            {
                result = op + " is too large a number. Please enter a smaller number";
            }
            //If the number is blank let them know
            if (op == null || op.Length <= 0)
            {
                result = "You have not entered a number. Please enter a number.";
            }
            //Checking if the chars are all 1, 0, or .
            foreach (char num in op)
            {
                //Checking if the chars are all 1, 0, or .
                if (num != '1' && num != '0' && num != '.')
                {
                    result = "An invalid character has been entered in the number. Please review your number and try again.";
                }
                //If there is a . it increments the radixCounter
                if (num == '.')
                {
                    radixCounter++;
                    //If there is more than 1 radix this is not a valid string
                    if (radixCounter > 1)
                    {
                        result = "There are more than 1 radix points in the entered value. Please have only 0 or 1 radix points.";
                    }
                }
            }
            //Return true if string is valid, false otherwise
            return result;
        }

    }
}
