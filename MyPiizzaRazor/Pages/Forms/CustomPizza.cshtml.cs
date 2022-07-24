using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPiizzaRazor.Model;

namespace MyPiizzaRazor.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaModel Pizza { get; set; }
        public void OnGet()
        {
        }
    }
}
