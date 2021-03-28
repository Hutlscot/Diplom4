using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.OtherClass
{
    public static class Info
    {
        public static void Err(Exception e)
        {
            MessageBox.Show($"Исключение\n{e}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void Suc()
        {
            MessageBox.Show("Успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
