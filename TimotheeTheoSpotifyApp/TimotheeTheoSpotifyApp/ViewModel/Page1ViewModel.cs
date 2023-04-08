using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using XXXXXX;

namespace TimotheeTheoSpotifyApp.ViewModel
{
    public class Page1ViewModel : BaseViewModel
    {

        // Propriétés accessibles pour la liaison de données
        public Page1ViewModel()
        {
            Color1 = Color.Green;
            Color2 = Color.CornflowerBlue;
        }
        public Color Color1 
        {
            get
            {
                return GetValue<Color>();
            }
            set
            {
                SetValue(value);
            }
        }

        public Color Color2
        {
            get
            {
                return GetValue<Color>();
            }
            set
            {
                SetValue(value);
            }
        }
        

        // Méthode pour inverser les couleurs


        public void InvertColors()
        {
            if (Color1 == Color.CornflowerBlue)
            {
                Color1 = Color.Green;
                Color2 = Color.CornflowerBlue;
            }
            else
            {
                Color1 = Color.CornflowerBlue;
                Color2 = Color.Green;
            }
            
            
        }

        

        
    }
}