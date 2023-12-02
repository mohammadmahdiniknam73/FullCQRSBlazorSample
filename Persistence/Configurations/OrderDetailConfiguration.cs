using Domain.Entities.OrderDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(od => od.Id);

            builder.Property(od => od.Id).HasConversion(
                orderDetailId => orderDetailId.Value,
                value => new OrderDetailId(value));

            builder.OwnsOne(od => od.Price,builder =>
            {
                builder.Property(m => m.Currency).HasMaxLength(3);
            });
        }
    }
}
