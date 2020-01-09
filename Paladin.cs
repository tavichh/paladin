using System;

namespace Paladin
{
    public static class Paladin
    {
        public static void LoadPaladinSplash()
        {
            Print("|+-------------------------------------------------------------------------+|", MessageTypes.None);
            string splash = @"`7MM""""""Mq.   db      `7MMF'            db      `7MM""""""Yb. `7MMF'`7MN.   `7MF'
  MM   `MM. ;MM:       MM             ;MM:       MM    `Yb. MM    MMN.    M  
  MM   ,M9 ,V^MM.      MM            ,V^MM.      MM     `Mb MM    M YMb   M  
  MMmmdM9 ,M  `MM      MM           ,M  `MM      MM      MM MM    M  `MN. M  
  MM      AbmmmqMA     MM      ,    AbmmmqMA     MM     ,MP MM    M   `MM.M  
  MM     A'     VML    MM     ,M   A'     VML    MM    ,dP' MM    M     YMM  
.JMML. .AMA.   .AMMA..JMMmmmmMMM .AMA.   .AMMA..JMMmmmdP' .JMML..JML.    YM  ";
            Print(splash, MessageTypes.None);
            Print("|+-------------------------------------------------------------------------+|", MessageTypes.None);
            Print(" T H E    M A N I F E S T    D R I V E N     F I L E    D O W N L O A D E R", MessageTypes.None);
            Print("|+-------------------------------------------------------------------------+|", MessageTypes.None);
            Print("", MessageTypes.None);
            ManifestReader.CheckManifest("paladin.manifest");
        }

        public static void Print(string message, MessageTypes type)
        {
            switch (type)
            {
                case MessageTypes.Info:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case MessageTypes.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageTypes.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MessageTypes.None:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            Console.WriteLine(message);
        }
    }
}