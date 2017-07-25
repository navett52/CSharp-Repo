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
    //Abstract class to model an animal that attacks
    abstract class AnimalAttack
    {
        //Two properties every animal that attacks needs to have
        private String mName, mSpecies;
        //Getter and Setter for name
        public String name
        {
            get { return mName; }
            set { mName = value; }
        }
        //Getter and Setter for species
        public String species
        {
            get { return mSpecies; }
            set { mSpecies = value; }
        }
        //Stub for Attack method
        public abstract String Attack();
        //Constructor
        public AnimalAttack(String species, String name)
        {
            this.species = species;
            this.name = name;
        }
    }
}
