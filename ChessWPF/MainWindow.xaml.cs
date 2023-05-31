using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChessWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BoardClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            //Button coloredButtons = null;


            //Char conversions to board coordinates
            int X = button.Name[0] - 96;
            int Y = button.Name[1] - 48;


            var stackPanel = (StackPanel)button.Parent;
            //var grid = stackPanel.Parent;

            Button coloredButton = (Button)stackPanel.Children[Y];
            Brush nextButtonBackground = coloredButton.Background;

            if (Y != 8)
            {

                coloredButtons.Background = Brushes.Black;

            }

            if (lastPressedButton != null)
                coloredButtons.Background = lastPressedButton.Background;


        }
    }
}
