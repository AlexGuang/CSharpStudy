using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            string text = "Hello, my phone no. is 12345657657674";
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("There are {0} hits in the text {1}", matches.Count, text);
            foreach (Match match in matches)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine("{0} found at {1}, {2} found at {3}",group[0].Value,group[],group[1].Value,group[1].Index);
            }
        }
    }
}
