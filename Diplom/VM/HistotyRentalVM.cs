using Diplom.OtherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    class HistotyRentalVM
    {
        public List<HistoryRental> listItem { get; set; }

        public HistoryRental selectedItem { get; set; }
        public HistotyRentalVM()
        {
            var conn = new ConnectionDB();
            listItem = conn.HistoryRental.ToList();
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
                            conn.HistoryRental.Remove(conn.HistoryRental.Find(selectedItem.Id));
                            conn.SaveChanges();
                            Info.Suc();
                            Trans.Go("История аренды");
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
