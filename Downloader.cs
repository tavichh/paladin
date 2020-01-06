using System.Net;

namespace Paladin
{
    public static class Downloader
    { 
        public static void DownloadUrlToFile(string url)
        {
            using var client = new WebClient();
            Paladin.Print("Downloading the manifest file...",MessageTypes.Info);
            client.DownloadFile(url, ($"Paladin.manifest"));
        }

        public static void DownloadManifestContents(string url)
        {
            
        }
    }
}