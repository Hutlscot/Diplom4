using Diplom.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Diplom.OtherClasses
{
    public static class Transfer
    {
        public static Frame frame;

        public static void GoTo(string namePage)
        {
            switch (namePage)
            {
                case "Техника":
                    {
                        frame.Navigate(new TechnicPage());
                        break;
                    }
                case "Клиенты":
                    {
                        frame.Navigate(new ClientsPage());
                        break;
                    }
                case "Жилые помещения":
                    {
                        frame.Navigate(new HomesPage());
                        break;
                    }
                default:
                    {
                        MessageBox.Show("not fount");
                        break;
                    }
            }
        }
    }
}
