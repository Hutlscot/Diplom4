using Diplom.OtherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.VM
{
    class AddHomeVM
    {
        public Homes addedItem { get; set; }
        public Property addedProterty { get; set; }
        public List<TypeOfHome> typeList { get; set; }
        public TypeOfHome selectedType { get; set; }

        public AddHomeVM()
        {
            var conn = new ConnectionDB();
            typeList = conn.TypeOfHome.ToList();
            addedItem = new Homes();
            addedProterty = new Property();
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
                        conn.Property.Add(addedProterty);

                        conn.SaveChanges();

                        addedItem.Id = addedProterty.Id;
                        addedItem.IdType = selectedType.Id;
                        conn.Homes.Add(addedItem);

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
