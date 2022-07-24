using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPiizzaRazor.Pages
{
    public class PizzaModel : PageModel
    {
        public PizzaModel Pizza { get; set; }

       public void OnGet()
        {
        }
    }
}
