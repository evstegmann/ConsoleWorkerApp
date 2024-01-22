using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return "Total Hours: " + duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture);
            }
            else
            {
                return "Total Days: " + duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture);
            }
        }
    }

}
