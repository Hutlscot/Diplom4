using System.Linq;
using System.Windows;

namespace Diplom.View
{
    using System;

    using Diplom.OtherClass;

    /// <summary>
    /// Логика взаимодействия для ChangeClient.xaml
    /// </summary>
    public partial class ChangeTechnicWind : Window
    {
        private static ConnectionDB conn = new ConnectionDB();
        public ChangeTechnicWind(int id)
        {
            InitializeComponent();
            DataContext = conn.Technic.FirstOrDefault(x => x.Id == id);
            cmb.ItemsSource = conn.TypeOfTechnic.ToList();
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