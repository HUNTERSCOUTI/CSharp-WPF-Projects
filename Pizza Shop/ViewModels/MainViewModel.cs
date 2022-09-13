using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty] private ObservableObject _selectedViewModel;

        private StartPageViewModel _startPageViewModel;
        private FrontPageViewModel _frontPageViewModel;

        public MainViewModel()
        {
            _startPageViewModel = new();
            _frontPageViewModel = new();

            SelectedViewModel = _startPageViewModel;
        }

        [RelayCommand]
        public void NavigateToStartPage()
        {
            SelectedViewModel = _startPageViewModel;
        }

        [RelayCommand]
        public void NavigateToFrontPage()
        {
            SelectedViewModel = _frontPageViewModel;
        }
    }
}
