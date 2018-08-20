using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace JsonOpgave1EmilLynge
{
    class Program
    {
        /// <summary>
        /// The main application. This is where the program runs.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WebService webService = new WebService();
            decimal dkk;
            webService.GetJsonObject().Rates.TryGetValue("DKK", out dkk);
            Console.WriteLine($"One USD equals {dkk} DKK.");
            Console.ReadLine();
        }
    }
}
