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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HIKARIEntities1 context;
        Window Window;
        public MainWindow(HIKARIEntities1 context, Window window)
        {
            InitializeComponent();
            context = new HIKARIEntities1();
            myFrame.Navigate(new Pages.Authorization(context, this));
            Window = window;

        }
    }
}
