namespace RazorPizza.Model
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float Price { get; set; }

        public PizzaOrder(string pizzaName, float pizzaPrice)
        {
            PizzaName = pizzaName;
            Price = pizzaPrice;
        }

        public PizzaOrder() { }

    }
}
