/**************************************************************
 * Contemporary Programming Fall 2016
 * 3045C-001
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Midterm Exam
 Commented by Evan Tellep
 * ************************************************************/
using System;

namespace MidtermFall2016
{
    /// <summary>
    /// Butterfly Class. Models a Butterfly than can attack you
    /// </summary>
    class Butterfly : AnimalAttack
    {
        //Constructor
        public Butterfly(String species, String name) : base (species, name) { }
        //Inherited method that must be implemented
        override public String Attack()
        {
            return "I am " + name + ", a butterfly of the " + species + " species! I will flutter around you!";
        }
    }
}
