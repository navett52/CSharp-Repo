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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tellepjc_Assignment06
{
    class Binary
    {
        // declares class level variables to be manipulated by multiple methods
        private static string operand1;
        private static string operand2;
        private static string result;

        /*
        * Method to add binary numbers and return a binary number stored in strings
        */
        public static string AddBinary(string op1, string op2)
        {
            // assigns value to the class level variables based on user input
            operand1 = op1;
            operand2 = op2;
            result = "";
            
            // sets the default carry value to 0
            char carry = '0';

            // checks both operands to see if there is a radix point in the string
            // if not, appends one on the end to be able to align operands
            if(!operand1.Contains('.'))
            {
                operand1 = operand1 + ".0";
            }
            if(!operand2.Contains('.'))
            {
                operand2 = operand2 + ".0";
            }

            // checks both operands to see if the number has a 0 before the radix point ex ".1101"
            // if the string begins with '.' a 0 is added so that it'll pass validation
            if(operand1[0] == '.')
            {
                operand1 = '0' + operand1;
            }
            if (operand2[0] == '.')
            {
                operand2 = '0' + operand2;
            }

            // runs the code to actually add the numbers if and only if both strings pass validation
            if (validateStrings(operand1, operand2))
            {
                // method that aligns the operands by radix point and ensures they have the same length
                alignRadix();

                // starts loop to add the binary numbers one column at a time
                for(int i = (operand1.Length - 1); i >= 0; i --)
                {
                    // starting from right to left, adds the digits of the operands and the carry
                    // puts the digits being added into a string to be used in the switch statement
                    string columnString = string.Concat(operand1[i], operand2[i], carry);

                    // switch statement that contains all 10 possiblities of the strings being added together
                    // 8 cases for adding numbers
                    // 2 cases for the radix point
                    // each case will append a digit to the result from right to left, building the answer one char at a time
                    // each case will set the appropriate carry value to be used in the addition process
                    switch (columnString)
                    {
                        case ("000"):
                            result = string.Concat('0', result);
                            carry = '0';
                            break;
                        case ("001"):
                            result = string.Concat('1', result);
                            carry = '0';
                            break;
                        case ("011"):
                            result = string.Concat('0', result);
                            carry = '1';
                            break;
                        case ("111"):
                            result = string.Concat('1', result);
                            carry = '1';
                            break;
                        case ("110"):
                            result = string.Concat('0', result);
                            carry = '1';
                            break;
                        case ("100"):
                            result = string.Concat('1', result);
                            carry = '0';
                            break;
                        case ("010"):
                            result = string.Concat('1', result);
                            carry = '0';
                            break;
                        case ("101"):
                            result = string.Concat('0', result);
                            carry = '1';
                            break;
                        case ("..0"):
                            result = string.Concat('.', result);
                            break;
                        case ("..1"):
                            result = string.Concat('.', result);
                            break;
                    }
                    
                }

                // if after all the calculations are done carry is equal to '1'
                // appends a '1' to the beginning of the string to get the correct value
                if (carry == '1')
                {
                    result = string.Concat('1', result);
                }
            }
            else
            {
                /* Was going to have a custom exception, but I couldn't get it to behave gracefully */
                //throw new InvalidStringException("Invalid Input, Please use only 1's, 0's, and only one radix point!");

                // returns an error message in case of bad input
                return "Invalid Input";
            }

            // formats the final string so that test results can be accurate
            // trims excess 0's from the beginning and end of string
            result.Trim('0');
            
            // if the result begins with a radix point, adds a 0 to the beginning of the string
            if (result[0] == '.')
            {
                result = '0' + result;
            }
            
            // if the result ends in a radix point, adds a 0 to the end
            if (result[(result.Length - 1)] == '.')
            {
                result = result + "0";
            }

            // returns the result
            return result;
        }



        /*
        * Method that aligns the two operands by radix point
        */
        private static void alignRadix()
        {
            // splits the operands at the radix point to compare both sides of the string
            // stores the strings in arrays
            string[] subOperand1 = operand1.Split('.');
            string[] subOperand2 = operand2.Split('.');

            // gets the difference in length between each side of the operands
            int stringOneDifference = subOperand1[0].Length - subOperand2[0].Length;
            int stringTwoDifference = subOperand1[1].Length - subOperand2[1].Length;

            // if the beginning part of operands are a different length, appends 0's to the beginning of the lesser string make them the same length
            if(stringOneDifference > 0)
            {
                for(int i = 0; i < stringOneDifference; i++)
                {
                    subOperand2[0] = '0' + subOperand2[0];
                }
            }
            else
            {
                for(int i = 0; i > stringOneDifference; i--)
                {
                    subOperand1[0] = '0' + subOperand1[0];
                }
            }

            // if the latter part of operands are a different length, appends 0's to end of the lesser string to make them the same length
            if (stringTwoDifference > 0)
            {
                for (int i = 0; i < stringTwoDifference; i++)
                {
                    subOperand2[1] = subOperand2[1] + '0';
                }
            }
            else
            {
                for (int i = 0; i > stringTwoDifference; i--)
                {
                    subOperand1[1] = subOperand1[1] + '0';
                }
            }

            // joins the operands together with an aligned radix point in the middle
            operand1 = subOperand1[0] + '.' + subOperand1[1];
            operand2 = subOperand2[0] + '.' + subOperand2[1];

        }

        /*
        * Method to validate the format of strings given
        * op1 = operand1
        * op2 = operand2
        */
        private static bool validateStrings(string op1, string op2)
        {
            // sets default return value
            bool result = false;
            
            // creates regular expression to ensure the only characters in the string are '1','0', or '.'
            Regex rgx = new Regex("^[01.]*$");

            // checks the given strings against the regular expression
            if(rgx.IsMatch(op1) && rgx.IsMatch(op2))
            {
                // sets a counter for radix points
                // planned to include this in the regular expression, but couldn't figure it out
                int radixCounter = 0;
                
                // sets a loop to count the number of '.' that appear in the first string
                for(int i = (op1.Length - 1); i > 0; i--)
                {
                    if(op1[i] == '.')
                    {
                        radixCounter++;
                    }
                }
                
                // given the formatting we did eariler, any valid string will have one and only one radix point
                if(radixCounter == 1)
                {
                    result = true;
                }
                else
                {
                    return false;
                }

                // resets radix counter
                radixCounter = 0;

                // sets a loop to count the number of '.' that appear in the second string
                for (int i = (op2.Length - 1); i > 0; i--)
                {
                    if (op2[i] == '.')
                    {
                        radixCounter++;
                    }
                }

                // given the formatting we did eariler, any valid string will have one and only one radix point
                if (radixCounter == 1)
                {
                    result = true;
                }
                else
                {
                    return false;
                }


            }

            // returns the result of the validation
            return result;
        }
    }
}
