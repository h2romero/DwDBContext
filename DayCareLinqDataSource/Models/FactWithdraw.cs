using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class FactWithdraw
    {
        public long WithdrawKey { get; set; }
        public Nullable<System.DateTime> WithdrawDateTime { get; set; }
        public Nullable<int> WithdrawDateKey { get; set; }
        public Nullable<int> ChildKey { get; set; }
        public Nullable<int> CreatedByPersonKey { get; set; }
        public Nullable<int> OrganizationUnitKey { get; set; }
        public Nullable<int> SchoolKey { get; set; }
        public Nullable<int> TenantKey { get; set; }
        public Nullable<int> YearInSchoolKey { get; set; }
        public Nullable<bool> IsLatest { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
