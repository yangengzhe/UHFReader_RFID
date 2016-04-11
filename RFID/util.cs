using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    public class util
    {
        public static long Time2Long(DateTime time)
        {
            TimeSpan ts = time - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
        public static string Long2Time(long time)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            time = long.Parse(time + "0000000");  
            TimeSpan toNow = new TimeSpan(time);
            return dtStart.Add(toNow).ToString();  

        }
    }
}
