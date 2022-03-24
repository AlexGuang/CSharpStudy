using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueEnqueueDequeue
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int  OrderQuantity { get; set; }
        

        public Order(int orderId, int orderQuantity)
        {
            this.OrderQuantity = orderQuantity;
            this.OrderId = orderId;
        }



        public void ProcessOrder(int orderId)
        {
            Console.WriteLine($" Order No. {orderId} was  processed!");
        }
    }
}
