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
    /// Python Class. Models a Python than can attack you
    /// </summary>
    class Python : AnimalAttack
    {
        //Constructor
        public Python(String species, String name) : base (species, name){}
        //Inherited method that must be implemented
        override public String Attack()
        {
            return "I am " + name + ", a python of the " + species + " species! I will bite you and then constrict you!";
        }
    }
}
