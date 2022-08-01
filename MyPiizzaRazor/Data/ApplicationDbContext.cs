using Microsoft.EntityFrameworkCore;
using MyPiizzaRazor.Model;

namespace MyPiizzaRazor.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

    }
    
}
