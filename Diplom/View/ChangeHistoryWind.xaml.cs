using System.Linq;
using System.Windows;

namespace Diplom.View
{
    using System;

    using Diplom.OtherClass;

    /// <summary>
    /// Логика взаимодействия для ChangeClient.xaml
    /// </summary>
    public partial class ChangeHistoryWind : Window
    {
        private static ConnectionDB conn = new ConnectionDB();
        public ChangeHistoryWind(int id)
        {
            InitializeComponent();
            var history = conn.HistoryRental.FirstOrDefault(x => x.Id == id);
            DataContext = history;
            cmb1.ItemsSource = conn.Clients.ToList();
            cmb2.ItemsSource = conn.Property.ToList();
            timeStart.SelectedTime = history.TimeStart.ConvertToDateTime();
            timeEnd.SelectedTime = history.TimeEnd.ConvertToDateTime();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var histoty = (DataContext as HistoryRental);
                histoty.TimeStart = timeStart.SelectedTime.GetValueOrDefault().ConvertToTimeSpan();
                histoty.TimeEnd = timeEnd.SelectedTime.GetValueOrDefault().ConvertToTimeSpan();
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