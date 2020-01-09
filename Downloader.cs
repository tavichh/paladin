using System;
using System.IO;
using System.Net;

namespace Paladin
{
    public static class Downloader
    { 
        public static void DownloadUrlToFile(string url)
        {
            using var client = new WebClient();
            Paladin.Print("Downloading the manifest file...",MessageTypes.Info);
            client.DownloadFile(url, "paladin.manifest");
        }

        private static void Download(string content)
        {
            var fileName = Path.GetFileName(content);
            var client = new WebClient();
            client.DownloadFile(content, fileName);
        }
        public static void DownloadAllManifestContents(string file)
        {
            var lines = File.ReadAllLines("paladin.manifest");
            foreach (var line in lines)
            {
                var current = Array.IndexOf(lines, line);
                Console.WriteLine($"[{current+1}/{lines.Length}]: Downloading from {line}...");
                Download(line);
                if(current==lines.Length)
                    Console.WriteLine("Download finished! You may exit Paladin!");
            }
        }
    }
}