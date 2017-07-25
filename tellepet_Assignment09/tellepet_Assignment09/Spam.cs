using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Evan Tellep
/// Prof. Bill Nicholson
/// Assignment 09
/// Due: 11/10/2016
/// Summary: A class to check for spam in an outlook message
/// I decided to use a queue for this assignment. I chose to use a queue because it's a data structure I don't use often.
/// It also runs quicker than a List. If I'm taking into account scalability then I feel a queue would be a better
/// choice to use for a list that might grow to be very large. As it is now my list is but a portion of most spam
/// word lists.
/// </summary>
namespace tellepet_Assignment09
{
    class Spam
    {
        //Setting the list of words we consider spam
        private static Queue<String> spamList = new Queue<String>(new[] {"Now", "Winner", "The", "Free", "Credit", "Fast", "Free",
            "Act", "First", "Last", "Here", "Quick", "Online", "Oppurtunity", "Prices", "Increase", "Income", "Home", "Cash",
            "Obligation", "Info", "Leave", "Apply", "Billion", "And", "Debt", "Card", "Bit", "Cloud", "Deterministic"});

        /// <summary>
        /// Loops through the spam queue and increments everytime a spam word is found
        /// </summary>
        /// <param name="msg">The message to be checked for spam</param>
        /// <returns>The number of spam word ocurences throughout the message</returns>
        public static int spamCheck(string msg)
        {
            //Initializing the count of spam words
            int spamCount = 0;
            //Setting the message to all upper case to ignore case
            msg = msg.ToUpper();
            //Loop to cycle through the spam queue
            for (int i = 0; i < spamList.Count; i++)
            {
                //Popping the word out of the queue and into a variable
                string word = spamList.Dequeue().ToUpper();
                //getting the index of the first occurence of the word
                int index = msg.IndexOf(word);
                //while an instance of the word is still being found within the method...
                while (index >= 0)
                {
                    //Incrememnt the spam count and then set the index to start searching from where that word was found plus one to start searching the string after that instance of the word
                    index = msg.IndexOf(word,index + 1);
                    spamCount++;
                }
            }
            //Finally return the count of the spam words found
            return spamCount;
        }
    }
}
