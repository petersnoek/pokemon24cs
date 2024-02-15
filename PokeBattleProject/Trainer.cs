using System;
namespace PokeBattleProject
{

    public class Trainer
    {
        public string Name;
        private List<Pokeball> _belt;
        private int _maxBalls = 6;

        public Trainer(string newName)
        {
            this.Name = newName;
            this._belt = new List<Pokeball>();
            
            this.takePokeball(new Pokeball(new Charmander("Fireball 1")));
            this.takePokeball(new Pokeball(new Charmander("Fireball 2")));
            this.takePokeball(new Pokeball(new Charmander("Fireball 3")));
            this.takePokeball(new Pokeball(new Charmander("Fireball 4")));
            this.takePokeball(new Pokeball(new Charmander("Fireball 5")));
            this.takePokeball(new Pokeball(new Charmander("Fireball 6")));
            
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
        public Charmander ThrowPokeball()
        {
            // 5. The pokeball released the charmander and charmander does its battle cry.

            var ball = this._belt.First();
            var charmander = ball.Open();
                
            return charmander;
        }

        public void returnPokemon(Charmander charmander)
        {

        }
    }


}

