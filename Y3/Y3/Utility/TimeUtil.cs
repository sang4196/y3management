using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y3.Utility
{
    public static class TimeUtil
    {
        public const string TIME_FORMAT_1 = "yyyy-MM-dd HH:mm:ss";
        public const string TIME_FORMAT_2 = "yyyy-MM-dd HH:mm:ss.fff";
        public const string TIME_FORMAT_3 = "yyyyMMddHHmmss";
        public const string TIME_FORMAT_4 = "yyMMddHHmmss";
        public const string TIME_FORMAT_5 = "yyyy-MM-dd";
        public const string TIME_FORMAT_6 = "yyyy-MM";
        public const string TIME_FORMAT_7 = "yyMM";
        public const string TIME_FORMAT_8 = "yyyy";
        public static long GetCurrentTimeStamp()
        {
            return ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
        }

        public static long DateTimeToTimeStamp(DateTime dt)
        {
            return ((DateTimeOffset)dt).ToUnixTimeMilliseconds();
        }

        public static DateTime TimeStampToDateTime(long ts)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddMilliseconds(ts).ToLocalTime();
            return dt;
        }
    }
}
