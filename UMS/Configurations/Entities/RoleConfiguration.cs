using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UMS.Configurations.Entities
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Id = "c91e2715-f6d1-4865-9c91-48210911fbba",
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR"
                    },
                    new IdentityRole
                    {
                        Id = "3d4dc1f7-1b8d-46de-8904-1143669bb93c",
                        Name = "Manager",
                        NormalizedName = "MANAGER"
                    },
                    new IdentityRole
                    {
                        Id = "7452daaf-ebe8-49c1-a1ee-59e65ca6f54f",
                        Name = "Employee",
                        NormalizedName = "EMPLOYEE"
                    }
                );
        }
    }
}
