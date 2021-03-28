using Diplom.OtherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class AddTechnicVM
    {
        public Technic addedItem { get; set; }
        public Property addedProterty { get; set; }
        public List<TypeOfTechnic> typeList{ get; set; }
        public TypeOfTechnic selectedType { get; set; }

        public AddTechnicVM()
        {
            var conn = new ConnectionDB();
            typeList = conn.TypeOfTechnic.ToList();
            addedItem = new Technic();
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
                        conn.Technic.Add(addedItem);

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
    }
}
