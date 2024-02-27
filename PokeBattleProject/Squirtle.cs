using System;

namespace PokeBattleProject
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string newNickname) : base(newNickname)
        {
            this.strength = Energytype.Water;
            this.weakness = Energytype.Leaf;
        }

        public override void Battlecry()
        {
            Console.WriteLine("[Squirtle] " + this.nickname.ToUpper() + " !!!");
        }
    }
}

