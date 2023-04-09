using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace TimotheeTheoSpotifyApp.Spotify_Service
{
    class SpotifyService
    {
        private const string Token = "BQCngMAaFAgWvlRwA5YbQ7h2jnYuTHDharZWn1BhnAi0nTdmWmLUwicFxXAK4K2Kf4iiTITkQuupjp0CMdW-iSPbrxJlw_eaUPfTTVhRcaSTP-bw5806";
        private readonly SpotifyClient Client;

        public SpotifyService()
        {
            Client = new SpotifyClient(Token);
        }

        public async Task<FullAlbum> GetAGoodBringMeTheHorizonAlbum()
        {
            var album = Client.Albums.Get("0e1WaSNDZnoPixaxDNdWo4");
            await album.ConfigureAwait(false);
            return await album;
        }

        public async Task<FullArtist> GetImagineDragons()
        {
            var artist = Client.Artists.Get("53XhwfbYqKCa1cC15pYq2q");
            await artist.ConfigureAwait(false);
            return await artist;
        }
    }
}