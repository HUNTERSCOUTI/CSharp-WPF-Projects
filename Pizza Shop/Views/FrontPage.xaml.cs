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

        public FrontPageViewModel fpVM = new();

        public FrontPage()  
        {
            InitializeComponent();

            fpVM.LoadPizzaJson();

            DataContext = fpVM;
        }

        private void startNewCustom()
        {
            fpVM.CustomPizza = new Pizza("", 0, new ObservableCollection<Toppings> { });
            fpVM.GetCustomName();

            Cheese.IsChecked = true;
            fpVM.CustomPizza._toppings.Add(Toppings.Cheese);

            Tomato.IsChecked = true;
            fpVM.CustomPizza._toppings.Add(Toppings.Tomato);

            #region CheckBoxesDisable
            Pepperoni.IsChecked = false;
            Lettuce.IsChecked = false;
            Kebab.IsChecked = false;
            Beef.IsChecked = false;
            Onions.IsChecked = false;
            Olives.IsChecked = false;
            Ham.IsChecked = false;
            Pineapple.IsChecked = false;
            #endregion
                
            fpVM.GetCustomPrice();
            
        }


        private void btnCheckOut(object sender, RoutedEventArgs e)
        {
            ConfirmWindow confirmWindow = new(fpVM.BasketPizzas, fpVM.FinalPrice);
            confirmWindow.Show();
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
            startNewCustom();
        }

        private void Basket_Remove(object sender, RoutedEventArgs e)
        {
            fpVM.BasketPizzas.Remove(fpVM.MenuPizzas[defaultPizzasMenu.Items.IndexOf((sender as FrameworkElement).DataContext)]);
            fpVM.GetFinalPrice();
        }

        private void ToppingPizza(object sender, RoutedEventArgs e)
        {
            string objname = ((CheckBox)sender).Name;

            switch (objname)
            {
                case "Cheese":
                    if (Cheese.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Cheese);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Cheese);
                    }
                    break;

                case "Tomato":
                    if (Tomato.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Tomato);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Tomato);
                    }
                    break;

                case "Pepperoni":
                    if (Pepperoni.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Pepperoni);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Pepperoni);
                    }
                    break;

                case "Ham":
                    if (Ham.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Ham);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Ham);
                    }
                    break;

                case "Olives":
                    if (Olives.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Olives);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Olives);
                    }
                    break;

                case "Onions":
                    if (Onions.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Onions);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Onions);
                    }
                    break;

                case "Lettuce":
                    if (Lettuce.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Lettuce);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Lettuce);
                    }
                    break;

                case "Pineapple":
                    if (Pineapple.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Pineapple);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Pineapple);
                    }
                    break;

                case "Beef":
                    if (Beef.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Beef);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Beef);
                    }
                    break;

                case "Kebab":
                    if (Kebab.IsChecked == true)
                    {
                        fpVM.CustomPizza._toppings.Add(Toppings.Kebab);
                    }
                    else
                    {
                        fpVM.CustomPizza._toppings.Remove(Toppings.Kebab);
                    }
                    break;
            }
            fpVM.GetCustomPrice();
        }
    }
}
