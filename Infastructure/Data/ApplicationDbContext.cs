using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> users { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Author> author { get; set; }
        public DbSet<Genre> genre { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Book> books { get; set; }
    }
}
