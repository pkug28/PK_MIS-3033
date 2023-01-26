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

namespace PK_FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calculateAgeButton.Background = Brushes.WhiteSmoke;
            
        }

        private void nameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void calculateAgeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            DateTime birthdate = Convert.ToDateTime(birthdatePicker.SelectedDate);
            var age = DateTime.Now - birthdate;
            string message = ($"{name}! You are {(age.TotalDays/365).ToString("N2")} years old!");
            MessageBox.Show(message);
        }

        private void calculateAgeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            calculateAgeButton.Background = Brushes.Green;
        }

        private void calculateAgeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            calculateAgeButton.Background = Brushes.WhiteSmoke;
        }
    }
}
