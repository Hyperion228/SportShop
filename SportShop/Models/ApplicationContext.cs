using Microsoft.EntityFrameworkCore;

namespace SportShop.Models;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Cart> BasketItems { get; set; } = null!; // товары в корзине
    public DbSet<Product> Products { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }
}