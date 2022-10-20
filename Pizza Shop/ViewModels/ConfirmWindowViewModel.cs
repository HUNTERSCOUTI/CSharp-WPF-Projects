using CommunityToolkit.Mvvm.ComponentModel;
using Pizza_Shop.PizzaSystem;
using Pizza_Shop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.ViewModels
{
    public partial class ConfirmWindowViewModel : ObservableObject
    {
        [ObservableProperty] private string? _listOfPizzaNames;
        [ObservableProperty] private int? _finalPrice;

        public void LoadPizzaNamesAndPrice(ObservableCollection<Pizza> pizzas)
        {
            List<string> pizzasBought = new();
            for (int i = 0; i < pizzas.Count; i++)
            {
                if (i < 24)
                {
                    pizzasBought.Add(pizzas[i].Title);
                }
                else
                {
                    pizzasBought.Add("   (+ More)");
                    break;
                }
            }
            ListOfPizzaNames = string.Join(", ", pizzasBought);
        }
    }
}
