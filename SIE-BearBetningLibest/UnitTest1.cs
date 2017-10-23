using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SIE_BearBetningLibest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            var lines = File.ReadAllLines(@"C:\Users\iceso\source\repos\SIE Bearbetning_Chsarp\SIE-BearBetningConsoleApp\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt.txt");

            string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";
           
            var totalbalce = lines.Where(x => x.Contains("#TRANS")).Select(te => decimal.Parse(Regex.Match(te, pattern).Groups[2].Value, CultureInfo.InvariantCulture)).Sum();

            Assert.AreEqual(0,totalbalce);
            Debug.WriteLine(totalbalce);

        }
    }
}
