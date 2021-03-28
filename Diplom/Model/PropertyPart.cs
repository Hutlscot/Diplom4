using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Property
    {
        public string TypeProp
        {
            get
            {
                if (Homes != null)
                    return Homes.TypeOfHome.Name;
                if (Technic != null)
                    return Technic.TypeOfTechnic.Name;
                return "Без типа";
            }
        }
    }
}
