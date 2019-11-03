using PrettyWeather.API;
using Refit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace PrettyWeather.ViewModel
{
    public class WeatherViewModel
    {
        public int Temp { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Date { get; set; }

        public string WeatherCondition { get; set; }
        public string WeatherDescription { get; set; }


        public WeatherViewModel()
        {
            RestClient client = new RestClient();
            var w = client.GetWeather("Birmingham", "UK", APIKey.getKey);

            Temp = Convert.ToInt32(w.Result.Main.Temp);
            City = w.Result.Name;
            WeatherCondition = w.Result.WeatherWeather[0].Main.ToUpper();
            WeatherDescription = "Looking like " + w.Result.WeatherWeather[0].Description + " outside";


            DateTime dt = DateTime.Now;
            // FRIDAY, SEPTEMBER 13 - FORMAT
            Date = dt.ToString("dddd").ToUpper() + ", " + dt.ToString("MMMM", CultureInfo.InvariantCulture).ToUpper() + " " + dt.Day.ToString();
        }
    }
}
