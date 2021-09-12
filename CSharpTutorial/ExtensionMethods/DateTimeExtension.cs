using System;
 

namespace DateTimeExtension
{
    public static class DateTimeExtension
    {

        public static string ReturnFullMonthName(this DateTime input)
        {
            return input.ToString("dd MMMM yyyy");
        }

        public static string DateWithDayName(this DateTime input)
        {
            return input.ToString("dd MMMM yyyy - dddd");
        }

        public static string DateWithTime(this DateTime input)
        {
            return input.ToString("dd MMMM yyyy - HH:mm");
        }

        public static string DayMonthYear(this DateTime input)
        {
            return input.ToString("dd MM yyyy");
        }
    }
}
