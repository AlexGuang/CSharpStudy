using System;

namespace DelegateGameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            Console.WriteLine("Please enter your Game name:");
            string gameName = Console.ReadLine();
            newGame.Name = gameName;
            GameTrigerManager gameTrigerManager = new GameTrigerManager();
            GameRender  gameRender = new GameRender();
            AudioSystem audioSystem = new AudioSystem();
            Player player1 = new Player();
            Console.WriteLine("Please enter the name of Play1:");
            player1.Name = Console.ReadLine();
            Player player2 = new Player();
            Console.WriteLine("Please enter the name of Play2:");
            player2.Name = Console.ReadLine();
            Console.WriteLine("Press any key to start the Game:");
            Console.ReadKey();
            Console.WriteLine("The Game: {0}" +"begains!",newGame.Name);
            gameTrigerManager.OnGameStart(newGame);
            Console.WriteLine("Press any Key to stop the Game");
            Console.ReadKey();
            gameTrigerManager.OnGameStop(newGame);

        }
    }
}
