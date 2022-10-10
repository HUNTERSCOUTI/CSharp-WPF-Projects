using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop.ViewModels
{
    public partial class MainViewModel : ViewModelBase, 
        IRecipient<UserSignedUpMessage>, IRecipient<UserLoggedInMessage>
    {
        [ObservableProperty] public ObservableObject _selectedViewModel;

        private StartPageViewModel _startPageViewModel;
        private FrontPageViewModel _frontPageViewModel;
        private UserSignUpViewModel _userSignUpViewModel;
        private UserLogInViewModel _userLogInViewModel;

        public MainViewModel()
        {
            _startPageViewModel = new();
            _frontPageViewModel = new();
            _userSignUpViewModel = new();
            _userLogInViewModel = new();


            //First View Shown
            SelectedViewModel = _startPageViewModel;

            WeakReferenceMessenger.Default.RegisterAll(this);
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

        [RelayCommand]
        public void NavigateToSignUpPage()
        {
            SelectedViewModel = _userSignUpViewModel;
        }
        [RelayCommand]
        public void NavigateToLogInPage()
        {
            SelectedViewModel = _userLogInViewModel;
        }

        public void Receive(UserSignedUpMessage message)
        {
            SelectedViewModel = _startPageViewModel;
            
        }
        public void Receive(UserLoggedInMessage message)
        {
            SelectedViewModel = _frontPageViewModel;
            
        }
    }
}
