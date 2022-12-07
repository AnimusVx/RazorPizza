using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Model;
using System.Xml.Linq;

namespace RazorPizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class ThankyouModel : PageModel
    {
        public string Name { get; set; }
        public float PizzaPrice { get; set; }

        private PizzaDbContext _db;

        public ThankyouModel(PizzaDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            

            PizzaOrder pizzaOrder = new PizzaOrder(Name, PizzaPrice);
            _db.PizzaOrders.Add(pizzaOrder);
            _db.SaveChanges();
        }
    }
}
