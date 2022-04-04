using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGameDemo
{
    internal class AudioSystem
    {
        public AudioSystem()
        {
            GameTrigerManager.GameStart += OnGameStart;
            GameTrigerManager.GameStop += OnGameEnd;
        }
        public void OnGameStart(object j,EventArgs e)
        {
            Console.WriteLine("Audio files begins playing.");
            Console.WriteLine("==========================================");
        }

        public void OnGameEnd(object j, EventArgs e)
        {
            Console.WriteLine("Audio files stops playing.");
            Console.WriteLine("==========================================");
        }
    }
}
