using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizza.Pages.Checkout
{
    public class CheckoutModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        [BindProperty(SupportsGet = true)]
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(Name))
            {
                Name = "Custom Pizza";
            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
