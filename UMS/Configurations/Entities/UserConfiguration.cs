using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMS.Data;

namespace UMS.Configurations.Entities
{
    public class UserConfiguration : IEntityTypeConfiguration<ApiUser>
    {
        public void Configure(EntityTypeBuilder<ApiUser> builder)
        {
            var hasher = new PasswordHasher<ApiUser>();

            builder.HasData(
                    new ApiUser
                    {
                        Id = "1c3b39f2-60d8-4eb0-8bfc-8c988f97fa7c",
                        FirstName = "John",
                        LastName = "Carter",
                        UserName = "john@example.com",
                        NormalizedUserName = "JOHN@EXAMPLE.COM",
                        Email = "john@example.com",
                        NormalizedEmail = "JOHN@EXAMPLE.COM",
                        PasswordHash = hasher.HashPassword(null, "Abc@123"),
                        PhoneNumber = "0772556545"
                    },
                    new ApiUser
                    {
                        Id = "b3c91fd5-bac2-4ec9-a049-fa4a9a2014e1",
                        FirstName = "Kate",
                        LastName = "Jones",
                        UserName = "kate@example.com",
                        NormalizedUserName = "KATE@EXAMPLE.COM",
                        Email = "kate@example.com",
                        NormalizedEmail = "KATE@EXAMPLE.COM",
                        PasswordHash = hasher.HashPassword(null, "Abc@123"),
                        PhoneNumber = "0712778595"
                    },
                    new ApiUser
                    {
                        Id = "01a43ed8-1651-4bc4-b3f4-97a22307251f",
                        FirstName = "Sam",
                        LastName = "Peterson",
                        UserName = "sam@example.com",
                        NormalizedUserName = "SAM@EXAMPLE.COM",
                        Email = "sam@example.com",
                        NormalizedEmail = "SAM@EXAMPLE.COM",
                        PasswordHash = hasher.HashPassword(null, "Abc@123"),
                        PhoneNumber = "0751223565"
                    }
                );
        }
    }
}
