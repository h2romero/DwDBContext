using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class FactCheckInOut
    {
        public long CheckInOutKey { get; set; }
        public Nullable<long> CheckInKey { get; set; }
        public Nullable<long> CheckOutKey { get; set; }
        public Nullable<System.DateTime> CheckInDateTime { get; set; }
        public Nullable<int> CheckInDateKey { get; set; }
        public Nullable<int> CheckInTimeKey { get; set; }
        public Nullable<System.DateTime> CheckOutDateTime { get; set; }
        public Nullable<int> CheckOutDateKey { get; set; }
        public Nullable<int> CheckOutTimeKey { get; set; }
        public Nullable<int> CheckInOutLag { get; set; }
        public Nullable<int> CheckTypeKey { get; set; }
        public Nullable<int> ChildKey { get; set; }
        public Nullable<int> ClassKey { get; set; }
        public Nullable<int> CheckInCreatedByPersonKey { get; set; }
        public Nullable<int> CheckOutCreatedByPersonKey { get; set; }
        public Nullable<int> CheckInDataCaptureKey { get; set; }
        public Nullable<int> CheckOutDataCaptureKey { get; set; }
        public Nullable<int> OrganizationUnitKey { get; set; }
        public Nullable<int> SchoolKey { get; set; }
        public Nullable<int> TenantKey { get; set; }
        public Nullable<int> CheckInTransportPersonKey { get; set; }
        public Nullable<int> CheckOutTransportPersonKey { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
