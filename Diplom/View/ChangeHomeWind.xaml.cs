using System.Linq;
using System.Windows;

namespace Diplom.View
{
    using System;

    using Diplom.OtherClass;

    /// <summary>
    /// Логика взаимодействия для ChangeClient.xaml
    /// </summary>
    public partial class ChangeHomeWind : Window
    {
        private static ConnectionDB conn = new ConnectionDB();
        public ChangeHomeWind(int id)
        {
            InitializeComponent();
            DataContext = conn.Homes.FirstOrDefault(x => x.Id == id);
            cmb.ItemsSource = conn.TypeOfHome.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.SaveChanges();
                Info.Suc();
                Close();
            }
            catch (Exception exception)
            {
                Info.Err(exception);
            }
            
        }
    }
}
