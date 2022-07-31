using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPiizzaRazor.Models;

namespace MyPiizzaRazor.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita", 
                BasePrice=2,
                Tomatte=true,
                Chese=true,
                Beef=true,
                FinalPrice=10
            },
            new PizzasModel(){
                ImageTitle="Peperoni",
                PizzaName="Peperoni",
                BasePrice=2,
                Tomatte=true,
                Chese=true,
                Margerita=true,
                FinalPrice=5
            },
            new PizzasModel(){
                ImageTitle="Zucchini",
                PizzaName="Zucchini",
                BasePrice=2,
                Tomatte=true,
                Chese=true,
                Zucchini=true,
                FinalPrice=7
            },
            new PizzasModel(){
                ImageTitle="Tomatte",
                PizzaName="Tomatte",
                BasePrice=2,
                Tomatte=true,
                Chese=true,
                Beef=true,
                FinalPrice=8
            },
            new PizzasModel(){
                ImageTitle="Pineapple",
                PizzaName="Pineapple",
                BasePrice=2,
                Tomatte=true,
                Chese=true,
                Pineapple=true,
                FinalPrice=9
            },
            new PizzasModel(){
                ImageTitle="Peperoni",
                PizzaName="Peperoni",
                BasePrice=2,
                Tomatte=true,
                Chese=true,
                Peperoni=true,
                FinalPrice=12
            },
            new PizzasModel(){
                ImageTitle="Chese",
                PizzaName="Chese",
                BasePrice=2,
                Chese=true,
                Margerita=true,
                FinalPrice=14
            },
            new PizzasModel(){
                ImageTitle="Beef",
                PizzaName="Beef",
                BasePrice=2,
                Tomatte=true,
                Chese=true,
                Beef=true,
                FinalPrice=14
            },

        };
        public void OnGet()
        {
        }

    }
}
