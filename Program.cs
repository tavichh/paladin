using System;
using System.IO;
using System.Net;

namespace Paladin
{
    static class Program
    {
        private static string manifest;

        /// <summary>
        /// The entry point for the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            LoadPaladinSplash();
            Console.Read();
        }

        /// <summary>
        /// Shows the startup screen.
        /// </summary>
        static void LoadPaladinSplash()
        {
            Print("|+-------------------------------------------------------------------------+|",MessageTypes.None);
            string splash = @"`7MM""""""Mq.   db      `7MMF'            db      `7MM""""""Yb. `7MMF'`7MN.   `7MF'
  MM   `MM. ;MM:       MM             ;MM:       MM    `Yb. MM    MMN.    M  
  MM   ,M9 ,V^MM.      MM            ,V^MM.      MM     `Mb MM    M YMb   M  
  MMmmdM9 ,M  `MM      MM           ,M  `MM      MM      MM MM    M  `MN. M  
  MM      AbmmmqMA     MM      ,    AbmmmqMA     MM     ,MP MM    M   `MM.M  
  MM     A'     VML    MM     ,M   A'     VML    MM    ,dP' MM    M     YMM  
.JMML. .AMA.   .AMMA..JMMmmmmMMM .AMA.   .AMMA..JMMmmmdP' .JMML..JML.    YM  ";
            Print(splash, MessageTypes.None);
            Print("|+-------------------------------------------------------------------------+|",MessageTypes.None);
            Print(" T H E    M A N I F E S T    D R I V E N     F I L E    D O W N L O A D E R",MessageTypes.None);
            Print("|+-------------------------------------------------------------------------+|",MessageTypes.None);
            Print("",MessageTypes.None);
            CheckManifest("Paladin.manifest");

        }

        /// <summary>
        /// Checks to see if the user has the Paladin.manifest file in their directory. Asks to create if they do not.
        /// </summary>
        static void CheckManifest(string fileName)
        {
            
            var exists = File.Exists("Paladin.manifest");
            if (exists == false)
            {
                Console.WriteLine(
                    "Paladin works by using a GitHub gist to grab and download everything located in the URL.");
                Console.WriteLine(
                    "THEREFORE THE ");
                Console.WriteLine("");
                Console.WriteLine("URL to RAW GIST file");
                Console.Write(">: ");
                manifest = Console.ReadLine();
                Console.WriteLine($"YOU HAVE ENTERED {manifest}, IS THIS CORRECT? (Y/N)");
                var key = Console.ReadKey();
                
                switch (key.Key)
                {
                    case ConsoleKey.Y:
                        Downloader.DownloadUrlToFile(manifest);
                        break;
                    case ConsoleKey.Enter:
                        Downloader.DownloadUrlToFile(manifest);
                        break;
                    case ConsoleKey.N:
                        LoadPaladinSplash();
                        break;
                }
            }
            if (exists == true)
            {
                Print("PALADIN.MANIFEST DETECTED! DOWNLOADING...",
                    MessageTypes.Warning);
                Downloader.DownloadManifestContents(manifest);
            }
        }

        public static void Print(string message, MessageTypes type)
        {
            switch (type)
            {
                case MessageTypes.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case MessageTypes.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageTypes.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MessageTypes.None:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }

            Console.WriteLine(message);
        }
    }

    enum MessageTypes
    {
        Info,
        Warning,
        Error,
        None
    }
}