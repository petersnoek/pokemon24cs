using System;

namespace PokeBattleProject
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string newNickname) : base(newNickname)
        {
            this.strength = Energytype.Grass;
            this.weakness = Energytype.Fire;
        }

        public override void Battlecry()
        {
            Console.WriteLine("[Bulbasaur] " + this.nickname.ToUpper() + " !!!");
        }
    }
}

