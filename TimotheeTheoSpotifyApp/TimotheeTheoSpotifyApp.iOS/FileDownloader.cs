using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UIKit;

namespace TimotheeTheoSpotifyApp.iOS
{
    public class FileDownloader : IFileDownloader
    {
        public async Task DownloadFile(string url, string fileName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var documentsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var filePath = Path.Combine(documentsDir, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await response.Content.CopyToAsync(fileStream);
                }

                // Display an alert message to indicate that the download is complete
                var alert = UIAlertController.Create("Download complete", "", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                UIApplication.SharedApplication.KeyWindow?.RootViewController?.PresentViewController(alert, true, null);
            }
            else
            {
                throw new Exception($"HTTP request failed with status code {response.StatusCode}");
            }
        }
    }
}