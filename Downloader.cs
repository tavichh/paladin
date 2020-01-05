using System.Net;

namespace Paladin
{
    public static class Downloader
    { 
        public static void DownloadUrlToFile(string url)
        {
            using var client = new WebClient();
            Program.Print("Downloading the manifest file...",MessageTypes.Info);
            client.DownloadFile(url, ($"Paladin.manifest"));
        }

        public static void DownloadManifestContents(string url)
        {
            
        }
    }
}