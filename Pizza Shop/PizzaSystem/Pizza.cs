using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.PizzaSystem
{
    public class Pizza
    {
        public Pizza(string _title, int _price, ObservableCollection<Toppings> _toppings)
        {
            Title = _title;
            Price = _price;
            Toppings = _toppings;
        }

        public string Title { get; set; } = string.Empty;

        public int Price { get; set; }

        public ObservableCollection<Toppings> Toppings { get; set; } = new();

        public string JoinedToppings => string.Join(", ", Toppings);
    }

    public enum Toppings
    {
        Cheese,
        Tomato,
        Pepperoni,
        Ham,
        Olives,
        Onions,
        Pineapple,
        Lettuce,
        Beef,
        Kebab
    }
}
