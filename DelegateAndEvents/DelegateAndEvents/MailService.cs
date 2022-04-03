using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class MailService
    {

        public void OnVideoEncoded(Object source, EventArgs args)
        {
            Console.WriteLine("A email has been sent to inform the client...");
        }
    }
}
