using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Pizza_Shop.ViewModels;
using System.Windows.Shapes;
using Pizza_Shop.PizzaSystem;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Pizza_Shop.Views
{
    public partial class FrontPage : UserControl
    {

        FrontPageViewModel fpVM = new();

        [ObservableProperty] public Pizza CustomPizza = new("Custom Pizza", 0, CustomToppings);

        static ObservableCollection<Toppings> CustomToppings = new();

        public FrontPage()  
        {
            InitializeComponent();

            fpVM.LoadPizzaJson();
            //fpVM.CustomPizzaSetter(customPizza);

            DataContext = fpVM;
        }

        private void Basket_Add(object sender, RoutedEventArgs e)
        {
            fpVM._basketPizzas.Add(fpVM._menuPizzas[defaultPizzasMenu.Items.IndexOf((sender as FrameworkElement).DataContext)]);
            fpVM.GetFinalPrice();
        }
        private void CustomBasket_Add(object sender, RoutedEventArgs e)
        {
            fpVM._basketPizzas.Add(CustomPizza);
            fpVM.GetFinalPrice();
        }

        private void Basket_Remove(object sender, RoutedEventArgs e)
        {
            fpVM._basketPizzas.Remove(fpVM._menuPizzas[defaultPizzasMenu.Items.IndexOf((sender as FrameworkElement).DataContext)]);
            fpVM.GetFinalPrice();
        }


        private void CheesePizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Cheese);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Cheese);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void TomatoPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Tomato);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Tomato);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void PepperoniPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Pepperoni);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Pepperoni);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void HamPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Ham);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Ham);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void OlivesPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Olives);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Olives);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void OnionsPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Onions);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Onions);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void LettucePizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Lettuce);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Lettuce);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void PineapplePizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Pineapple);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Pineapple);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void BeefPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Beef);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Beef);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }

        private void KebabPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                CustomPizza.Toppings.Add(Toppings.Kebab);
            }
            else
            {
                CustomPizza.Toppings.Remove(Toppings.Kebab);
            }
            //fpVM.CustomPizzaSetter(customPizza);
        }
    }
}
