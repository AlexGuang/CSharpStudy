using System;

namespace ReadingFromATextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method one to read text from a file
            string text = System.IO.File.ReadAllText(@"E:\Annnew Studio\C#study\Textfile.txt");
            Console.WriteLine("The text in the file is\n {0}"   ,text);
            Console.WriteLine("---------------------------------------------------------");
            // Method two

            string[] lines = System.IO.File.ReadAllLines(@"E:\Annnew Studio\C#study\Textfile.txt");
            foreach (string line in lines)
            {
                Console.WriteLine("\t{0}",line);
            }


        }
    }
}
