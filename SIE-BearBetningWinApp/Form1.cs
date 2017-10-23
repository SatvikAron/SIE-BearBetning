using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIE_BearBetningWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(@"C:\Users\iceso\source\repos\SIE Bearbetning_Chsarp\SIE-BearBetningConsoleApp\MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt.txt");

            string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";

            var totalbalce = lines.Where(x => x.Contains("#TRANS")).Select(te => decimal.Parse(Regex.Match(te, pattern).Groups[2].Value, CultureInfo.InvariantCulture)).Sum();
            label1.Text = totalbalce.ToString();
        }
    }
}
