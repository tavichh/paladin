using System;

namespace Paladin
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray; // because fuck people's customization options
            Paladin.LoadPaladinSplash();
            Console.Read();
        }
    }
}