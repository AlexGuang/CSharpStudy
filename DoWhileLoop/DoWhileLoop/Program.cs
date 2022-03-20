using System;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 15;
            int lengthOfText = 0;
            string wholeText = "";
            int sumScore = 0;
            int currentStudentScore;
            int countStudent = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);


            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string friendName = Console.ReadLine();
                int currentLength = friendName.Length;
                lengthOfText += currentLength;
                wholeText = wholeText + friendName + ", ";
                

            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that's  enough! " + wholeText );
           // Write a code to see the average score of a class.
            do
            {
                Console.WriteLine("Please enter the score of the Number {0} student",countStudent+1);
                if (int.TryParse(Console.ReadLine(),out currentStudentScore))
                {
                    sumScore += currentStudentScore;
                    countStudent++;
                }

            } while (countStudent < 3);
            Console.WriteLine("The average score of the class is " + sumScore / (countStudent));
        }
    }
}
