using System;
namespace PokeBattleProject
{
    public class Charmander
    {
        public string nickname;
        public string strength;
        public string weakness;

        // public Charmander(string newNickname) : base(newNickname) {
        public Charmander(string newNickname)
        {
            this.nickname = newNickname;
            this.strength = "Fire";
            this.weakness = "Water";
            // Console.WriteLine("Charmander() constructor: created new object. nickname: " + this.nickname + " with strength: " + this.strength + " and weakness: " + this.weakness);
        }

        public void battlecry()
        {
            Console.WriteLine("!!! " + this.nickname.ToUpper() + " !!!");
        }
    }
}

