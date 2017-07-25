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
    /// https://en.wikipedia.org/wiki/Wombat#Attacks_on_humans
    /// </summary>
    class Wombat : AnimalAttack
    {
        //Constructor
        public Wombat(String species, String name) : base (species, name) { }
        //Inherited method that must be implemented
        override public String Attack()
        {
            return "I am " + name + ", a wombat of the " + species + " species! I will charge you and knock you over or I will bite you!";
        }
    }
}
