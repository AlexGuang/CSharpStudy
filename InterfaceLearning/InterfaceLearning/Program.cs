using System;

namespace InterfaceLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket(29
                );
            Ticket ticket1 = new Ticket (29);
            Console.WriteLine("{0}", ticket.Equals(ticket1));
        }
    }
}
