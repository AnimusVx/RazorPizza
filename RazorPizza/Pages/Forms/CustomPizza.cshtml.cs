using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Model;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost() 
        {
            PizzaPrice = Pizza.BasePrice;
            PizzaPrice += Pizza.Sauce ? 5 : 0;
            PizzaPrice += Pizza.Cheese ? 10 : 0;
            PizzaPrice += Pizza.Peperoni ? 10 : 0;
            PizzaPrice += Pizza.Ham ? 10 : 0;
            PizzaPrice += Pizza.Beef ? 10 : 0;
            PizzaPrice += Pizza.Pineapple ? 10 : 0;
            PizzaPrice += Pizza.Tuna ? 10 : 0;
            PizzaPrice += Pizza.Mushroom ? 10 : 0;


            return RedirectToPage("/Checkout/Checkout", new { Pizza.Name, PizzaPrice, Contains = Pizza.ToString() });
        }
    }
}
