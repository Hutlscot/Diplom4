using Diplom.OtherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    class HomesPageVM
    {
        public List<Homes> listItem { get; set; }

        public Homes selectedItem { get; set; }
        public HomesPageVM()
        {
            var conn = new ConnectionDB();
            listItem = conn.Homes.ToList();
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
                            conn.Homes.Remove(conn.Homes.Find(selectedItem.Id));
                            conn.SaveChanges();
                            Info.Suc();
                            Trans.Go("Жилые помещения");
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
