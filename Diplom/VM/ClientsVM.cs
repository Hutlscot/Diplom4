using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class ClientsVM
    {
        public List<Clients> listItem { get; set; }

        public Clients selectedItem { get; set; }
        public ClientsVM()
        {
            var conn = new ConnectionDB();
            listItem = conn.Clients.ToList();
        }

        private RelayCommand commandGoTo;
        public RelayCommand CommandGoTo
        {
            get
            {
                return commandGoTo ?? (new RelayCommand(
                    title =>
                    {
                        Transfer.GoTo(title.ToString());
                    }));
            }
        }

        private RelayCommand delCommand;
        public RelayCommand DelCommand
        {
            get
            {
                return delCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                            var conn = new ConnectionDB();
                            conn.Clients.Remove(conn.Clients.Find(selectedItem.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("Клиенты");
                            MessageBox.Show("Успешно удалено");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show($"Ошибка удаления\n{e}");
                        }

                    }));
            }
        }
    }
}
