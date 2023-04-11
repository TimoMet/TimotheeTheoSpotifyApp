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
            var user = await new SpotifyService().GetPersonalInformation(id);
            BindingContext = user;
        }

        private void OnIdSet(object sender, EventArgs e)
        {
            LoadData(((Entry)sender).Text);
        }


        private async void Download(string url)
        {
            var dateTime = DateTime.Now;
            var originalName = url.Split('?')[0].Split('/').Last();
            var extension = originalName.Contains('.') ? originalName.Split('.').Last() : "webp"; //some images don't have an extension
            var fileName = dateTime.ToString("yyyyMMdd_HHmmss") + '.' + extension;
            var fileDownloader = DependencyService.Get<IFileDownloader>();
            await fileDownloader.DownloadFile(url, fileName);
        }
        
        private void OnDownloadClicked(object sender, EventArgs e)
        {
            var url = ((Button)sender).CommandParameter;
            Console.WriteLine(url);
            Download(url.ToString());
        }
    }
}