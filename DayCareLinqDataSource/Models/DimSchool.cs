using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimSchool
    {
        public int SchoolKey { get; set; }
        public string SchoolID { get; set; }
        public Nullable<int> TenantKey { get; set; }
        public Nullable<int> OrganizationUnitKey { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
        public byte[] ChangeHash { get; set; }
    }
}
