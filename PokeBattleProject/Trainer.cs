using System;
namespace PokeBattleProject
{

    public class Trainer
    {
        public string Name;
        public List<Pokeball> belt;
        private int _maxBalls = 6;

        public Trainer(string newName)
        {
            this.Name = newName;
            this.belt = new List<Pokeball>();
            
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
            Console.WriteLine("Trainer.takePokeball(): " + newPokeball.ToString());

            if (this.belt.Count >= this._maxBalls)
            {
                throw new Exception("Error: can't add more than "+ this._maxBalls.ToString() + " Pokeballs to this belt.");
            }
            else
            {
                this.belt.Add(newPokeball);      // add given Pokeball to belt
            }
        }

        public Charmander throwPokeball()
        {
            //var c = this.belt.First<Charmander>();

            return null;
        }

        public void returnPokemon(Charmander charmander)
        {

        }
    }


}

