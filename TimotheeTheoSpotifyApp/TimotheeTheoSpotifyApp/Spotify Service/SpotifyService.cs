using System;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Http;

namespace TimotheeTheoSpotifyApp.Spotify_Service
{
    class SpotifyService
    {
        private readonly SpotifyClient _client;
        private readonly SpotifyClientConfig _config;

        public SpotifyService()
        {
            _config = SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("068028456d0849e9a7b5098c805f0e39",
                    "0a7af15889384de084646ad43a486849"));
            _client = new SpotifyClient(_config);
        }

        public async Task<FullAlbum> GetAGoodBringMeTheHorizonAlbum()
        {
            var album = _client.Albums.Get("0e1WaSNDZnoPixaxDNdWo4");
            await album.ConfigureAwait(false);
            return await album;
        }

        public async Task<FullArtist> GetImagineDragons()
        {
            var artist = _client.Artists.Get("53XhwfbYqKCa1cC15pYq2q");
            await artist.ConfigureAwait(false);
            return await artist;
        }

        public async Task<PublicUser> GetPersonalInformation(string id = "me")
        {
            try
            {
                var personalInformation = new UserProfileClient(_config.BuildAPIConnector()).Get(id);
                await personalInformation.ConfigureAwait(false);
                return await personalInformation;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
           
        }
    }
}