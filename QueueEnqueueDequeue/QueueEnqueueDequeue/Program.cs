using System;
using System.Collections.Generic;

namespace QueueEnqueueDequeue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> queue = new Queue<Order>();

            foreach ( Order o in ReceiveOrderFromBranchOne())
            {
                queue.Enqueue(o);
            }

            foreach (Order item in ReceiveOrderFromBranchTwo())
            {
                queue.Enqueue(item);
            }

            do
            {
                Order order = queue.Dequeue();
                Console.WriteLine("Now the {0} order is processing",order.OrderId);
                order.ProcessOrder(order.OrderId);


            } while (queue.Count > 0);

        }

        public static Order[] ReceiveOrderFromBranchOne()
        {
            Order[] branch1 = new Order[]
            {
                new Order(1, 4),
                new Order(2, 5),
                new Order(6, 6),
            };
            return branch1;
        }
        public static Order[] ReceiveOrderFromBranchTwo()
        {
            Order[] branch2 = new Order[]
            {
                new Order(3, 10),
                new Order(4, 15),
                new Order(5, 16),
            };
            return branch2;
        }
    }
}
