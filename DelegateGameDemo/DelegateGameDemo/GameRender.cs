using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGameDemo
{
    internal class GameRender
    {
       public  GameRender()
        {
            GameTrigerManager.GameStart += OnGameStart;
            GameTrigerManager.GameStop += OnGameEnd;
        }
        private void OnGameStart(object j, EventArgs e)
        {
            
            Console.WriteLine("Game Render starts working:");
            Console.WriteLine("Drawing Visuals......");
            Console.WriteLine("==========================================");
        }

        private void OnGameEnd(object j, EventArgs e)
        {
            Console.WriteLine("Game Render stops.");
            Console.WriteLine("==========================================");
        }
    }
}
