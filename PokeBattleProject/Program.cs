using System;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PokeBattleProject { 

public class Program {

        /*
        Na afloop van alle assignemnts, kan ik toepassen en uitleggen:
        - Classes en objects
        - Composition en Inheritance
        - Abstract classes en methods
        - Static variables en methods
        - Encapsulation
        - Visibility modifiers
        - Getters en setters
        */

        /*
        Na afloop van assignment 1 kan ik:
        - Je legt mondeling uit wat de waarde en denkwijze is van object-oriented programming.
        - Je herkent de volgende keywords: class, new, void en null.
        - Je programmeert een class met fields, een constructor en methods.

        Opdracht

        V Create a Charmander class.
        V   A charmander has a nickname, fire as its strength, and water as its weakness.
        V   A charmander can use a battle cry by yelling its own name.
          There are restrictions to the Charmander class:
        V   The Charmander class has a constructor for all its fields.
        V   The Charmander class doesn't use a field for its battle cry.

            Create a simple pokemon battle simulator.
            The game is text-based and you can only make use of the console. You'll have use the built-in libraries of your chosen programming language. For example, System class (Java), Scanner class (Java) and Console class (C#).
            The game consists of a simple gameplay loop:
        V   1. The player start the game.           (door het programma te runnen)
        V   2. The player gives a name to a charmander.
        V   3. The charmander does its battle cry for ten times.
        V   4. The player can give a new name to the same charmander.
        V   5. The charmander does its battle cry for ten times.
        V   6. Repeat 4 and 5 until the player quits the game.
            Pro-tip: Copy the above steps, use them as code comments, and write the code underneath each step.

        Je beantwoordt de volgende vragen in het Engels met minimaal 100 woorden in jouw cheatsheet.
            Why would you want to write you code in a object-oriented programming language?
            What's the difference between a class and an object?
        */

        /*
         *
        Assignment 2: Composition
        Deze opdracht gaat over het samenwerken tussen meerdere objecten en de moeilijkheden die erbij komen kijken.
        Het gaat ook over composition, waarbij een object uit meerdere objecten kan bestaan.

        Leerdoelen
        - Je herkent de volgende keywords: null en List<<Collection>>.
        - Je legt mondeling uit wat 'composition' is en hoe het is toegepast door een code voorbeeld in de opdracht te laten zien.
        - Je combineert meerdere classes samen tot een complex object aan de hand van composition.
        - Je past error handling toe in een class aan de hand van de Exception class met een try en catch.

        Opdracht

        Create a Pokeball class.
        V - The pokeball is empty or it can contain a single charmander.
        V - The pokeball can be thrown, which opens it up, and
        V   then releases the charmander inside of it.   (implemented by calling Battlecry()
        V The charmander can be returned back to its pokeball, which closes the pokeball again.

        Create a Trainer class.
        V The trainer has a name and a belt with six pokeballs with each a charmander inside of them.
        - The trainer can throw a pokeball from their belt.
        - The trainer can return a pokemon back to its pokeball and put the pokeball back on their belt.
        - There are restrictions to the Trainer class:
        - The belt has six pokeballs with a Charmander in each of them. If it's more than six, then you'll throw an exception.
        - The belt cannot be an array but has to be a List<Pokeball> class.

        Create a simple pokemon battle simulator.
        The game consists of a simple gameplay loop:
        1. The player starts the game.
        2. The player gives a name to the first trainer.
        3. The player gives a name to the second trainer.
        4. The first trainer throws the first pokeball on its belt.
        5. The pokeball released the charmander and charmander does its battle cry.
        6. The second trainer throws the first pokeball on its belt.
        7. The pokeball released the charmander and charmander does its battle cry.
        8. The first trainer returns the charmander back to its pokeball.
        9. The second trainer returns the charmander back to its pokeball.
        10. Repeat 4 to 9 until all pokeballs have been used by both trainers.
        The player can quit or restart the game.
        Pro-tip: Use a separate file for each class instead of using one long file.
        Je beantwoordt de volgende vragen in het Engels met minimaal 100 woorden in jouw cheatsheet.
        What is compostion?
        Why do we use composition?
        How do we use composition in our code?

        */

        static void Main(string[] args)
        {
            PrintBannerToConsole();
            
            while (true)
            {
                // 1. The player starts the game.
                string[] correctAnswers = { "yes", "no" };
                var start = Ask("Do you want to start a new game? (yes/no)", correctAnswers);
                if (start == "no")
                {
                    Console.WriteLine("Bye!");
                    System.Environment.Exit(1); // stop the program
                }

                // Create Game object and run it
                Game g = new Game();
                g.Run();

            }
            // The player can quit or restart the game > implemented by question at the start

        }

        public static void PrintBannerToConsole()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("* Pokemon Battle Simulator *");
            Console.WriteLine("****************************");
            Console.WriteLine("");
        }
        
        public static String Ask(String question, string[]? validOptions = null)
        {
            while (true)
            {
                Console.Write(question + ": ");
                var answer = Console.ReadLine();
                if(answer.Length == 0)
                {
                    Console.WriteLine("Empty input not allowed, please type something.");
                    continue;
                }

                if (validOptions != null && validOptions.GetType().IsArray )
                {
                    if (validOptions.Contains(answer))
                    {
                        return answer;
                    }
                    else
                    {
                        Console.WriteLine("Please use one of these answers: " + String.Join(", ", validOptions));
                    }
                }
                else
                {
                    return answer;
                }
            }


        }




}   // end of class
}   // end of namespace