using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Orders
{
    public class Order
    {
        public OrderId Id { get; set; }
        public Guid UserId { get; set; }
    }
}
