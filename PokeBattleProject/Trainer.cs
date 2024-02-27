using System;
namespace PokeBattleProject
{

    public class Trainer
    {
        private Random random;
        public string Name;
        private List<Pokeball> _belt;
        private int _maxBalls = 6;

        public Trainer(string newName, Random random)
        {
            this.Name = newName;
            this._belt = new List<Pokeball>();
            
            this.takePokeball(new Pokeball(this, new Charmander("Charmander 1")));
            this.takePokeball(new Pokeball(this, new Charmander("Charmander 2")));
            this.takePokeball(new Pokeball(this, new Bulbasaur("Bulbasaur 1")));
            this.takePokeball(new Pokeball(this, new Bulbasaur("Bulbasaur 2")));
            this.takePokeball(new Pokeball(this, new Squirtle("Squirtle 1")));
            this.takePokeball(new Pokeball(this, new Squirtle("Squirtle 2")));
            
            // if I want to test that maximum 6 balls can be added, I need to 
            // this.takePokeball(new Pokeball(new Charmander("Fireball 7")));
        }

        public void takePokeball(Pokeball newPokeball)
        {
            // Console.WriteLine("Trainer.takePokeball(): " + newPokeball.ToString());

            if (this._belt.Count >= this._maxBalls)
            {
                throw new Exception("Error: can't add more than "+ this._maxBalls.ToString() + " Pokeballs to this belt.");
            }
            else
            {
                this._belt.Add(newPokeball);      // add given Pokeball to belt
            }
        }

        // Will take the first Pokeball on its belt and throw it (call .Open() on the Pokeball)
        public Pokemon? ThrowPokeball()
        {
            // 5. The pokeball released the pokemon and the pokemon does its battle cry.
            // haal een willekeurig nummer op tussen 0 en het aantal pokeballs in de belt
            int willekeurigNummer = this.random.Next(0, this._belt.Count);

            var ball = this._belt.ElementAt(willekeurigNummer);
            var pokemon = ball.Open();
                
            return pokemon;
        }

        public void returnPokemon(Pokemon? pokemon)
        {

        }
    }


}

