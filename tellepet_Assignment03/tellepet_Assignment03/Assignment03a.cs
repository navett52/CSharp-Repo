/**
 * Written by Bill Nicholson
 * Tested by Evan Tellep
 * Assignment 03
 * Due: 9/15/2016
 * IT3045C (Contemporary Programming)
 * A class containing an isPalindrome method that is tested in the main
 * Ref:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellepet_Assignment03
{
    class Assignment03a
    {
        public static Boolean isPalindrome(double num)
        {
            //Checks if the netered value is between 10,000 and 100,000
            if (num >= 10000 && num < 100000)
            {
                //Putting the number given into oldNum for safe keeping so we can compare the numbers later
                double oldNum = num;
                //First dig checks to see what the right-most number of the larger number is
                double FirstDig = num % 10;
                //then we remove that number from num
                num = num - (num % 10);
                //Second dig checks to see what the next number from the right is
                double SecondDig = num % 100;
                //then we remove that number from num
                num = num - (num % 100);
                //Third dig does the same thing as First and Second but for the 3rd digit from the right
                double ThirdDig = num % 1000;
                //Then we remove the thrid digit from the right from num
                num = num - (num % 1000);
                //Same with fourth dig
                double FourthDig = num % 10000;
                num = num - (num % 10000);
                //Same with fifth dig
                double FifthDig = num % 100000;
                num = num - (num % 100000);
                //We divide the digs by their respective place values
                FirstDig = FirstDig / 10;
                SecondDig = SecondDig / 100;
                ThirdDig = ThirdDig / 1000;
                FourthDig = FourthDig / 10000;
                FifthDig = FifthDig / 100000;
                //Then add them all together and multiply them by 100,000 to get the "flippedNum"
                double flippedNum = FirstDig + SecondDig + ThirdDig + FourthDig + FifthDig;
                flippedNum = flippedNum * 100000;
                //Checks to see if the "flippedNum" is equal to the given number
                if (flippedNum == oldNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

