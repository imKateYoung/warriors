using Warrior_Game.Equipment;
using Warrior_Game.Enum;

namespace Warrior_Game
{
    class Warrior
    {

        private const int goodGuyStartingHealth = 100;
        private  const int badGuyStartingHealth = 100;

        private readonly Faction Faction;

        private int health;
        private string name;
        private bool isAlive;
        public bool IsAlive 
        {
            get
            {
                return isAlive;
            }
            set
            {
                
            }
         }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            Faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = goodGuyStartingHealth;
                    break;

                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = badGuyStartingHealth;
                    break;
                default:
                    break;

            }
        }

        public  void Attack(Warrior enemy )
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;
            enemy.health -= damage;

            if(enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorFulWriteLine($"{enemy.name} is dead! {name} is winning", System.ConsoleColor.Red);
            }
            else
            {
                System.Console.WriteLine($"{name} attacked! {enemy.name} got injured, {enemy.name}remaining health is {enemy.health}");
            }
        }
    }
}
