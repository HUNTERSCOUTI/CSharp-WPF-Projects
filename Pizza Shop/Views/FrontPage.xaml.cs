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

        static ObservableCollection<Toppings> CustomToppings = new();

        public FrontPage()  
        {
            InitializeComponent();

            fpVM.LoadPizzaJson();

            DataContext = fpVM;
        }

        private void Basket_Add(object sender, RoutedEventArgs e)
        {
            fpVM.BasketPizzas.Add(fpVM.MenuPizzas[defaultPizzasMenu.Items.IndexOf((sender as FrameworkElement).DataContext)]);
            fpVM.GetFinalPrice();
        }
        private void CustomBasket_Add(object sender, RoutedEventArgs e)
        {
            fpVM.BasketPizzas.Add(fpVM.CustomPizza);
            fpVM.GetFinalPrice();
        }

        private void Basket_Remove(object sender, RoutedEventArgs e)
        {
            fpVM.BasketPizzas.Remove(fpVM.MenuPizzas[defaultPizzasMenu.Items.IndexOf((sender as FrameworkElement).DataContext)]);
            fpVM.GetFinalPrice();
        }


        private void CheesePizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Cheese);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Cheese);
            }
        }

        private void TomatoPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Tomato);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Tomato);
            }
        }

        private void PepperoniPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Pepperoni);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Pepperoni);
            }
        }

        private void HamPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Ham);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Ham);
            }
        }

        private void OlivesPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Olives);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Olives);
            }
        }

        private void OnionsPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Onions);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Onions);
            }
        }

        private void LettucePizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Lettuce);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Lettuce);
            }
        }

        private void PineapplePizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Pineapple);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Pineapple);
            }
        }

        private void BeefPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Beef);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Beef);
            }
        }

        private void KebabPizza(object sender, RoutedEventArgs e)
        {
            if (Cheese.IsChecked == true)
            {
                fpVM.CustomPizza.Toppings.Add(Toppings.Kebab);
            }
            else
            {
                fpVM.CustomPizza.Toppings.Remove(Toppings.Kebab);
            }
        }
    }
}
