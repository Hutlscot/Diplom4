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

    class TechnicVM
    {
        public List<Technic> listItem { get; set; }

        public Technic selectedItem { get; set; }
        public TechnicVM()
        {
            var conn = new ConnectionDB();
            listItem = conn.Technic.ToList();
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
                            conn.Technic.Remove(conn.Technic.Find(selectedItem.Id));
                            conn.SaveChanges();
                            Info.Suc();
                            Trans.Go("Техника");
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
                            var wind = new ChangeTechnicWind(selectedItem.Id);
                            wind.ShowDialog();
                            Trans.Go("Техника");
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
