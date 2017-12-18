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

namespace FabLabUI
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Profiler_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Profiles.xaml", UriKind.Relative));
        }

        private void Projects_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Projects.xaml", UriKind.Relative));
        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Booking.xaml", UriKind.Relative));
        }
    }
}
