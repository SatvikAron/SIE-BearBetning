using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SIE_BearBetningConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var accounts = new Dictionary<string, decimal>();
          var  lines = File.ReadAllLines(@"C:\Users\iceso\source\repos\SIE Bearbetning_Chsarp\SIE-BearBetningConsoleApp\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt.txt");

            string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";
            //var totalbalce = lines.Where(x => x.Contains("#TRANS")).Select(te => decimal.Parse(Regex.Match(te, pattern).Groups[2].Value)).Sum();

            
            var totalbalce = lines.Where(x => x.Contains("#TRANS")).Select(te => decimal.Parse(Regex.Match(te, pattern).Groups[2].Value, CultureInfo.InvariantCulture)).Sum();


            Console.WriteLine(totalbalce);

            Console.ReadLine();
        }
    }
}
