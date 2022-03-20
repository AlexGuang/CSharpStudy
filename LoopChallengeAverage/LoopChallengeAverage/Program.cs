using System;

namespace LoopChallengeAverage
{
    internal class Program
    {

        /*
 create a program for a teacher. He needs a program written in c# that calculates the average
 score of his students. So he wants to be able to enter each score individually and then 
 get the final average score once he enters -1.
So the tool should check if the entry is a number and should add that to the sum. 
 Finally once he is done entering scores, the program should write onto the console what 
   the average score is.
The numbers entered should only be between 0 and 20. Make sure the program doesn't crash 
  if the teacher enters an incorrect value.
Test your program thoroughly.        
         */
        static void Main(string[] args)
        {
            int currentScore;
            int sumScore = 0;
            int count = 0;
            

            while (true)
            {
                Console.WriteLine("Please enter the Number {0} student score:", count + 1);
                if (int.TryParse(Console.ReadLine(),out currentScore))
                {
                    if (currentScore == -1)
                    {
                        Console.WriteLine("------------------------------------------");
                        break;
                    }
                    else if (currentScore < 0 || currentScore > 20)
                    {
                        Console.WriteLine("Your score is incorrect, please enter the score between 0 and 20!");
                        continue;
                    }
                    else
                    {
                        sumScore += currentScore;
                        count++;
                    }
                    
                }
            }
            Console.WriteLine("The average score of {0} students in this class is {1} ",count,(double)sumScore/(double)count);
        }
    }
}
