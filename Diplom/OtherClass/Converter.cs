using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.OtherClass
{
    public static class Convert
    {
        public static DateTime ConvertToDateTime(this TimeSpan time)
        {
            return new DateTime(2000, 01, 01, time.Hours, time.Minutes, time.Seconds);
        }
        public static TimeSpan ConvertToTimeSpan(this DateTime date)
        {
            return new TimeSpan(date.Hour, date.Minute, date.Second);
        }
    }
}
