using CommunityToolkit.Mvvm.ComponentModel;
using Pizza_Shop.PizzaSystem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.ViewModels
{
    public partial class PizzaViewModel : ObservableObject
    {
        public PizzaViewModel(string title, decimal price, IEnumerable<Toppings> toppings)
        {
            Title = title;
            Price = price;
            Toppings = new(toppings);

            Toppings.CollectionChanged += (o, e) =>
            {
                OnPropertyChanged(JoinedToppings);
            };
        }

        [ObservableProperty] private string _title;
        [ObservableProperty] private decimal _price;
        public ObservableCollection<Toppings> Toppings { get; }

        public string JoinedToppings => string.Join(", ", Toppings);
    }
    //https://paste.mod.gg/xqwzojczvmtl/0 
}
