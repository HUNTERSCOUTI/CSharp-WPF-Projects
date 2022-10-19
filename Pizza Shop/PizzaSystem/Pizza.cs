using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.PizzaSystem
{
    public partial class Pizza : ObservableObject
    {
        public Pizza(string _title, int _price, IEnumerable<Toppings> _toppings)
        {
            Title = _title;
            Price = _price;
            if( _toppings != null )
                this._toppings.CollectionChanged += Toppings_CollectionChanged;
        }

        private void Toppings_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(JoinedToppings));
        }

        [ObservableProperty] public string _title = string.Empty;

        [ObservableProperty] public int _price;

        [ObservableProperty] public ObservableCollection<Toppings> _toppings = new();

        public string JoinedToppings => string.Join(", ", _toppings);

        public event PropertyChangedEventHandler? PropertyChanged;
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
