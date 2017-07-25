/**
 * Created by Evan Tellep
 * Assignment 02
 * Due: 9/8/2016
 * IT3045C (Contemporary Programming)
 * Running tests for my config class
 * Ref: Stack overflow and Microsoft for examples and equivalents of C# code
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tellepet_Assignment02;

namespace tellepet_Assignment02
{
    class MainMethod
    {
        static void Main(string[] args)
        {   
            //Printing out the defaults of the config
            Console.WriteLine("Default Currency: " + Vendtron9001Config.CurrencyType + "\n" + "Default highest denomination accepted: " + Vendtron9001Config.HighestDenominationAccepted 
                + Vendtron9001Config.CurrencyType + "\n" + "Default dispencement time: " + Vendtron9001Config.DispencementTimeSec + "sec." + "\n" + "Use bills for change?: " 
                + Vendtron9001Config.BillsBack + "\n" + "Default voice setting: " + Vendtron9001Config.VoicePreference + "\n" + "Default voice language: " + Vendtron9001Config.Language + "\n" 
                + "Default text language: " + Vendtron9001Config.TextLanguage + "\n" + "Default Volume: " + Vendtron9001Config.Volume + "dB" + "\n" + "There are no defaults for product info.");
            Console.WriteLine();
            //All default values can be changed
            Vendtron9001Config.CurrencyType = "euro";
            Vendtron9001Config.HighestDenominationAccepted = 5;
            Vendtron9001Config.DispencementTimeSec = 6;
            Vendtron9001Config.BillsBack = true;
            Vendtron9001Config.VoicePreference = "male";
            Vendtron9001Config.Language = "japanese";
            Vendtron9001Config.Volume = 12;
            Vendtron9001Config.TextLanguage = "spanish";

            Vendtron9001Config.setRowProduct(0,"KitKat");
            Vendtron9001Config.setRowProduct(1, "Lays");
            Vendtron9001Config.setRowProduct(2, "MountainDew");
            Vendtron9001Config.setRowProduct(3, "Reeses");
            Vendtron9001Config.setRowProduct(4, "Poptarts");
            Vendtron9001Config.setRowProduct(5, "Nutty Bar");

            Vendtron9001Config.setRowPrice(0, 1);
            Vendtron9001Config.setRowPrice(1, .75);
            Vendtron9001Config.setRowPrice(2, 1.25);
            Vendtron9001Config.setRowPrice(3, 1);
            Vendtron9001Config.setRowPrice(4, 2.25);
            Vendtron9001Config.setRowPrice(5, .50);
            Console.WriteLine("Printing out the new values of the config");
            Console.WriteLine("Product info values can be set through entire rows.");
            //Printing out the new values of the config
            Console.WriteLine("New Currency: " + Vendtron9001Config.CurrencyType + "\n" + "New highest denomination accepted: " + Vendtron9001Config.HighestDenominationAccepted
                + Vendtron9001Config.CurrencyType + "\n" + "New dispencement time: " + Vendtron9001Config.DispencementTimeSec + "sec." + "\n" + "Use bills for change?: "
                + Vendtron9001Config.BillsBack + "\n" + "New voice setting: " + Vendtron9001Config.VoicePreference + "\n" + "New voice language: " + Vendtron9001Config.Language + "\n"
                + "New text language: " + Vendtron9001Config.TextLanguage + "\n" + "New Volume: " + Vendtron9001Config.Volume + "dB");
            for (int i = 0; i < Vendtron9001Config.ProductInfo[0].Length; i++)
            {
                int rowValue = 30 / 6 * i;
                for (int j = 0; j < Vendtron9001Config.ProductInfo[0].Length + 1; j++)
                {
                    Console.WriteLine("The products in row: " + i + " " + Vendtron9001Config.ProductInfo[3][rowValue]);
                    rowValue++;
                }
            }

            for (int i = 0; i < Vendtron9001Config.ProductInfo[0].Length; i++)
            {
                int rowValue = 30 / 6 * i;
                for (int j = 0; j < Vendtron9001Config.ProductInfo[0].Length + 1; j++)
                {
                    Console.WriteLine("The price in row: " + i + " " + Vendtron9001Config.ProductInfo[2][rowValue]);
                    rowValue++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("All product info can be set individually as well.");
            //All product info can be set individually as well
            Vendtron9001Config.CurrencyType = "euro";
            Vendtron9001Config.HighestDenominationAccepted = 5;
            Vendtron9001Config.DispencementTimeSec = 6;
            Vendtron9001Config.BillsBack = true;
            Vendtron9001Config.VoicePreference = "male";
            Vendtron9001Config.Language = "japanese";
            Vendtron9001Config.Volume = 12;
            Vendtron9001Config.TextLanguage = "spanish";

            Vendtron9001Config.setRowProduct(0, "KitKat");
            Vendtron9001Config.setSlotProduct(0, 3, "KitKat White Choc");
            Vendtron9001Config.setSlotProduct(0, 3, "KitKat Dark Choc");
            Vendtron9001Config.setRowProduct(1, "Lays");
            Vendtron9001Config.setSlotProduct(1, 2, "Lays Sour Cream & Onion");
            Vendtron9001Config.setSlotProduct(1, 3, "Lays Baked");
            Vendtron9001Config.setRowProduct(2, "MountainDew");
            Vendtron9001Config.setSlotProduct(2, 2, "MountainDew Code Red");
            Vendtron9001Config.setRowProduct(3, "Reeses");
            Vendtron9001Config.setRowProduct(4, "Poptarts");
            Vendtron9001Config.setRowProduct(5, "Nutty Bar");

            Vendtron9001Config.setRowPrice(0, 1);
            Vendtron9001Config.setRowPrice(1, .75);
            Vendtron9001Config.setRowPrice(2, 1.25);
            Vendtron9001Config.setRowPrice(3, 1);
            Vendtron9001Config.setRowPrice(4, 2.25);
            Vendtron9001Config.setRowPrice(5, .50);

            Console.WriteLine("New Currency: " + Vendtron9001Config.CurrencyType + "\n" + "New highest denomination accepted: " + Vendtron9001Config.HighestDenominationAccepted
                + Vendtron9001Config.CurrencyType + "\n" + "New dispencement time: " + Vendtron9001Config.DispencementTimeSec + "sec." + "\n" + "Use bills for change?: "
                + Vendtron9001Config.BillsBack + "\n" + "New voice setting: " + Vendtron9001Config.VoicePreference + "\n" + "New voice language: " + Vendtron9001Config.Language + "\n"
                + "New text language: " + Vendtron9001Config.TextLanguage + "\n" + "New Volume: " + Vendtron9001Config.Volume + "dB");

            for (int i = 0; i < Vendtron9001Config.ProductInfo[0].Length; i++)
            {
                int rowValue = 30 / 6 * i;
                for (int j = 0; j < Vendtron9001Config.ProductInfo[0].Length + 1; j++)
                {
                    Console.WriteLine("The products in row: " + i + " " + Vendtron9001Config.ProductInfo[3][rowValue]);
                    rowValue++;
                }
            }

            for (int i = 0; i < Vendtron9001Config.ProductInfo[0].Length; i++)
            {
                int rowValue = 30 / 6 * i;
                for (int j = 0; j < Vendtron9001Config.ProductInfo[0].Length + 1; j++)
                {
                    Console.WriteLine("The price in row: " + i + " " + Vendtron9001Config.ProductInfo[2][rowValue]);
                    rowValue++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are also a few validation rules.");
            /*private static string currencyType = "dollars";
private static int highestDenominationAccepted = 10;
private static int dispencementTimeSec = 3;
private static Boolean billsBack = false;
private static string voicePreference = "female";
private static string language = "english";
private static int volume = 5;
private static string textLanguage = "english";
public static object[][] productInfo = new object[4][] { new object[5], new object[6], new object[30], new object[30] };*/
            Vendtron9001Config.HighestDenominationAccepted = 1000;
            Vendtron9001Config.DispencementTimeSec = 1;
            Vendtron9001Config.Volume = 50;
            Console.WriteLine(Vendtron9001Config.HighestDenominationAccepted + "\n" + Vendtron9001Config.DispencementTimeSec + "\n" + Vendtron9001Config.Volume);
        }
    }
}
