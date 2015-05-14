using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimTime
    {
        public int TimeKey { get; set; }
        public int TimeAltKey { get; set; }
        public string Time30 { get; set; }
        public byte Hour30 { get; set; }
        public byte MinuteNumber { get; set; }
        public byte SecondNumber { get; set; }
        public int TimeInSecond { get; set; }
        public string HourlyBucket { get; set; }
        public int DayTimeBucketSortKey { get; set; }
        public string DayTimeBucket { get; set; }
    }
}
