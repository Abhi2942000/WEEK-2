using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI
{
    
        public class BookstoreContext : DbContext
        {
            public BookstoreContext() { }

            public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-OKHSEIJ;Initial Catalog=BookStoreDB;Integrated Security=True;TrustServerCertificate=True;");
            }
            public DbSet<Book> Books { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Book>().ToTable("Books");
            }
        }

    
}
