using PrettyWeather.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient test = new RestClient();
            var w = test.GetWeather("London", "uk", APIKey.getKey);
            Console.WriteLine("City is {0} of Country {1}, weather is like {2} and temp is {3}", w.Result.Name, w.Result.Sys.Country, w.Result.WeatherWeather[0].Description, w.Result.Main.Temp);
            Console.Read();
        }
    }
}
