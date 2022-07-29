using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPiizzaRazor.Pages.Checkout
{
    public class ThankYouModel : PageModel
    {
        public PizzaModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
    }
}
