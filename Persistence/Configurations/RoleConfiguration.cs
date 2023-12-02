using Domain.Entities.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r=>r.Id);

            builder.Property(r => r.Id).HasConversion(
                roleId => roleId.Value,
                value => new RoleId(value));

            builder.Property(r => r.RoleName).IsRequired().HasMaxLength(50);
        }
    }
}

