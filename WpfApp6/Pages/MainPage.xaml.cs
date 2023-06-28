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

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Window Window;
        HIKARIEntities1 _context;
        public MainPage(HIKARIEntities1 context, Window window)
        {
            
                InitializeComponent();
                Window = window;
                _context = context;
            
        }

        private void escape(object sender, RoutedEventArgs e)
        {
            this.Window.Close();
        }

        private void EscapeClick(object sender, RoutedEventArgs e)
        {
           // Window.Close();
            NavigationService.GoBack();
        }

        private void SotrClick(object sender, RoutedEventArgs e)
        {
            frameToBasePages.Navigate(new UserInWork(_context));
        }

        private void ItemClick(object sender, RoutedEventArgs e)
        {
            frameToBasePages.Navigate(new toyPage(_context));
        }

        private void kliClick(object sender, RoutedEventArgs e)
        {
            frameToBasePages.Navigate(new kliPage(_context));
        }
    }
}
