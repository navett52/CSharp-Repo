using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellepet_Assignment06
{
    class TestMainMatt
    {
        static void Main(string[] args)
        {
            //intro to program
            Console.WriteLine("This program combines 8 different unique combinations of binary \nbits together, press enter to reveal the next combination");
            Console.ReadLine();
            //111 + 000
            Console.WriteLine("Adding 111 + 000");
            Console.WriteLine(Binary.AddBinary("111", "000"));
            Console.ReadLine();
            //111 + 011
            Console.WriteLine("Adding 111 + 011");
            Console.WriteLine(Binary.AddBinary("111", "011"));
            Console.ReadLine();
            //111 + 010
            Console.WriteLine("Adding 111 + 010");
            Console.WriteLine(Binary.AddBinary("111", "010"));
            Console.ReadLine();
            //111 + 001
            Console.WriteLine("Adding 111 + 001");
            Console.WriteLine(Binary.AddBinary("111", "001"));
            Console.ReadLine();
            //000 + 111
            Console.WriteLine("Adding 000 + 111");
            Console.WriteLine(Binary.AddBinary("000", "111"));
            Console.ReadLine();
            //000 + 100
            Console.WriteLine("Adding 000 + 100");
            Console.WriteLine(Binary.AddBinary("000", "100"));
            Console.ReadLine();
            //000 + 101
            Console.WriteLine("Adding 000 + 101");
            Console.WriteLine(Binary.AddBinary("000", "101"));
            Console.ReadLine();
            //000 + 110
            Console.WriteLine("Adding 000 + 110");
            Console.WriteLine(Binary.AddBinary("000", "110"));
            Console.ReadLine();
            //end the program
            Console.WriteLine("All combinations have been viewed, press enter to exit the program");
        }
    }
}
