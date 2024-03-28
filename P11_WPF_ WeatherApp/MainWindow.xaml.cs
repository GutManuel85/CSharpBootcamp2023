using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows;
using System.Windows.Media.Imaging;

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

            UpdateData("Lucerne");

            Console.WriteLine("Breakpoint");
        }

        public WeatherAppResponse GetWeatherData(string city)
        {
            HttpClient httpClient = new HttpClient();
            var finalUri = requestUrl + "?q=" + city + "&appid=" + apiKey + "&units=metric";
            HttpResponseMessage httpRespone = httpClient.GetAsync(finalUri).Result;
            string response = httpRespone.Content.ReadAsStringAsync().Result;
            WeatherAppResponse weatherAppResponse = JsonConvert.DeserializeObject<WeatherAppResponse>(response);
            return weatherAppResponse;
        }

        public void UpdateData(string city)
        {
            if (city != null)
            {
                WeatherAppResponse data = GetWeatherData(city);

                string imagePath = GetImagePath(data);
                backgroundImage.ImageSource = new BitmapImage(new Uri(imagePath, UriKind.Relative));

                float temperature = float.Parse(data.main.temp.ToString("F1"));
                labelTemperature.Content = temperature + "°C";

                string description = data.weather[0].description;
                labelWeather.Content = description;
            }
        }

        public bool checkWeatherDescription(WeatherAppResponse data, string searchString)
        {
            return data.weather[0].description.ToLower().Contains(searchString);
        }

        public string GetImagePath(WeatherAppResponse data)
        {
            string finalImagePath = "Images/Sun.png";

            if (checkWeatherDescription(data, "rain"))
            {
                finalImagePath = "Images/Rain.png";
            }
            else if (checkWeatherDescription(data, "cloud"))
            {
                finalImagePath = "Images/Cloud.png";
            }
            else if (checkWeatherDescription(data, "snow"))
            {
                finalImagePath = "Images/Snow.png";
            }
            return finalImagePath;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string query = inputCity.Text.Trim();

            UpdateData(query);
        }
    }
}
