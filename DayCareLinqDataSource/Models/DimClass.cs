using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimClass
    {
        public int ClassKey { get; set; }
        public string ClassId { get; set; }
        public Nullable<long> SchoolKey { get; set; }
        public Nullable<long> DefaultRoomKey { get; set; }
        public Nullable<long> TenantKey { get; set; }
        public Nullable<long> OrganizationUnitKey { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CurrentCapacity { get; set; }
        public Nullable<int> CurrentRequiredRatioChildrenNumber { get; set; }
        public Nullable<int> CurrentRequiredRatioTeachersNumber { get; set; }
        public Nullable<int> CurrentTargetedRatioChildrenNumber { get; set; }
        public Nullable<int> CurrentTargetedRatioTeachersNumber { get; set; }
        public Nullable<int> CurrentStartAgeTimeUnit { get; set; }
        public Nullable<int> CurrentEndAgeTimeUnit { get; set; }
        public Nullable<int> CurrentStartAge { get; set; }
        public Nullable<int> CurrentEndAge { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public System.DateTime DWUpdateDate { get; set; }
        public System.DateTime DWInsertDate { get; set; }
    }
}
