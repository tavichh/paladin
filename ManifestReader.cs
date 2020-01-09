using System;
using System.IO;

namespace Paladin
{
    public static class ManifestReader
    {
        static string manifest;
        public static void CheckManifest(string fileName)
        {
            var exists = File.Exists("paladin.manifest");
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
                        Paladin.LoadPaladinSplash();
                        break;
                }
            }
            if (exists)
            {
                Console.WriteLine("paladin.manifest has been detected!");
                Console.WriteLine("You can press 'x' to delete the file!");
                Console.WriteLine("You can press 'e' to load the file!");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.X)
                {
                    File.Delete("Paladin.manifest");
                    Paladin.Print("Deleted manifest file!",MessageTypes.Info);
                    CheckManifest("paladin.manifest");
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Downloader.DownloadAllManifestContents(manifest);
                }
            }
        }
    }
}