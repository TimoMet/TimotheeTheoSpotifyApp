using System.Threading.Tasks;
using SpotifyAPI.Web;

namespace TimotheeTheoSpotifyApp.Spotify_Service
{
    class SpotifyService
    {
        private const string Token = "BQAFYR9k8v6ZF0P5MSyqlMMblFevlXg-RznwfEtsL2akDwnjoAXuXp6BhcGEyeyG44GCNHUjVPCzgoROiVVhF7LJcQPhhk_feiIQa2MhfPckAj0OCkiF";
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