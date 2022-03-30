using System;
using System.IO;

namespace WriteIntoATextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1 to write some text into a file, if not exist, create it automaticlly.
            string[] lines = { "xiaoguang : 99", "jingyao : 100", "Lili:44" };
            File.AppendAllLines(@"E:\Annnew Studio\C#study\textTest.txt", lines);
            // Method two to write some text into a file
           /* Console.WriteLine("Please enter the file name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text:");
            string text = Console.ReadLine();
            File.WriteAllText(@"E:\Annnew Studio\C#study\"+fileName+".txt", text);
           */


            using(StreamWriter writer = new StreamWriter(@"E:\Annnew Studio\C#study\liqin.txt"))
                foreach (var item in lines)
                {
                    if (item.Contains("jingyao"))
                    {
                        writer.WriteLine(item);
                    }
                    
                }

        }
    }
}
