﻿using Pizza_Shop.UserSystem;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Pizza_Shop.Views
{
    public partial class UserSignUpPage : UserControl
    {
        public UserSignUpPage()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, RoutedEventArgs e)
        {
            var _Username = UserName.Text;
            var _Password = PassWord.Text;

            User user = new User(_Username, _Password);



            //if (UserCrud.UserExists(_Username, _Password))
            //{
                UserCrud.SaveNewUser(user);
            //}
            //else
            //{
            //    MessageBox.Show("User already exists");
            //}

        }
    }
}
