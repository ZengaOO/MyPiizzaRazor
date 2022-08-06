 using Microsoft.EntityFrameworkCore;
using MyPiizzaRazor.Models;

namespace MyPiizzaRazor.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<SelectionRezult> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

    }
    
}
