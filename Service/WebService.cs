using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Newtonsoft.Json;

namespace Service
{
    public class WebService
    {
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
