using PrettyWeather.API.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrettyWeather.API
{
    public interface IRestClient
    {
        // weather?q=London,uk&appid=
        [Get("/weather?q={city},{country}&appid={apiKey}")]
        Task<Weather> GetWeather(string city, string country, string apiKey);
    }
}
