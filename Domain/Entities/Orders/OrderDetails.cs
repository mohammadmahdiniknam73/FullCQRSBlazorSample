using Domain.Entities.Products;

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

        public Order Order { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
