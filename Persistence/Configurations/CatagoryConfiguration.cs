using Domain.Entities.Catagorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CatagoryConfiguration : IEntityTypeConfiguration<Catagory>
    {
        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            builder.HasKey(c =>c.Id);

            builder.Property(c => c.Id).HasConversion(
                catagoryId => catagoryId.Value,
                value => new CatagoryId(value));

            builder.Property(c=>c.Name).IsRequired().HasMaxLength(50);


        }
    }
}
