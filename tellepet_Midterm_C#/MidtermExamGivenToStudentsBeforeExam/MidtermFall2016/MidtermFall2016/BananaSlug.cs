using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
 * Contemporary Programming Fall 2016
 * 3045C-001
 * By Evan Tellep
 * Banana Slug class that cannot attack
 * Midterm Exam
 * ************************************************************/
namespace MidtermFall2016 {
    class BananaSlug : AnimalAttack {
        //Constructor
        public BananaSlug(String species, String name) : base (species, name) { }
        //Inherited method that must be implemented
        override public String Attack() {
            //Banan slug tres to attack, will malfunction cause it cannot attack
            try {
                throw new Exception("Error... Exception caught.. Banana Slug overloading... Reboot");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return "I am " + name + ", a banana slug of the " + species + " species! I will do nothing to you cause I have no attacks!";
        }
    }
}
