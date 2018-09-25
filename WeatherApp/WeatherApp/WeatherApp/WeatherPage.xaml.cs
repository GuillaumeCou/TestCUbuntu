using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();

            //Set the default binding to a default object for now
            BindingContext = new Weather();
        }

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            Weather weather = await Core.GetWeather("60601");
            getWeatherBtn.Text = weather.Title;
        }
    }
}