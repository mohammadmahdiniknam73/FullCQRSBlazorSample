using Domain.Entities.Products;
using Domain.Entities.Users;


namespace Domain.Entities.Orders
{
    public class Order
    {
        private readonly HashSet<OrderDetails> _orderDetails = new();

        private Order()
        {

        }

        public OrderId Id { get; private set; }
        public UserId UserId { get; private set; }

        public User User { get; set; }
        public OrderDetails OrderDetails { get; set; }

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
