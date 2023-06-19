using ExpressoFunctions.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressoFunctions.FunctionLibrary
{
    public class DateDiffFunction
    {
        public delegate decimal FunctionDelegate(string datePartName, DateTime dateStart, DateTime dateFinish);

        public static decimal Eval(string datePartName, DateTime dateStart, DateTime dateFinish)
        {
            TimeSpan span = dateFinish - dateStart;
            Enum.TryParse<DateParts>(datePartName, true, out var datePart);

            switch (datePart)
            {
                case DateParts.Year:
                    return dateFinish.Year - dateStart.Year;
                case DateParts.Month:
                    return (dateFinish.Year - dateStart.Year) * 12 + dateFinish.Month - dateStart.Month;
                case DateParts.Day:
                    return (decimal)span.TotalDays;
                case DateParts.Hour:
                    return (decimal)span.TotalHours;
                case DateParts.Minute:
                    return (decimal)span.TotalMinutes;
                case DateParts.Second:
                    return (decimal)span.TotalSeconds;
                default:
                    throw new ArgumentOutOfRangeException(nameof(datePart), datePart, null);
            }
        }
    }
}
