using TimotheeTheoSpotifyApp.Spotify_Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimotheeTheoSpotifyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            var album = new SpotifyService().GetAGoodBringMeTheHorizonAlbum();
            BindingContext = album.Result;
        }
    }
}