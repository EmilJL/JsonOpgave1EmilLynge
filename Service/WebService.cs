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
    /// Class which recieves and handles JsonData.
    /// </summary>
    public class WebService
    {
        /// <summary>
        /// Method that gets information about the value of currencies, compared to 1 USD, through JsonData. It then parses it to an object.
        /// </summary>
        /// <returns>The object generated through JsonData.</returns>
        public RootObject GetJsonObject()
        {
            using (var client = new WebClient())
            {
                var jsonData = client.DownloadString(@"https://openexchangerates.org/api/latest.json?app_id=22b4552302924970ba6868d0e5e8bbb4&base=USD");
                return JsonConvert.DeserializeObject<RootObject>(jsonData);
            }
        }       
    }
}
