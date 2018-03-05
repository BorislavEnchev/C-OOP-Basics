using System;
using System.Globalization;

public class DateModifier
{
    public static double GetDaysBetweenDates(string dateOne, string dateTwo)
    {
        var firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
        var secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

        if (firstDate > secondDate)
        {
            return (firstDate - secondDate).Days;
        }
        return (secondDate - firstDate).Days;
    }
}

