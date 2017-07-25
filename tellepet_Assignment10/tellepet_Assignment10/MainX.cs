using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Evan Tellep
/// Prof. Bill Nicholson
/// Assn. 10
/// 11/17/2016
/// Contempo Programming
/// Grabbing the contents of a jumbled file, sorting them, and then writing them back to a file
/// Ref: n/a
/// </summary>
namespace tellepet_Assignment10
{
    class MainX
    {
        static void Main(string[] args)
        {
            //grabbing and reading the file of our choice to an array
            FileReader fr = new FileReader();
            String[] test = fr.ReadTextFile("../../../jumbled english FILTERED.ALL.txt");
            //sorting the array
            InsertionSort.sort(test);
            //Writing the sorted contents to a file
            File.WriteAllLines("../../../english FILTERED.ALL.txt", test);
        }
    }
}
