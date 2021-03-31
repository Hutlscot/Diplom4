using Diplom.OtherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    using Diplom.View;

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
                        Trans.Go(title.ToString());
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
                            Info.Suc();
                            Trans.Go("Клиенты");
                        }
                        catch (Exception e)
                        {
                            Info.Err(e);
                        }

                    }));
            }
        }
        private RelayCommand changeCommand;
        public RelayCommand ChangeCommand
        {
            get
            {
                return changeCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                            var wind = new ChangeClientWind(selectedItem.Id);
                            wind.ShowDialog();
                            Trans.Go("Клиенты");
                        }
                        catch (Exception e)
                        {
                            Info.Err(e);
                        }

                    }));
            }
        }
    }
}
