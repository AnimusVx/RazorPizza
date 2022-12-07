using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Model;
using System.Collections;
using System.Collections.Generic;

namespace RazorPizza.Pages.Admin
{
    public class PizzaOrderListingModel : PageModel
    {
        public IEnumerable<PizzaOrder> PizzaOrders { get; set; }
        private readonly PizzaDbContext _db;    
        public PizzaOrderListingModel(PizzaDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            PizzaOrders = _db.PizzaOrders;
        }
    }
}
