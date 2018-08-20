using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Entities;

namespace JsonOpgave1EmilLynge
{
    class Program
    {
        /// <summary>
        /// The main application. This is where the program runs.
        /// </summary>
        /// <param name="args">Pas</param>
        static void Main(string[] args)
        {
            string urlUSD = @"https://openexchangerates.org/api/latest.json?app_id=22b4552302924970ba6868d0e5e8bbb4";
            string urlEUR = @"http://data.fixer.io/api/latest?access_key=5a9e4e04090030fe00ab916d9360fc21";
            string urlWeatherLondon = @"http://api.openweathermap.org/data/2.5/weather?q=London&appid=4cbb6a71b643daea88a97e542c5113d5&units=metric";
            decimal dkk;
            double degrees;
            WebService<Currency>.GetJsonObject().Rates.TryGetValue("DKK", out dkk);
            Console.WriteLine($"1 USD equals {dkk} DKK.");
            WebService<Currency>.GetJsonObjectFromURL(urlUSD).Rates.TryGetValue("DKK", out dkk);
            Console.WriteLine($"1 USD equals {dkk} DKK.");
            WebService<Currency>.GetJsonObjectFromURL(urlEUR).Rates.TryGetValue("DKK", out dkk);
            Console.WriteLine($"1 EUR equals {dkk} DKK.");
            degrees = WebService<WeatherObject>.GetJsonObjectFromURL(urlWeatherLondon).main.temp;
            Console.WriteLine($"The average temperature in London is currently {degrees} degrees celcius.");

            Console.ReadLine();
        }
    }
}