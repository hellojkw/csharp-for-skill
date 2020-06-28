using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL2020
{
    public static class Utils
    {
        public static bool IsConflict(DateTime begin1, DateTime end1, DateTime begin2, DateTime end2)
        {
            if (end1 <= begin2)
                return false;
            if (end2 <= begin1)
                return false;
            return true;
        }
    }
}
