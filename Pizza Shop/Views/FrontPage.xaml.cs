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

namespace Pizza_Shop.Views
{
    public partial class FrontPage : UserControl
    {

        FrontPageViewModel fpVM = new();

        public FrontPage()
        {
            InitializeComponent();
            fpVM.LoadPizzaJson();
            DataContext = fpVM;
        }

        private void Basket_Add(object sender, RoutedEventArgs e)
        {
            fpVM._basketPizzas.Add(fpVM._menuPizzas[defaultPizzasMenu.Items.IndexOf((sender as FrameworkElement).DataContext)]);
        }

        private void Basket_Remove(object sender, RoutedEventArgs e)
        {
            fpVM._basketPizzas.Remove(fpVM._menuPizzas[defaultPizzasMenu.Items.IndexOf((sender as FrameworkElement).DataContext)]);
        }
    }
}
