using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace TimotheeTheoSpotifyApp.Spotify_Service
{
    class SpotifyService
    {
        private const string Token = "";
        private readonly SpotifyClient Client;

        public SpotifyService()
        {
            Client = new SpotifyClient(Token);
        }

        public async Task<FullArtist> GetImagineDragons()
        {
            var artist = Client.Artists.Get("53XhwfbYqKCa1cC15pYq2q");
            await artist.ConfigureAwait(false);
            return await artist;
        }
    }
}