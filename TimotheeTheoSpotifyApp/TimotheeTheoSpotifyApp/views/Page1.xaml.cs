using System;
using TimotheeTheoSpotifyApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimotheeTheoSpotifyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private Page1ViewModel viewModel;

        public Page1()
        {   
            InitializeComponent();

            viewModel = new Page1ViewModel();
            BindingContext = viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            viewModel.InvertColors();
        }

    }
}