using System;
using Warrior_Game.Enum;

namespace Warrior_Game
{
    class EntryPoint
    {
        static Random rng = new Random();
        static void Main()
        {

            Warrior goodGuy = new Warrior("Justin", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Bieber", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if(rng.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
               
            }
        }
    }
}
