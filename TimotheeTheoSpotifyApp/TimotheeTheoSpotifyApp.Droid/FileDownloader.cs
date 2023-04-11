using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Android.Widget;
using Java.Lang;

namespace TimotheeTheoSpotifyApp.Droid
{
    public class FileDownloader : IFileDownloader
    {
        public async Task DownloadFile(string url, string fileName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var downloadDir = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath;
                var filePath = Path.Combine(downloadDir, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await response.Content.CopyToAsync(fileStream);
                }

                // Display a Toast message to indicate that the download is complete
                Toast.MakeText(Android.App.Application.Context, "Download complete", ToastLength.Short)?.Show();
            }
            else
            {
                throw new Exception($"HTTP request failed with status code {response.StatusCode}");
            }
        }
    }
}