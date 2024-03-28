using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows;

namespace P11_WPF__WeatherApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// URL API Key: https://home.openweathermap.org/api_keys
    /// URL API Methods: https://openweathermap.org/current#name
    /// Extras / NuGet-Paket-Manager  / NuGet-Pakete für Projektmappe verwalten... / Durchsuchen => Newtonsoft.Json / (installieren)
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly string apiKey = "23d88acd2fc2d3ad34ed556611663a14";
        private string requestUrl = "https://api.openweathermap.org/data/2.5/weather";

        public MainWindow()
        {
            InitializeComponent();

            HttpClient httpClient = new HttpClient();

            var city = "Berlin";
            var finalUri = requestUrl + "?q=" + city + "&appid=" + apiKey + "&units=metric";
            HttpResponseMessage httpRespone = httpClient.GetAsync(finalUri).Result;

            string response = httpRespone.Content.ReadAsStringAsync().Result;

            WeatherAppResponse weatherAppResponse = JsonConvert.DeserializeObject<WeatherAppResponse>(response);

            Console.WriteLine(response);
        }
    }
}
