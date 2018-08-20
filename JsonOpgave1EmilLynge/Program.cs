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
