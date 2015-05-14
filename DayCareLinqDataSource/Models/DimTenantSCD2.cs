using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimTenantSCD2
    {
        public int TenantKeySCD2 { get; set; }
        public int TenantKey { get; set; }
        public System.Guid TenantID { get; set; }
        public System.DateTime EffectiveDateFrom { get; set; }
        public System.DateTime EffectiveDateThrough { get; set; }
        public bool IsCurrent { get; set; }
        public int EnrollmentCount { get; set; }
        public int EmployeeCount { get; set; }
    }
}
