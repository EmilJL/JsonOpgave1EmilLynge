using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// A class that functions as an object, made to contain data deserialized from Json.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Property that contains a string with a link to legal information. I think.
        /// </summary>
        public string Disclaimer { get; set; }
        /// <summary>
        /// Property that contains a string with a link to the licensing of the webservice provider.
        /// </summary>
        public string License { get; set; }
        /// <summary>
        /// Property that holds an integer with information about when the API-call was made.
        /// </summary>
        public int Timestamp { get; set; }
        /// <summary>
        /// Property that holds a string with information of the base value, which the currency data is compared to.
        /// </summary>
        public string Base { get; set; }
        /// <summary>
        /// Property that contains a dictionary where the keys are strings, which are abbreviations of the different currencies. The paired value, is the value compared to the base currency.
        /// </summary>
        public Dictionary<string, decimal> Rates { get; set; }
    }
}