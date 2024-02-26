using Microsoft.Maui;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace MauiAppCombustivel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double gasolina = Convert.ToDouble(txt_gasolina.Text);
            double etanol = Convert.ToDouble(txt_etanol.Text);

            string msg = $"Compensa mais ";

            if (etanol > (gasolina * 0.7))
            {
                msg += "a gasolina";
            }
            else
            {
                msg += "o etanol";
            }

            DisplayAlert("Resultado", msg, "Fechar");
        }
    }
}