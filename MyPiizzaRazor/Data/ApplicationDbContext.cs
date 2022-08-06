﻿ using Microsoft.EntityFrameworkCore;
using MyPiizzaRazor.Models;

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
