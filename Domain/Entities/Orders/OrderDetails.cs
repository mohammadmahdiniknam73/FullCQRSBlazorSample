using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Orders
{
    public class OrderDetails
    {
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public Money Price { get; set; }

    }
}
