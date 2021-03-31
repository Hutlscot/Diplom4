using Diplom.OtherClass;
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
    /// Логика взаимодействия для AllPropertyPage.xaml
    /// </summary>
    public partial class PropertyPage : Page
    {
        public PropertyPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var conn = new ConnectionDB())
                {
                    MessageBox.Show("Список обновлен, связь с базой данных восстановлена", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception eee)
            {
                Info.Err(eee);
            }
        }
    }
}
