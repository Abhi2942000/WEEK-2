using ECommerceApp;
using Microsoft.EntityFrameworkCore;

public class ECommerceDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{


    //        services.AddDbContext<ECommerceDbContext>(options =>
    //            options.UseSqlServer("Server = localhost; Database = master; Trusted_Connection = True;"));

    //        // Other service registrations...



    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = localhost; Database = master; Trusted_Connection = True;");
    }
}
