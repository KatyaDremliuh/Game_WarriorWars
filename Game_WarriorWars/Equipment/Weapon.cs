using Game_WarriorWars.Enum;

namespace Game_WarriorWars.Equipment
{
    class Weapon
    {
        private int goodGuyDamage;
        private int badGuyDamage;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = goodGuyDamage;
                    break;

                case Faction.BadGuy:
                    damage = badGuyDamage;
                    break;
            }
        }
    }
}