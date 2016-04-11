﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID
{
    class RfidCard
    {
        public static const long refresh_time = 1000;//ms
        public String epc;
        public int times;
        public long timestamp;

        public RfidCard(String t_epc)
        {
            epc = t_epc;
            times = 1;
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            timestamp = Convert.ToInt64(ts.TotalSeconds);
        }
        public bool add_refresh()
        {
            add();
            return isRefresh();
        }
        public int add()
        {
            return times = times++ < int.MaxValue ? times : 0;
        }

        public bool isRefresh()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            long new_timestamp = Convert.ToInt64(ts.TotalSeconds);
            if (new_timestamp - timestamp < refresh_time)
                return false;
            else
            {
                timestamp = new_timestamp;
                return true;
            }
        }
    }
}
