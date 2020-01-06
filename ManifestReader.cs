using System;
using System.IO;

namespace Paladin
{
    public static class ManifestReader
    {
        static string manifest;
        public static void CheckManifest(string fileName)
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
                        Paladin.LoadPaladinSplash();
                        break;
                }
            }
            if (exists == true)
            {
                Paladin.Print("PALADIN.MANIFEST DETECTED! DOWNLOADING...",
                    MessageTypes.Warning);
                Downloader.DownloadManifestContents(manifest);
            }
        }
    }
}