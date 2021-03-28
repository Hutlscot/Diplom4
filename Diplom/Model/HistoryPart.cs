using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class HistoryRental
    {
        public string DateStartString
        {
            get
            {
                return $"{DateStart.ToShortDateString()} {TimeStart}";
            }
        }
        public string DateEndString
        {
            get
            {
                return $"{DateEnd.ToShortDateString()} {TimeEnd}";
            }
        }
    }
}
