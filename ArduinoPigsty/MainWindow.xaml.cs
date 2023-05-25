using System;
using System.Collections.Generic;
using System.IO.Ports;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ArduinoPigsty
{
    public partial class MainWindow : Window
    {
        SerialPort sp = new();
        bool myLED = false;
        VM vm = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedComboItem = sender as ComboBox;
            string name = selectedComboItem.SelectedItem as string;
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string portName = COM.SelectedItem as string;
                sp.PortName = portName;
                sp.BaudRate = 9600;
                sp.Open();
                status.Content = "Connected";
            }
            catch (Exception)
            {

                MessageBox.Show("Please give a valid port number or check your connection");
            }
        }

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string incomString = sender as string;
            SetText(incomString);
        }

        private void SetText(string val)
        {
            Test.Text = val;
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sp.Close();
                status.Content = "Disconnected";
            }
            catch (Exception)
            {

                MessageBox.Show("Cannot Disconnect if not connected");
            }
        }

        private void LED_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (myLED)
                {
                    sp.Write("2");
                    myLED = !myLED;
                }
                else
                {
                    sp.Write("1");
                    myLED = !myLED;
                }
            }
            catch
            {
                MessageBox.Show("PORT NOT CONNECTED");
            }
        }
    }
}
