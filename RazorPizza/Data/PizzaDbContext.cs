using Microsoft.EntityFrameworkCore;
using RazorPizza.Model;

namespace RazorPizza.Data
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options)
        {

        }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }  
    }
}
