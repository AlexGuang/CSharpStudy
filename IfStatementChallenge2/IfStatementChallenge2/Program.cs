using System;

namespace IfStatementChallenge2
{
    internal class Program
    {
        static int highscore = 30;
        static string highscorePlayer ="Jack";
        /*
         Create an application with a score, highscore and a highscorePlayer.
        Create a method which has two parameters, one for the score and one for the playerName.
        When ever that method is called, it should be checked if the score of the player 
        is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder
        is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " 
        could not be broken and is still held by " + highscorePlayer.
        Consider which variables are required globally and which ones locally.      
         */
        static void Main(string[] args)
        {
            int  score;
            
          
            Console.WriteLine("Please input the score of the player");
            score = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the name of the player");
            string playerName = Console.ReadLine();
            CreateNewScore(score, playerName);
        }

        public static void CreateNewScore(int score, string playerName)
        {
            if (score > highscore)
            {
               
                Console.WriteLine("New highscore is: " + score);
                Console.WriteLine("New highscore holder is: " + playerName );
                highscore = score;
                highscorePlayer = playerName;
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
                
               
            }

        }
    }
}
