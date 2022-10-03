using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualLibrary.Domain.Models;

namespace VirtualLibrary.Repository.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PublisherId).IsRequired();
            builder.Property(x => x.ReleaseDate).IsRequired();
        }
    }
}
