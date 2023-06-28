using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для kliPage.xaml
    /// </summary>
    public partial class kliPage : Page
    {
        HIKARIEntities1 context;

        public kliPage(HIKARIEntities1 _cont)
        {
            InitializeComponent();
            context = _cont;
            cliData.ItemsSource = context.Client.ToList();


        }

        private void EditClick(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveClick(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
