using System;
using System.Collections.Generic;

namespace DelegateLearningWithVSDefault
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Before removing, the names in the list are:");
            List<string> names = new List<string>()
            {
                "Jack","Jim","Marry","Denis","Micheal","Tim","Harry"
            };
            foreach (var item in names)
            {
                Console.WriteLine(item);    
            }
            Console.WriteLine("----------------------------------------------");
            names.RemoveAll(Filter);
            Console.WriteLine("After removing, the names in the list are:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            
        }


        /// <summary>
        /// To check a string, if contains "i", return true, otherwise, return false.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static bool Filter(string name)
        {
            if (name.Contains("i"))// If the string contains "i",the Filter method would return true
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
    }
}
