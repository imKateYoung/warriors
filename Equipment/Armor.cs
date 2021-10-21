using Warrior_Game.Enum;

namespace Warrior_Game.Equipment
{
     class Armor
    {
        private const int Good_Guy_Armor = 5;
        private const int Bad_Guy_Armor = 5;

        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = Good_Guy_Armor;
                    break;

                case Faction.BadGuy:
                    armorPoints = Bad_Guy_Armor;
                    break;
                default:
                    break;

            }
        }
    }

}