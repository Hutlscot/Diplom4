using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Clients
    {
        public string Info
        {
            get
            {
                return $"{LastName} {Name} {Phone}";
            }
        }
    }
}
