using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class HubTenant
    {
        public int TenantKey { get; set; }
        public string TenantID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public string RecordSource { get; set; }
    }
}
