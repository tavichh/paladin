using System;
using System.IO;
using System.Net;

namespace Paladin
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Paladin.LoadPaladinSplash();
            Console.Read();
        }
    }
}