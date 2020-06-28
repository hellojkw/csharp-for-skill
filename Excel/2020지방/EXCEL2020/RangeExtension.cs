using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Tools = Microsoft.Office.Tools.Excel;

namespace EXCEL2020
{
    public static class RangeExtension
    {
        public static int AsInteger(this Excel.Range range, Func<string, int> converter = null)
        {
            var value = range.Value2;
            if (value is double)
            {
                return (int)value;
            }
            if (value is string)
            {
                if (converter != null)
                {
                    return converter((string)value);
                }
                if (int.TryParse((string)value, out var number))
                {
                    return number;
                }
            }
            return 0;
        }

        public static long AsLong(this Excel.Range range, Func<string, long> converter = null)
        {
            var value = range.Value2;
            if (value is double)
            {
                return (long)value;
            }
            if (value is string)
            {
                if (converter != null)
                {
                    return converter((string)value);
                }
                if (long.TryParse((string)value, out var number))
                {
                    return number;
                }
            }
            return 0;
        }

        public static string AsString(this Excel.Range range)
        {
            var value = range.Value2;
            if (value is double)
            {
                return ((double)value).ToString();
            }
            if (value is string)
            {
                return value;
            }
            return string.Empty;
        }

        public static DateTime AsDateTime(this Excel.Range range)
        {
            var value = range.Value2;
            if (value is double)
            {
                var datePart = (int)value;
                var timePart = ((double)value) - datePart;

                var date = new DateTime(1900, 1, 1);
                date = date.AddDays(datePart - 2);
                return date;
            }

            return DateTime.MinValue;
        }
    }
}
