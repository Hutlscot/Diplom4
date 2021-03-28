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

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для HistoryRentalPage.xaml
    /// </summary>
    public partial class HistoryRentalPage : Page
    {
        ConnectionDB conn;
        public HistoryRentalPage()
        {
            InitializeComponent();
            conn = new ConnectionDB();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = (sender as TextBox).Text;
            data_grid.ItemsSource = conn.HistoryRental.Where(x => x.Property.Name.Contains(search)).ToList();
        }
    }
}
