using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class FactCheckIn
    {
        public long CheckInKey { get; set; }
        public Nullable<System.DateTime> CheckInDateTime { get; set; }
        public Nullable<int> CheckInDateKey { get; set; }
        public Nullable<int> CheckInTimeKey { get; set; }
        public Nullable<int> CheckTypeKey { get; set; }
        public Nullable<int> ChildKey { get; set; }
        public Nullable<int> ClassKey { get; set; }
        public Nullable<int> CreatedByPersonKey { get; set; }
        public Nullable<int> DataCaptureKey { get; set; }
        public Nullable<int> OrganizationUnitKey { get; set; }
        public Nullable<int> SchoolKey { get; set; }
        public Nullable<int> TenantKey { get; set; }
        public Nullable<int> TransportPersonKey { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
