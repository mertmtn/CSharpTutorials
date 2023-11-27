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

        public static int GetQuarterWithSwitch(this DateTime dateTime)
        {
            return dateTime.Month switch
            {
                12 or 11 or 10 => 4,
                9 or 8 or 7 => 3,
                6 or 5 or 4 => 2,
                3 or 2 or 1 => 1,
                _ => 0,
            };
        }

        public static int GetQuarterWithMathCalculations(this DateTime dateTime) => (dateTime.Month - 1) / 3 + 1;

    }
}
