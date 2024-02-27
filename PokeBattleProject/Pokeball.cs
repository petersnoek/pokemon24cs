using System;
namespace PokeBattleProject
{
    public class Pokeball
    {
        public Trainer? trainer;
        public Pokemon? pokemon;
        public Boolean hasPokemonInside = false;

        // constructor
        public Pokeball(Trainer newTrainer, Pokemon newPokemon)
        {
            this.trainer = newTrainer;
            this.pokemon = newPokemon;
        }

        // Open() will release the Pokeball, call .Battlecry() on its pokemon, and return the pokemon.
        public Pokemon? Open()
        {
            if (this.pokemon != null)
            {
                // there's a pokemon in the pokeball. make it Battlecry, release it, return reference
                //Console.WriteLine("Pokeball.Open(): released pokemon (" + this.pokemon.nickname + ")");
                var releasedPokemon = this.pokemon;
                releasedPokemon.Battlecry();
                
                this.pokemon = null;
                this.hasPokemonInside = false;
                return releasedPokemon;
            }
            else
            {
                // there's no pokemon in the pokeball, so do nothing and return null
                Console.WriteLine("Pokeball.Open(): no pokemon to release.");
                return null;
            }
        }

        public void Close(Pokemon capturePokemon)
        {
            if(capturePokemon == null)
            {
                Console.WriteLine("Pokeball.Close(): error, can't close and capture, because given pokemon is null.");
            }

            if (this.pokemon == null)
            {
                this.pokemon = capturePokemon;
                this.hasPokemonInside = true;
                Console.WriteLine("Pokeball.Close(): captured pokemon (" + capturePokemon.nickname + ")");
            } else
            {
                Console.WriteLine("Pokeball.Close(): error, can't close and capture, because there is already a pokemon inside.");
            }
        }

        public bool HasPokemonInside()
        {
            return this.hasPokemonInside;
        }

        public override string ToString()
        {
            if (this.pokemon == null)
            {
                return "Pokeball()";
            }
            else
            {
                return "Pokeball(pokemon=" + this.pokemon.nickname + ")";
            }
        }
    }
}

