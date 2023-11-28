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

        internal OrderDetails(OrderDetailsId id, OrderId orderId, ProductId productId, Money price)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;
        }

        public OrderDetailsId Id { get; private set; }
        public ProductId ProductId { get; private set; }
        public OrderId OrderId { get; private set; }
        public Money Price { get; private set; }

    }
}
