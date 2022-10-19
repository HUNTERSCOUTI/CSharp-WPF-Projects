using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Pizza_Shop.PizzaSystem;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;
using Newtonsoft.Json;

namespace Pizza_Shop.ViewModels
{
    public partial class FrontPageViewModel : ViewModelBase
    {
        [ObservableProperty] private ObservableCollection<Pizza>? _menuPizzas;
        [ObservableProperty] private ObservableCollection<Pizza>? _basketPizzas = new();
        [ObservableProperty] private Pizza? _customPizza = new("Custom Pizza", 0, new ObservableCollection<Toppings> { });
        [ObservableProperty] private int _finalPrice;

        //LAPTOP
        private readonly string fileName = @"C:\Users\zilas\source\repos\CSharp-WPF-Projects\Pizza Shop\PizzaSystem\Pizzas.json";

        //DESKTOP
        //private readonly string fileName = @"C:\Users\ZilasJ\source\repos\CSharp-WPF-Projects\Pizza Shop\PizzaSystem\Pizzas.json";

        public void LoadPizzaJson()
        {
            if (File.Exists(fileName))
            {
                string fileStr = File.ReadAllText(fileName);
                MenuPizzas = JsonConvert.DeserializeObject<ObservableCollection<Pizza>>(fileStr);
            }
        }

        public void GetFinalPrice()
        {
            int tempPrice = 0;
            foreach (Pizza pizza in BasketPizzas)
            {
                tempPrice += pizza.Price;
            }
            FinalPrice =+ tempPrice;
        }

        public void GetCustomPrice()
        {
            int price = 2; // Extra pizza custom fee
            foreach(Toppings topping in CustomPizza.Toppings)
            {
                price += 5;
            }
            CustomPizza.Price = price;
        }
    }
}
