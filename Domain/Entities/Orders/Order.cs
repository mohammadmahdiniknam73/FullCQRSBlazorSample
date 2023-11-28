using Domain.Entities.Products;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Orders
{
    public class Order
    {
        private readonly HashSet<OrderDetails> _orderDetails = new();

        private Order()
        {

        }

        public OrderId Id { get; set; }
        public UserId UserId { get; set; }

        public static Order Create(User user)
        {
            var order = new Order()
            {
                Id = new OrderId(Guid.NewGuid()),
                UserId = user.Id
            };
            
            return order;
        }
        public void Add(ProductId productId, Money price)
        {
            var orderDetail = new OrderDetails(
                new OrderDetailsId(Guid.NewGuid()),
                Id,
                productId,
                price);

            _orderDetails.Add(orderDetail);
        }
    }
}
