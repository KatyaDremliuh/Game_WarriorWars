using System.Text;
using Game_WarriorWars.Enum;
using Game_WarriorWars.Equipment;

namespace Game_WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 30;
        private const int BAD_GUY_STARTING_HEALTH = 30;

        private readonly Faction FACTION;

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
            this.FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;

                    break;

                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char life = Convert.ToChar("\u25A0");
            char injury = Convert.ToChar("\u25A1");

            if (enemy.health <= 0)
            {
                enemy.isAlive = false;

                Tools.ColorfulWrite($"\t\t{enemy.name} is dead!\n", ConsoleColor.Red);
                Tools.ColorfulWrite($"\t\t{name} is victorious!", ConsoleColor.Green);
            }
            else
            {
                string restOfLifePoints = string.Concat(Enumerable.Repeat(life, enemy.health));
                string lifePoints = string.Concat(Enumerable.Repeat(injury, BAD_GUY_STARTING_HEALTH - enemy.health));

                Tools.ColorfulWrite($"\t{restOfLifePoints}", ConsoleColor.Green);
                Tools.ColorfulWrite($"{lifePoints}", ConsoleColor.Yellow);

                Console.WriteLine(
                    $"\t[{name} attacked -> {enemy.name}.] Damage was inflicted to {enemy.name}: {damage}. Remaining health of {enemy.name} is {enemy.health}.");
            }
        }
    }
}