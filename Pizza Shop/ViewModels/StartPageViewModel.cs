using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pizza_Shop.ViewModels
{
    public class StartPageViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Hello World!";

        public ICommand NavigateFrontCommand { get; }
    }
}
