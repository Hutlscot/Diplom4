﻿using Diplom.View;
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
                case "История аренды":
                    {
                        frame.Navigate(new HistoryRentalPage());
                        break;
                    }
                case "Всё имущество":
                    {
                        frame.Navigate(new AllPropertyPage());
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
                default:
                    {
                        MessageBox.Show("not fount");
                        break;
                    }
            }
        }
    }
}
