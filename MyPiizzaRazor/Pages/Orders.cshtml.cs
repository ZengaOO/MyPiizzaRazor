using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPiizzaRazor.Data;
using MyPiizzaRazor.Models;

namespace MyPiizzaRazor.Pages
{
    public class OrdersModel : PageModel
    {
        public List<SelectionRezult> PizzaOrders = new List<SelectionRezult>();

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {

            PizzaOrders = _context.PizzaOrders.ToList();

        }
    }
}
