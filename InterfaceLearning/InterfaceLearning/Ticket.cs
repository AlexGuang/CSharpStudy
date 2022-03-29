using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLearning
{
    internal class Ticket : IEquatable<Ticket>
    {
        public int Duration { get; set; }
        public Ticket(int duration)
        {
            this.Duration = duration;
        }

        public bool Equals(Ticket otherticket)
        {
            return Duration == otherticket.Duration;
        }
    }
}
