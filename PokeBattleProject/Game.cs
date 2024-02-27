using System;

namespace PokeBattleProject
{
	public class Game
	{
        private Random randomGenerator = new Random();

		public Game()
		{
            Console.WriteLine("");
            Console.WriteLine("*** NEW GAME STARTED ***");
            Console.WriteLine("");
		}

		public void Run()
		{
            // 2. The player gives a name to the first trainer.
            var answer1 = Program.Ask("Please enter a name for trainer 1");
            var trainer1 = new Trainer(answer1, randomGenerator);

            // 3. The player gives a name to the second trainer.
            var answer2 = Program.Ask("Please enter a name for trainer 2");
            var trainer2 = new Trainer(answer2, randomGenerator);

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("--- Round " + i.ToString() + " ---");

                // 4. The first trainer throws the first pokeball on its belt.
                // 5. The pokeball released the charmander and charmander does its battle cry.
                // see Trainer.throwPokeball() for implementation
                var pokemon1 = trainer1.ThrowPokeball();

                // 6. The second trainer throws the first pokeball on its belt.
                // 7. The pokeball released the charmander and charmander does its battle cry.
                // see Trainer.throwPokeball() for implementation
                var pokemon2 = trainer2.ThrowPokeball();

                // 8. The first trainer returns the charmander back to its pokeball.
                trainer1.returnPokemon(pokemon1);

                // 9. The second trainer returns the charmander back to its pokeball.
                trainer2.returnPokemon(pokemon2);
            }
            // 10. Repeat 4 to 9 until all pokeballs have been used by both trainers.
            // The player can quit or restart the game.
        }
    }
}

