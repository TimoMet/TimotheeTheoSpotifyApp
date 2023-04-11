using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimotheeTheoSpotifyApp.Spotify_Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimotheeTheoSpotifyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private async void LoadData(string id = "me")
        {
            try
            {
                var user = await new SpotifyService().GetPersonalInformation(id);
                BindingContext = user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void OnIdSet(object sender, EventArgs e)
        {
            LoadData(((Entry)sender).Text);
        }
    }
}