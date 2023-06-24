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
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Page
    {
        HIKARIEntities1 context;
        public AddOrder(HIKARIEntities1 c)
        {
            InitializeComponent();
            context = c;

        }

        private void CanselCkick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        private void AddOrderClick(object sender, RoutedEventArgs e)
        {
                
        }
    }
}
