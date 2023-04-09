using TimotheeTheoSpotifyApp.Spotify_Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimotheeTheoSpotifyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            LoadData();
        }
        
        private async void LoadData()
        {
            var imagineDragons = await new SpotifyService().GetImagineDragons();
            BindingContext = imagineDragons;
        }
    }
}