using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressoFunctions.FunctionLibrary
{
    public static class DateTimeExtensions
    {
        public static DateTime BeginDay(this DateTime date)
        {
            DateTime resDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);

            return resDate;
        }

        public static DateTime EndDay(this DateTime date)
        {
            DateTime resDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);

            return resDate;
        }

        public static DateTime BeginMonth(this DateTime date)
        {
            DateTime resDate = new DateTime(date.Year, date.Month, 1, 0, 0, 0);

            return resDate;
        }

        public static DateTime EndMonth(this DateTime date)
        {
            DateTime tempDate = date.AddMonths(1);
            tempDate = tempDate.BeginMonth();
            tempDate = tempDate.AddDays(-1);
            DateTime resDate = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, 23, 59, 59);

            return resDate;
        }

        public static DateTime BeginQuarter(this DateTime date)
        {
            int monthBegin;

            switch (date.Month)
            {
                case 1:
                case 2:
                case 3:
                    monthBegin = 1;
                    break;
                case 4:
                case 5:
                case 6:
                    monthBegin = 4;
                    break;
                case 7:
                case 8:
                case 9:
                    monthBegin = 7;
                    break;
                case 10:
                case 11:
                case 12:
                    monthBegin = 10;
                    break;
                default:
                    monthBegin = 1;
                    break;
            }

            DateTime resDate = new DateTime(date.Year, monthBegin, 1, 0, 0, 0);

            return resDate;
        }

        public static DateTime EndQuarter(this DateTime date)
        {
            int monthEnd;

            switch (date.Month)
            {
                case 1:
                case 2:
                case 3:
                    monthEnd = 3;
                    break;
                case 4:
                case 5:
                case 6:
                    monthEnd = 6;
                    break;
                case 7:
                case 8:
                case 9:
                    monthEnd = 9;
                    break;
                case 10:
                case 11:
                case 12:
                    monthEnd = 12;
                    break;
                default:
                    monthEnd = 3;
                    break;
            }

            DateTime tempDate = new DateTime(date.Year, monthEnd, 1, 0, 0, 0);
            DateTime resDate = tempDate.EndMonth();

            return resDate;

        }

        public static DateTime BeginYear(this DateTime date)
        {
            DateTime resDate = new DateTime(date.Year, 1, 1, 0, 0, 0);

            return resDate;
        }

        public static DateTime EndYear(this DateTime date)
        {
            DateTime resDate = new DateTime(date.Year, 12, 31, 23, 59, 59);

            return resDate;
        }

        public static DateTime SetYear(this DateTime date, int year)
        {
            var resDate = new DateTime(year, date.Month, date.Day, date.Hour, date.Minute, date.Second);

            return resDate;
        }
        public static DateTime SetMonth(this DateTime date, int month)
        {
            var resDate = new DateTime(date.Year, month, date.Day, date.Hour, date.Minute, date.Second);

            return resDate;
        }

        public static DateTime SetQuarter(this DateTime date, int quarter)
        {
            int monthBegin;

            switch (quarter)
            {
                case 1:
                    monthBegin = 1;
                    break;
                case 2:
                    monthBegin = 4;
                    break;
                case 3:
                    monthBegin = 7;
                    break;
                case 4:
                    monthBegin = 10;
                    break;
                default:
                    monthBegin = 1;
                    break;
            }

            return date.SetMonth(monthBegin);

        }

        public static DateTime SetDay(this DateTime date, int day)
        {
            var resDate = new DateTime(date.Year, date.Month, day, date.Hour, date.Minute, date.Second);

            return resDate;
        }

        public static DateTime SetHour(this DateTime date, int hour)
        {
            var resDate = new DateTime(date.Year, date.Month, date.Day, hour, date.Minute, date.Second);

            return resDate;
        }

        public static DateTime SetMinute(this DateTime date, int minute)
        {
            var resDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, minute, date.Second);

            return resDate;
        }
    
        public static DateTime SetSecond(this DateTime date, int second)
        {
            var resDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, second);

            return resDate;
        }

        public static DateTime AddQuarters(this DateTime date, int quarter)
        {
            return date.AddMonths(quarter * 3);
        }

        public static DateTime AddYears(this DateTime date, decimal years)
        {
            var shift = (int)years;
            return date.AddYears(shift);
        }

        public static DateTime AddMonths(this DateTime date, decimal months)
        {
            var shift = (int)months;
            return date.AddMonths(shift);
        }

        public static DateTime AddDays(this DateTime date, decimal days)
        {
            var daysDouble = (double)days;
            return date.AddDays(daysDouble);
        }

        public static DateTime AddHours(this DateTime date, decimal hours)
        {
            var shift = (double)hours;
            return date.AddHours(shift);
        }

        public static DateTime AddMinutes(this DateTime date, decimal minutes)
        {
            var shift = (double)minutes;
            return date.AddMinutes(shift);
        }

        public static DateTime AddSeconds(this DateTime date, decimal seconds)
        {
            var shift = (double)seconds;
            return date.AddSeconds(shift);
        }
    
    }
}
