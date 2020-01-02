using System;

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
            var accept = Console.ReadKey();

            if (accept.Key == ConsoleKey.Y)
                DownloadManifestFile();
            if (accept.Key == ConsoleKey.N)
                InitializePaladin();
        }

        /// <summary>
        /// Downloads the manifest file.
        /// </summary>
        static void DownloadManifestFile() { }
    }
}