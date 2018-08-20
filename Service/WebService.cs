using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Newtonsoft.Json;

namespace Service
{   /// <summary>
    /// Class which recieves and handles Json data.
    /// </summary>
    public class WebService<T>
    {
        /// <summary>
        /// Method that gets information about the value of currencies, compared to 1 USD, through Json data. It then parses it to an object.
        /// </summary>
        /// <returns>The object parsed from Json data, that holds information about the value of currencies.</returns>
        public static T GetJsonObject()
        {
            using (var client = new WebClient())
            {
                var jsonData = client.DownloadString(@"https://openexchangerates.org/api/latest.json?app_id=22b4552302924970ba6868d0e5e8bbb4&base=USD");
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
        }
        /// <summary>
        /// Method that gets information about the value of currencies, compared to the specified base-currency, through Json data. It then parses it to an object.
        /// </summary>
        /// <param name="url">The url-string used to access Json data.</param>
        /// <returns>The object parsed from Json data, that holds information about the value of currencies</returns>
        public static T GetJsonObjectFromURL(string url)
        {
            using (var client = new WebClient())
            { 
                var jsonData = client.DownloadString(url);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
        }
    }
}