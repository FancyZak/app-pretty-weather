using PrettyWeather.API.Model;
using Refit;
using System;
using System.Threading.Tasks;

namespace PrettyWeather.API
{
    public class RestClient
    {
        private readonly IRestClient restClient;

        public RestClient()
        {
            restClient = RestService.For<IRestClient>("https://samples.openweathermap.org/data/2.5");
        }

        public async Task<Weather> GetWeather(string city, string country, string apiKey)
        {
            return await restClient.GetWeather(city, country, apiKey);
        }

        public static void Main(string[] args)
        {
            RestClient test = new RestClient();
            var w = test.GetWeather("London", "uk", APIKey.getKey);
            Console.WriteLine("City is {0} of Country {1}, weather is like {2} and temp is {3}", w.Result.Name, w.Result.Sys.Country, w.Result.WeatherWeather[0].Description, w.Result.Main.Temp);
        }
    }
}
