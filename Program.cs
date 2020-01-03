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
            Console.ForegroundColor = ConsoleColor.Red; // because colors

            Console.WriteLine(
                "Paladin works by using a GitHub gist to grab and download everything located in the URL.");
            Console.WriteLine(
                "Therefore, the gist acts as a manifest file for links. This is useful for downloading large amounts of files.");
            InitializePaladin();
        }

        /// <summary>
        /// Asks the user for the URL to the manifest and if applicable, will download the manifest.
        /// </summary>
        static void InitializePaladin()
        {
            Console.WriteLine("");
            Console.Write("Please enter the URL to the manifest> ");
            manifest = Console.ReadLine();
            Console.WriteLine($"You have entered {manifest}, is this correct? (Y/N)");
            var key = Console.ReadKey();

            switch (key.Key) {
                case ConsoleKey.Y:
                    DownloadManifestFile();
                    break;
                case ConsoleKey.Enter:
                    DownloadManifestFile();
                    break;
                case ConsoleKey.N:
                    InitializePaladin();
                    break;
            }
        }

        /// <summary>
        /// Downloads the manifest file.
        /// </summary>
        static void DownloadManifestFile()
        {
            using var client = new WebClient();
            client.DownloadFile(manifest, ($"Paladin.manifest"));
        }
    }
}