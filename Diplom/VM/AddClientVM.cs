using Diplom.OtherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class AddClientVM
    {
        public Clients addedItem { get; set; }
        public AddClientVM()
        {
            addedItem = new Clients();
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (new RelayCommand(obj =>
                {
                    try
                    {
                        var conn = new ConnectionDB();
                        conn.Clients.Add(addedItem);
                        conn.SaveChanges();
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
    }
}
