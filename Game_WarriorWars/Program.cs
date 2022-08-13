using Game_WarriorWars.Enum;

namespace Game_WarriorWars
{
    internal class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Genie", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Jafar", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive) // how long they're going to attack each other
            {
                if (random.Next(0, 10) < 5) // 50 %
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(300);
            }
        }
    }
}