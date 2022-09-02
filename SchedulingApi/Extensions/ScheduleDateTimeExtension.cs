using System;
using System.Globalization;

namespace SchedulingApi.Extensions
{
    public static class ScheduleDateTimeExtension
    {
        public static int ToDateIndex(this DateTime date)
        {
            return (int)(DateTime.UnixEpoch - date).TotalDays;
        }

        public static int ToDateIndex(this string dateString)
        {
            var dateTime = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            return (int)(DateTime.UnixEpoch - dateTime).TotalDays;
        }

        public static int ToTimeIndex(this string timeString)
        {
            TimeSpan ts = TimeSpan.Parse(timeString);

            return (int)ts.TotalMinutes;
        }

        public static string ToTime(this int timeInMinutes)
        {
            return $"{Math.Floor((decimal)timeInMinutes / 60)}:{timeInMinutes % 60}";
        }

        public static DateTime ToDate(this int dateIndex)
        {
            return DateTime.UnixEpoch.AddDays(dateIndex);
        }
    }
}
