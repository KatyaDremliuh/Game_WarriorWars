using Game_WarriorWars.Enum;
using Game_WarriorWars.Equipment;

namespace Game_WarriorWars
{
    class Warrior
    {
        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private Faction faction;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.faction = faction;
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
            }
        }
    }
}