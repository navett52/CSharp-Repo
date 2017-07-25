/**
 * Created by Evan Tellep
 * Assignment 02
 * Due: 9/8/2016
 * IT3045C (Contemporary Programming)
 * Creating a config class for a vending machine
 * Ref: Stack overflow and Microsoft for examples and equivalents of C# code
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellepet_Assignment02
{
    static class Vendtron9001Config
    {
        //The type of currency to be used in this Vendtron machine
        private static string currencyType = "dollars";
        //The highest denomination of the chosen currency this machine will accept
        private static int highestDenominationAccepted = 10;
        //How fast the machine will dispense something
        private static int dispencementTimeSec = 4;
        //If true it will give back bills as change if enough money was given, if false will start dispensing with largest coin if enough money was entered
        private static Boolean billsBack = false;
        //Pick what voice the machine uses to thank customers
        private static string voicePreference = "female";
        //The language the machine speaks in
        private static string language = "english";
        //The volume of the voice in dB
        private static int volume = 5;
        //The language of the text on the screen
        private static string textLanguage = "english";
        //The prices of all products. 5 columns, 6 rows, 30 prices altogether, 30 products altogether
        //private static object[][][][] productPrices = new object[5][6][30][30];
        public static object[][] productInfo = new object[4][] {new object[5], new object[6], new object[30], new object[30] };
        //private static object[][][][] = new object[] {new int[5]{0,1,2,3,4,5}, new int[6], new Double[30], new String[30]};
        
        //Sets an entire row with a single price for convinience
        public static void setRowPrice(int row, double price)
        {
            int rowStartValue = 30 / 6 * row;
                for (int j = 0; j < ProductInfo[0].Length; j++)
                {
                    ProductInfo[2][rowStartValue] = price;
                    rowStartValue++;
                }
        }

        //Allows you to set the price of a single slot in the machine
        public static void setSlotPrice(int x, int y, double price)
        {
            ProductInfo[2][x * y] = price;
        }

        //Sets an entire row with a single product for convinience
        public static void setRowProduct(int row, string product)
        {
            int rowStartValue = 30 / 6 * row;
                for (int j = 0; j < ProductInfo[0].Length; j++)
                {
                    ProductInfo[3][rowStartValue] = product;
                    rowStartValue++;
                }
        }

        //Allows you to set the product of a single slot in the machine
        public static void setSlotProduct(int x, int y, string product)
        {
            ProductInfo[3][x * y] = product;
        }

        //Getter and Setters made for the above private fields
        public static string CurrencyType
        {
            get
            {
                return currencyType;
            }

            set
            {
                currencyType = value;
            }
        }

        public static int HighestDenominationAccepted
        {
            get
            {
                return highestDenominationAccepted;
            }

            set
            {
                if (highestDenominationAccepted < 100)
                {
                    highestDenominationAccepted = value;
                } else
                {
                    Console.WriteLine("Denomination too high! Please enter a value lower than 100");
                }
            }
        }

        public static int DispencementTimeSec
        {
            get
            {
                return dispencementTimeSec;
            }

            set
            {
                if (dispencementTimeSec > 3)
                {
                    dispencementTimeSec = value;
                } else
                {
                    Console.WriteLine("Dispenses too fast! Please enter a time greater than 3 seconds");
                }
                
            }
        }

        public static bool BillsBack
        {
            get
            {
                return billsBack;
            }

            set
            {
                billsBack = value;
            }
        }

        public static string VoicePreference
        {
            get
            {
                return voicePreference;
            }

            set
            {
                voicePreference = value;
            }
        }

        public static string Language
        {
            get
            {
                return language;
            }

            set
            {
                language = value;
            }
        }

        public static int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if (volume < 15)
                {
                    volume = value;
                } else
                {
                    Console.WriteLine("Volume too loud! Please enter a volume level less than 15dB.");
                }
                
            }
        }

        public static string TextLanguage
        {
            get
            {
                return textLanguage;
            }

            set
            {
                textLanguage = value;
            }
        }

        public static object[][] ProductInfo
        {
            get
            {
                return productInfo;
            }

            set
            {
                productInfo = value;
            }
        }
    }
}
