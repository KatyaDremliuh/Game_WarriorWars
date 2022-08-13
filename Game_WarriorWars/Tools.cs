namespace Game_WarriorWars
{
    static class Tools
    {
        public static void ColorfulWrite(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}