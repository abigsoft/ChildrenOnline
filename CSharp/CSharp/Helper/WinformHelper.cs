using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Helper
{
    public class WinformHelper
    {
        public static int getProgressMax(int max)
        {
            if (max < 0)
            {
                return 0;
            }
            return max;
        }

        public static int getProgressNow(int max, int now)
        {
            if (now < 0)
            {
                now = 0;
            }
            if (now > max)
            {
                now = max;
            }
            return now;
        }
    }
}
