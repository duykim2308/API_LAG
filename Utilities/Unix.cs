using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Unix
    {
        public static DateTime GetDateUnix()
        {
            return new DateTime(1970, 1, 1, 7, 0, 0);
        }

        public static DateTime GetDate(long value)
        {
            return GetDateUnix().AddSeconds(value);
        }

        public static long GetDate()
        {
            return (long)(DateTime.Now - GetDateUnix()).TotalSeconds;
        }

        public static long GetDate(DateTime date)
        {
            return (long)(date - GetDateUnix()).TotalSeconds;
        }
    }
}
