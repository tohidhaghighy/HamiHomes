using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Utilities.Calender
{
    public class Calender
    {
        public TimeSpan GetTimeTafazol(DateTime dt1, DateTime dt2)
        {
            return dt1 - dt2;
        }

        public int GetdayTafazol(DateTime dt1, DateTime dt2)
        {
            return GetTimeTafazol(dt1, dt2).Days;
        }

        public String GetPersianDate(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            if (IsToday(dt))
            {
                return LimitedPersianDatetime(dt);
            }
            return PersianDays(pc.GetDayOfWeek(dt).ToString()) + " " + pc.GetDayOfMonth(dt).ToString() + " " + PersianMonth(pc.GetMonth(dt)) + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
        }

        public static String OnlyPersianDate(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(dt).ToString() + "/" + pc.GetMonth(dt).ToString() + "/" + pc.GetDayOfMonth(dt).ToString();
        }

        public String GetPersianWeek(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetDayOfWeek(dt).ToString();
        }

        public String GetCurrentDay(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetDayOfWeek(dt).ToString();
        }

        public string PersianMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "ابان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
            }
            return "";
        }

        public string PersianDays(string day)
        {
            if (day != "")
            {
                if (day.Contains("Sa"))
                    return "شنبه";
                if (day.Contains("Su"))
                    return "یکشنبه";
                if (day.Contains("Mo"))
                    return "دوشنبه";
                if (day.Contains("Tue"))
                    return "سه شنبه";
                if (day.Contains("Wed"))
                    return "چهارشنبه";
                if (day.Contains("Thu"))
                    return "پنجشنبه";
                if (day.Contains("Fr"))
                    return "جمعه";
            }
            return "";
        }

        public Boolean IsToday(DateTime dt)
        {
            DateTime nowdt = DateTime.Now;
            if (nowdt.Year == dt.Year && nowdt.Month == dt.Month && nowdt.Day == dt.Day)
            {
                return true;
            }
            return false;
        }

        public string LimitedPersianDatetime(DateTime dt)
        {
            DateTime nowdt = DateTime.Now;
            if (nowdt.Hour - dt.Hour == 0)
            {
                if (nowdt.Minute - dt.Minute == 0)
                {
                    return "دقایقی پیش";
                }
                else
                {
                    return (nowdt.Minute - dt.Minute).ToString() + " دقیقه پیش";
                }

            }
            else
            {
                return (nowdt.Hour - dt.Hour).ToString() + " ساعت پیش";
            }
        }
    }
}
