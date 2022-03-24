using System;
using System.Collections.Generic;
namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> number = new Stack<int>();//define a stack;
            if (number.Count > 0)
            {
                number.Pop();

            }
            number.Push(1); // push 1 into the stack, add the element 1 to the stack
            number.Push(2);
            number.Push(3);
            number.Push(4);
            number.Push(5);
            number.Push(6);
            number.Push(7);
            number.Push(8);
            Console.WriteLine(number.Peek());// display the number on the top of the stack
            number.Pop();// delete a number on the top of stack;
            int removedNum =  number.Pop();
            Console.WriteLine("Removed number is {0}",removedNum);

            do
            {
                number.Pop();


            } while (number.Count > 0);

            // number.Peek(); stack empty, error

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                number.Push(numbers[i]);

            }
            int []tempNumbers = new int[7];
            for (int j = 0;j < tempNumbers.Length;j++)
            {
                tempNumbers[j] = number.Pop();
                numbers[j] = tempNumbers[j];
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
