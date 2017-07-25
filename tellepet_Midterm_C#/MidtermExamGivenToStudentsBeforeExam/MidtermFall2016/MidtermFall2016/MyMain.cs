/**************************************************************
 * Contemporary Programming Fall 2016
 * 3045C-001
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Midterm Exam
 Done by Evan Tellep
    Polymorphism is great for a lot of reasons. First of all this is a huge factor in OOP
    programming. Having classes derive from another is a great way to show relationships
    between objects. Polymorphism is also convienient. It allows you to have derived classes
    that require a specific method to be implemented, but it gives you the freedom to
    define the method for each different derived class. Furthermore, if you derive a class
    and implement a method, if you do not implement that method in a class deriving the
    previously derived class, it defaults to what the first derived class was defined as.
    Polymorphism allows you to take full advantage of the OOP paradigm by allowing you
    to have better inheritence.

    Polymorphism is used throughout this entire project. It starts with the AnimalAttack class.
    That class is abstract. This is where all methods are stubs. Any class that derives from this class
    must then implement the methods that are stubs into it's own code. This allows you to have a lot of things
    with the same method but require different instructions to carry out that method, and in this case, that's
    the attack method.
 * ************************************************************/
using System;
using System.Collections.Generic;

namespace MidtermFall2016
{
    class MyMain
    {
        static void Main(string[] args)
        {
            //Creating a list to hold objects of the AnimalAttack type
            List<AnimalAttack> animalAttack = new List<AnimalAttack>();
            //Series of lines adding animals to the List
            animalAttack.Add(new Wombat("Lasiorhinus krefftii", "Wally"));
            animalAttack.Add(new Wombat("Vombatus ursinus", "Wanda"));
            animalAttack.Add(new Python("Antaresia maculosa", "Pauline"));
            animalAttack.Add(new Butterfly("Morpho menelaus", "Brenda"));
            animalAttack.Add(new BananaSlug("Ariolimax californicus", "Bob"));
            //Incrementing through the list and calling the Attack method for each
            //object of type AnimalAttack
            for (int i = 0; i < animalAttack.Count; i++)
            {
                Console.WriteLine(animalAttack[i].Attack());
            }

        }
    }
}
