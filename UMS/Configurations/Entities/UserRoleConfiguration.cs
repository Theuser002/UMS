using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UMS.Configurations.Entities
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = "01a43ed8-1651-4bc4-b3f4-97a22307251f",
                        RoleId = "3d4dc1f7-1b8d-46de-8904-1143669bb93c"
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1",
                        RoleId = "7452daaf-ebe8-49c1-a1ee-59e65ca6f54f"
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = "1c3b39f2-60d8-4eb0-8bfc-8c988f97fa7c",
                        RoleId = "c91e2715-f6d1-4865-9c91-48210911fbba"
                    }
                );
        }
    }
}
