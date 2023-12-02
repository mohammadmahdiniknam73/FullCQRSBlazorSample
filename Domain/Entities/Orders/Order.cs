using Domain.Entities.OrderDetails;
using Domain.Entities.Products;
using Domain.Entities.Users;


namespace Domain.Entities.Orders
{
    public class Order
    {
        private readonly HashSet<OrderDetail> _orderDetail = new();

        private Order()
        {

        }

        public OrderId Id { get; private set; }
        public UserId UserId { get; private set; }

        public User User { get; set; }
        public OrderDetail OrderDetail { get; set; }

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
            var orderDetail = new OrderDetail(
                new OrderDetailId(Guid.NewGuid()),
                Id,
                productId,
                price);

            _orderDetail.Add(orderDetail);
        }
    }
}
