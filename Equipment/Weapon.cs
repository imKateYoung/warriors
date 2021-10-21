using Warrior_Game.Enum;

namespace Warrior_Game.Equipment
{
    class Weapon
    {
        private const int goodGuyDamage = 5;
        private const  int badGuyDamage = 5;

        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public  Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = goodGuyDamage;
                    break;

                case Faction.BadGuy:
                    damage = badGuyDamage;
                    break;
                default:
                    break;

            }
        }
    }
}
