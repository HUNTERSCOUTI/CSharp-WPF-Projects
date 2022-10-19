using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.PizzaSystem
{
    public class Pizza : ObservableObject
    {
        public Pizza(string _title, int _price, IEnumerable<Toppings> _toppings)
        {
            Title = _title;
            Price = _price;
            if( _toppings != null )
                Toppings = new(_toppings);

            Toppings.CollectionChanged += (o, e) =>
            {
                OnPropertyChanged(JoinedToppings);
            };
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
