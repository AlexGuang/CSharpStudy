using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGameDemo
{
    internal class Player
    {
        public string Name { get; set; }
        public Player()
        {
            GameTrigerManager.GameStart += OnGameStart;
            GameTrigerManager.GameStop += OnGameEnd;
        }
        private void OnGameStart(object j, EventArgs e)
        {
            Console.WriteLine("Spawn a player:{0}",Name);
            Console.WriteLine("Initialize the data of the player.");
            Console.WriteLine("==========================================");
        }
        private void OnGameEnd(object j, EventArgs e)
        {
            Console.WriteLine("Remove the player,{0}",Name);
            Console.WriteLine("==========================================");
        }
    }
}
