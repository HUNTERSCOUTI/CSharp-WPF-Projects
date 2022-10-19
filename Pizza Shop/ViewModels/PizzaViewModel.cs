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
        //public PizzaViewModel(string title, int price, IEnumerable<Toppings> toppings)
        //{
        //    _title = title;
        //    _price = price;
        //    Toppings = new(toppings);

        //    Toppings.CollectionChanged += (o, e) =>
        //    {
        //        OnPropertyChanged(JoinedToppings);
        //    };
        //}

        //[ObservableProperty] private string _title;
        //[ObservableProperty] private int _price;
        //public ObservableCollection<Toppings> Toppings { get; }

        //public string JoinedToppings => string.Join(", ", Toppings);
    }
}
