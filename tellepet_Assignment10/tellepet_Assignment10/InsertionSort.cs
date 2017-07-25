using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Evan Tellep
/// Prof. Bill Nicholson
/// Assn. 10
/// 11/17/2016
/// Contempo Programming
/// Insertion sort!
/// Ref: My Java insertion sort
/// </summary>
namespace tellepet_Assignment10
{
    class InsertionSort
    {

        /**
         * An insertion sort
         * @param stringArray The array to be sorted by first character
         * @return the sorted array
         */
        public static String[] sort(String[] stringArray)
        {
            //Cycle through the original array
            for (int i = 1; i < stringArray.Length; i++)
            {
                //Set the current String at the index to x for safe keeping
                String x = stringArray[i].ToLower();
                //Set j to equal the index before the current index
                int j = i - 1;
                //Loop determines if the immediate previous indexes char is greater than the current char, and if it is, move the current char back 1 index
                while (j >= 0 && stringArray[j].ToLower().ElementAt(0) > x.ElementAt(0))
                {
                    //Replace the string at index i with the string at index j
                    stringArray[j + 1] = stringArray[j];
                    //Subtracts 1 from j to move backwards through the array
                    j = j - 1;
                }
                //Adds 1 back to j and inserts the current indexes number back into the array where it belongs
                stringArray[j + 1] = x;
            }
            //Returns the sorted array
            return stringArray;
        }

    }
}
