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
/// A class that reads a file and puts all contents into an array based on line
/// Ref: Boilerplate provided by Bill
/// </summary>
namespace tellepet_Assignment10
{
    class FileReader
    {

        // This is your boilerplate
        public String[] ReadTextFile(String filePath)
        {
            //Grabbing the amount of lines in the file to create an array with that many spaces
            int fileLineAmount = File.ReadLines(filePath).Count();
            String[] fileContents = new String[fileLineAmount];

            // Open the file, read all the lines, print to the console, close the file
            try
            {
                StreamReader sr = new StreamReader(filePath);     // using System.io
                String buffer;
                buffer = sr.ReadLine();
                // Read the first line in the file
                // loop through all the lines in the file.
                //Creating the counter so we can add each line to a different index in the array
                int counter = 0;
                while (buffer != null)
                {
                    fileContents[counter] = buffer;
                    counter++;
                    buffer = sr.ReadLine();                         // Read the next line in the file, if there is one.
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fileContents;
        }

    }
}
