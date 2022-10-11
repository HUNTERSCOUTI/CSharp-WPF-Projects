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
        [ObservableProperty] private static ObservableCollection<Pizza>? _menuPizzas;
        [ObservableProperty] private static ObservableCollection<Pizza>? _basketPizzas;
        private static readonly string fileName = @"C:\Users\LenovoThinkpad\source\repos\CSharp-WPF-Projects\Pizza Shop\PizzaSystem\Pizzas.json";

        public static void LoadPizzaJson()
        {
            if (File.Exists(fileName))
            {
                string fileStr = File.ReadAllText(fileName);
                _menuPizzas = JsonConvert.DeserializeObject<ObservableCollection<Pizza>>(fileStr);
            }
        }
    }
}
