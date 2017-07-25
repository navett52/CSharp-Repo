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
    public class InvalidStringException:Exception
    {
        public InvalidStringException(string message): base(message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Please use only 1's, 0's, and only one radix point!");
        }
    }
}
