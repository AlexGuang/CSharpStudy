using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    internal class MessageService
    {
        public void OnVideoEncoded(object o, EventArgs args)
        {
            Console.WriteLine("A message has been sent to the client....");
        }
    }
}
