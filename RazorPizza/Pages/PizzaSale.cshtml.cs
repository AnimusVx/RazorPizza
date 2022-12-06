using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Model;

namespace RazorPizza.Pages
{
    public class PizzaSaleModel : PageModel
    {
        public List<Pizza> FakePizzaDb = new List<Pizza>
        {
            new Pizza {
                ImageTitle="Margerita",
                Name="Margerita",
                Sauce=true,
                Cheese=true,
                FinalPrice=40
            },
            new Pizza {
                ImageTitle = "Bolognese",
                Name = "Bolognese",
                Sauce = true,
                Cheese = true,
                Beef = true,
                FinalPrice = 50
            },
            new Pizza {
                ImageTitle="Carbonara",
                Name="Carbonara",
                Sauce=true,
                Cheese=true,
                Ham=true,
                FinalPrice=50
            },
            new Pizza {
                ImageTitle="Hawaiian",
                Name="Hawaiian",
                Sauce=true,
                Cheese=true,
                Peperoni=true,
                Pineapple=true,
                FinalPrice=60
            },
            new Pizza {
                ImageTitle="MeatFeast",
                Name="MeatFeast",
                Sauce=true,
                Cheese=true,
                FinalPrice=40
            },
            new Pizza {
                ImageTitle="Mushroom",
                Name="Mushroom",
                Sauce=true,
                Cheese=true,
                FinalPrice=40
            },
            new Pizza {
                ImageTitle="Pepperoni",
                Name="Pepperoni",
                Sauce=true,
                Cheese=true,
                FinalPrice=40
            },
            new Pizza {
                ImageTitle="Seafood",
                Name="Seafood",
                Sauce=true,
                Cheese=true,
                FinalPrice=40
            },
            new Pizza {
                ImageTitle="Vegetarian",
                Name="Vegetarian",
                Sauce=true,
                Cheese=true,
                FinalPrice=40
            }
        };
        public void OnGet()
        {
        }
    }
}
