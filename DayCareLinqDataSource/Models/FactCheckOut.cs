using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class FactCheckOut
    {
        public long CheckOutKey { get; set; }
        public Nullable<System.DateTime> CheckOutDateTime { get; set; }
        public Nullable<int> CheckOutDateKey { get; set; }
        public Nullable<int> CheckOutTimeKey { get; set; }
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
