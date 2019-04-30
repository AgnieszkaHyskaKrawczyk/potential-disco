using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Kobyla ma maly bok";
            char posledniPismeno = text[text.Length - 1];
            Console.WriteLine(posledniPismeno);

            string acka = new string('a', 10);
            Console.WriteLine(acka);

            string prazdny = string.Empty;
            string takyPrazdny = "";

            string nic = null;

            Console.WriteLine(prazdny.Length);

            Console.WriteLine(string.IsNullOrEmpty(prazdny));
            Console.WriteLine(string.IsNullOrWhiteSpace("  p "));

            Console.WriteLine("ahoj " + "svete");
            Console.WriteLine(string.Concat("ahoj ", "svete"));

            Console.WriteLine("ahoj" == "ahoj");
            Console.WriteLine("ahoj" == "Ahoj");

            Console.WriteLine(string.Equals("ahoj", "Ahoj", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(string.Compare("aaaa", "aaab"));
            Console.WriteLine("{0}. text v poradi je {1}", 1, text);

            Console.WriteLine(text.Contains("bok"));

            Console.WriteLine(text.IndexOf("bok", StringComparison.OrdinalIgnoreCase));

            text += "maly bok"; 
            Console.WriteLine(text.IndexOf("bok", 16, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(text.StartsWith("Kob"));
            Console.WriteLine(text.EndsWith("bok"));

            Console.WriteLine(text.Substring(2, 4));

            Console.ReadKey();
        }
    }
}
