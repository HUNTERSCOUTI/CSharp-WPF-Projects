﻿using System;
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
using System.Windows.Shapes;

namespace Pizza_Shop.Views
{
    public partial class FrontPage : UserControl
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            
        }
        
        public bool SendDragCommand(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                return true;
            }
            return false;
        }
    }
}
