using System;

namespace PokeBattleProject
{
    public class Charmander : Pokemon
    {
        public Charmander(string newNickname) : base(newNickname)
        {
            this.strength = Energytype.Fire;
            this.weakness = Energytype.Water;
        }

        public override void Battlecry()
        {
            Console.WriteLine("[Charmander] " + this.nickname.ToUpper() + " !!!");
        }
    }
}

