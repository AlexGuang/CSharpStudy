
using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableAndIenumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DogShelter DogDong = new DogShelter();
            foreach (Dog dog in DogDong)
            {
                if (dog.IsNaughty)
                {
                    dog.GiveTreat(1);
                }
                else
                {
                    dog.GiveTreat(2);
                }
            }
        }

      
    }
}
