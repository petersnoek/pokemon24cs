using System;

namespace PokeBattleProject
{
    public abstract class Pokemon
    {
        public string nickname;
        public Energytype strength;
        public Energytype weakness;

        public Pokemon(string newNickname)
        {
            this.nickname = newNickname;
            this.strength = Energytype.Unknown;
            this.weakness = Energytype.Unknown;
        }

        public abstract void Battlecry();
    }
}

