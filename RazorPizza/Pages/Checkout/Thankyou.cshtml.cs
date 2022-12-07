using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class ThankyouModel : PageModel
    {
        public string Test { get; set; }
        public void OnGet()
        {
        }
    }
}
