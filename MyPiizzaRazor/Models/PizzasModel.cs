namespace MyPiizzaRazor.Model
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool Tomatte { get; set; }
        public bool Chese { get; set; }
        public bool Peperoni { get; set; }
        public bool Margerita { get; set; }
        public bool Zucchini { get; set; }
        public bool Pineapple { get; set; }
        public bool Beef { get; set; }
        public float FinalPrice { get; set; }




    }
}
