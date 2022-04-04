using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGameDemo
{
    internal class GameTrigerManager
    {
        public  delegate void GameStartEventHandler(object o, EventArgs e);
        public  delegate void GameStopEventHandler(object o, EventArgs e);

        public static event GameStartEventHandler GameStart;
        public static event GameStopEventHandler GameStop;

        public virtual void OnGameStart(object j)
        {
            if (GameStart!= null)
            {
                GameStart(this,EventArgs.Empty);
            }
        }
       public virtual void OnGameStop(object j)
        {
            if (GameStop != null)
            {
                GameStop(this,EventArgs.Empty);
            }
        }

    }
}
