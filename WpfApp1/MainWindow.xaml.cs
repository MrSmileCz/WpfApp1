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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myLabel.Content = $"Clicked 0 times!";
            myCalendar.SelectedDate = DateTime.Now;
        }

        public int clicks = 0;

        private void firstButton_OnClick(object sender, RoutedEventArgs e)
        {
            clicks++;
            myLabel.Content = $"Clicked {clicks} times!";
        }

        private void myFormButton_OnCLick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{myTextBox.Text}, {myCalendar.SelectedDate}", "Warning", MessageBoxButton.YesNoCancel, icon:MessageBoxImage.Question);
        }
    }
}
