using System.Linq;
using System.Windows;

namespace Diplom.View
{
    using System;

    using Diplom.OtherClass;

    /// <summary>
    /// Логика взаимодействия для ChangeClient.xaml
    /// </summary>
    public partial class ChangeClientWind : Window
    {
        private static ConnectionDB conn = new ConnectionDB();
        public ChangeClientWind(int id)
        {
            InitializeComponent();
            DataContext = conn.Clients.FirstOrDefault(x => x.Id == id);
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
