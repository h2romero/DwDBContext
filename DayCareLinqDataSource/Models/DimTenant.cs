using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimTenant
    {
        public int TenantKey { get; set; }
        public Nullable<System.Guid> TenantID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ZipFour { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    }
}
