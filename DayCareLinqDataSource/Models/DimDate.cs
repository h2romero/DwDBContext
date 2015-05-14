using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimDate
    {
        public int DateKey { get; set; }
        public System.DateTime CalendarDate { get; set; }
        public int CalendarYear { get; set; }
        public string CalendarHalf { get; set; }
        public int CalendarHalfNumber { get; set; }
        public string CalendarYearHalfName { get; set; }
        public string CalendarQuarter { get; set; }
        public int CalendarQuarterNumber { get; set; }
        public string CalendarYearQuarterName { get; set; }
        public int CalendarMonth { get; set; }
        public int CalendarMonthNumber { get; set; }
        public string CalendarMonthName { get; set; }
        public string CalendarYearMonthName { get; set; }
        public int CalendarMonthStart { get; set; }
        public int CalendarMonthEnd { get; set; }
        public System.DateTime MondayWeekBeginDate { get; set; }
        public System.DateTime WeekBeginDate { get; set; }
        public int CalendarWeek { get; set; }
        public int WeekDay { get; set; }
        public string WeekDayName { get; set; }
        public string WeekDayType { get; set; }
        public int DaysInCalendarYear { get; set; }
        public int DaysInCalendarMonth { get; set; }
        public int DaysInCalendarWeek { get; set; }
        public int WeeksInCalendarMonth { get; set; }
        public int MondayWeeksInCalendarMonth { get; set; }
        public int WeeksInCalendarYear { get; set; }
        public int MondayWeeksInCalendarYear { get; set; }
        public int MondayWeekOfMonth { get; set; }
        public int WeekOfMonth { get; set; }
    }
}
