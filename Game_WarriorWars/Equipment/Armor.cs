using Game_WarriorWars.Enum;

namespace Game_WarriorWars.Equipment
{
    class Armor
    {
        private int goodGuyArmor;
        private int badGuyArmor;

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
                    armorPoints = goodGuyArmor;
                    break;

                case Faction.BadGuy:
                    armorPoints = badGuyArmor;
                    break;
            }
        }
    }
}