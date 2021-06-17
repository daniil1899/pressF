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
using System.Windows.Shapes;

namespace teat_WPF_1
{
    /// <summary>
    /// Логика взаимодействия для Rieltor.xaml
    /// </summary>
    public partial class Rieltor : Window
        
        
    {

        public Rieltor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            Hide();
        }

        private void RR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
