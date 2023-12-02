using Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasConversion(
                productId => productId.Value,
                value => new ProductId(value));

            builder.Property(p => p.Name).IsRequired().HasMaxLength(128);

            builder.OwnsOne(p => p.Sku, builder => 
            { 
                builder.Property(m => m.Scale).HasMaxLength(20);

            });

            builder.OwnsOne(p => p.Price, builder =>
            {
                builder.Property(m => m.Currency).HasMaxLength(3);
            });
        }
    }
}
