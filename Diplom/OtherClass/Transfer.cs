using Diplom.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Diplom.OtherClass
{
    public static class Trans
    {
        public static Frame frame;

        public static void Go(string namePage)
        {
            switch (namePage)
            {
                case "История аренды":
                    {
                        frame.Navigate(new HistoryRentalPage());
                        break;
                    }
                case "Всё имущество":
                    {
                        frame.Navigate(new PropertyPage());
                        break;
                    }
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
                case "Добавить клиента":
                    {
                        frame.Navigate(new AddClientPage());
                        break;
                    }
                case "Добавить технику":
                    {
                        frame.Navigate(new AddTechnicPage());
                        break;
                    }
                case "Добавить помещение":
                    {
                        frame.Navigate(new AddHomePage());
                        break;
                    }
                case "Добавить запись":
                    {
                        frame.Navigate(new AddHistoryRentalPage());
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
