using System.Threading.Tasks;

namespace TimotheeTheoSpotifyApp;

public interface IFileDownloader
{
    Task DownloadFile(string url, string fileName);
}
