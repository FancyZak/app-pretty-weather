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
            restClient = RestService.For<IRestClient>("https://openweathermap.org/data/2.5");
        }

        public Task<Weather> GetWeather(string city, string country, string apiKey)
        {
            return restClient.GetWeather(city, country, apiKey);
        }
    }
}
