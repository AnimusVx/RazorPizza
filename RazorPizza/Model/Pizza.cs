namespace RazorPizza.Model
{
    public class Pizza
    {
        public string Name { get; set; }
        public string ImageTitle { get; set; }
        public float BasePrice { get; set; } = 10;
        public bool Sauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public float FinalPrice { get; set; }   

        public override string ToString()
        {
            string ret = "";
            ret += (Sauce ? "Sauce " : "") +
                   (Cheese ? "Cheese " : "") +
                   (Peperoni ? "Peperoni " : "") +
                   (Mushroom ? "Mushroom " : "") +
                   (Tuna ? "Tuna " : "") +
                   (Pineapple ? "Pineapple " : "") +
                   (Ham ? "Ham " : "") +
                   (Beef ? "Beef " : "");
            return ret;
        }
    }
}
