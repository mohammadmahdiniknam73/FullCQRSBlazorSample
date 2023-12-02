using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u=>u.Id);

            builder.Property(u => u.Id).HasConversion(
                userId => userId.Value,
                value=> new UserId(value));

            builder.Property(u => u.Name).IsRequired().HasMaxLength(75);
            builder.Property(u => u.SirName).IsRequired().HasMaxLength(75);

            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.Property(u=>u.Email).IsRequired().HasMaxLength(255);
            builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(10);
            builder.Property(u=> u.Password).IsRequired().HasMaxLength(20);

            builder.HasIndex(u => u.UserName).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.PhoneNumber).IsUnique();
        }
    }
}
