using System;

namespace VirtualOverrideKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Tom", 15);
            Console.WriteLine("{0} is  {1} years old.",dog.Name,dog.Age);
            dog.Eat();
            dog.Play();
            dog.MakeSounds();
        }
    }
}
