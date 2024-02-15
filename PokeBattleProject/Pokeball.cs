using System;
namespace PokeBattleProject
{
    public class Pokeball
    {
        public Charmander? charmander;
        public Boolean hasCharmanderInside = false;

        // constructor
        public Pokeball(Charmander newCharmander)
        {
            if (newCharmander == null)
            {
                Console.WriteLine("Pokeball(): constructor failed; given charmander is null.");
            }
            else
            {
                if (newCharmander.GetType().ToString() != "PokeBattleProject.Charmander")
                {
                    Console.WriteLine("Pokeball(): constructor failed; given charmander is not the correct type.");
                }
                else
                {
                    this.charmander = newCharmander;
                    // Console.WriteLine("Pokeball() constructor: created new object. Captured Charmander " + newCharmander.nickname);
                }
            }
        }

        // Open() will release the Pokeball, call .Battlecry() on its charmander, and return the charmander.
        public Charmander? Open()
        {
            if (this.charmander != null)
            {
                // there's a charmander in the pokeball. make it battlecry, release it, return reference
                Console.WriteLine("Pokeball.Open(): released charmander (" + this.charmander.nickname + ")");
                var releaseCharmander = this.charmander;
                this.charmander.battlecry();
                this.charmander = null;
                this.hasCharmanderInside = false;
                return releaseCharmander;
            }
            else
            {
                // there's no charmander in the pokeball, so do nothing and return null
                Console.WriteLine("Pokeball.Open(): no charmander to release.");
                return null;
            }
        }

        public void Close(Charmander captureCharmander)
        {
            if(captureCharmander == null)
            {
                Console.WriteLine("Pokeball.Close(): error, can't close and capture, because given charmander is null.");
            }

            if (this.charmander == null)
            {
                this.charmander = captureCharmander;
                this.hasCharmanderInside = true;
                Console.WriteLine("Pokeball.Close(): captured charmander (" + captureCharmander.nickname + ")");
            } else
            {
                Console.WriteLine("Pokeball.Close(): error, can't close and capture, because there is already a charmander inside.");
            }
        }

        public bool HasCharmanderInside()
        {
            Console.WriteLine("Pokeball.HasCharmanderInside(): " + this.hasCharmanderInside.ToString());
            return this.hasCharmanderInside;
        }

        public override string ToString()
        {
            if (this.charmander == null)
            {
                return "Pokeball()";
            }
            else
            {
                return "Pokeball ( charmander = " + this.charmander.nickname + ")";
            }
        }
    }
}

