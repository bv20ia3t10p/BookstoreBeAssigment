using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author
                {
                    Id = 1,
                    LastName = "Nguyen",
                    FirstName = "Thi",
                    Phone = "090999",
                    Address = "Xa Lo Ha Noi Street",
                    State = "Thu Duc",
                    Zip = "07000",
                    EmailAddress = "nguyenthi999@gmail.com"
                },
                new Author
                {
                    Id = 1,
                    LastName = "Pham",
                    FirstName = "Anh",
                    Phone = "090888",
                    Address = "Nguyen Duy Trinh Street",
                    State = "Go Vap",
                    Zip = "08000",
                    EmailAddress = "phamanh888@gmail.com"
                }
            );
        }
    }
}
