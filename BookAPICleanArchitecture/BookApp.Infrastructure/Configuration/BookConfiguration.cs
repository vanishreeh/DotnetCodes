using BookApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Infrastructure.Configuration
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Name="Book1",
                    Price=1200,
                    AuthorId=1
                });

        }
    }
}