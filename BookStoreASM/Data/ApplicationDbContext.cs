using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookStoreASM.Models;

namespace BookStoreASM.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookStoreASM.Models.Book> Book { get; set; } = default!;

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<BookStoreASM.Models.ApplicationRole> ApplicationRole { get; set; } = default!;

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}