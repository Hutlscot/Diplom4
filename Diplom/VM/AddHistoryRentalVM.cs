using Diplom.OtherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    class AddHistoryRentalVM
    {
        public HistoryRental addedItem { get; set; }
        public List<Clients> clients { get; set; }
        public Clients selectedClient { get; set; }
        public List<Property> properties { get; set; }
        public Property selectedProperty { get; set; }
        public DateTime timeStart { get; set; } 
        public DateTime timeEnd { get; set; }

        public AddHistoryRentalVM()
        {
            var conn = new ConnectionDB();
            clients = conn.Clients.ToList();
            properties = conn.Property.ToList();
            addedItem = new HistoryRental();
            addedItem.DateStart = DateTime.Now;
            timeStart = DateTime.Now;
            addedItem.DateEnd = DateTime.Now;
            timeEnd = DateTime.Now;
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
                       
                        addedItem.IdClient = selectedClient.Id;
                        addedItem.IdProperty = selectedProperty.Id;
                        addedItem.TimeStart = GetDateStart();
                        addedItem.TimeEnd = GetDateEnd();
                        conn.HistoryRental.Add(addedItem);
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
        public TimeSpan GetDateStart()
        {
            return new TimeSpan(timeStart.Hour, timeStart.Minute, timeStart.Second);
        }
        public TimeSpan GetDateEnd()
        {
            return new TimeSpan(timeEnd.Hour, timeEnd.Minute, timeEnd.Second);
        }
    }
}
