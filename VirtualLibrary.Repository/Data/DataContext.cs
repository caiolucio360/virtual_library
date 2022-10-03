using Microsoft.EntityFrameworkCore;
using System;
using VirtualLibrary.Domain.Models;
using VirtualLibrary.Repository.Configuration;

namespace VirtualLibrary.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        }

        internal object FindAsync(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
