using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.PizzaSystem
{
    public class Pizza
    {
        public Pizza(string _title, int _price, List<Toppings> _toppings)
        {
            Title = _title;
            Price = _price;
            Toppings = _toppings;
        }

        public string Title { get; set; } = string.Empty;

        public int Price { get; set; }

        public List<Toppings> Toppings { get; set; } = new();

        public string JoinedToppings => string.Join(", ", Toppings);
    }

    public enum Toppings
    {
        Cheese,
        Tomato,
        Pepperoni,
        Ham,
        Onions,
        Olives
    }
}
