using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimOrganizationUnit
    {
        public int OrganizationUnitKey { get; set; }
        public System.Guid OrganizationUnitID { get; set; }
        public Nullable<int> TenantKey { get; set; }
        public string Name { get; set; }
        public string ExternalID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CurrentCapacity { get; set; }
        public bool IsDeleted { get; set; }
        public string WebSite { get; set; }
        public string Tags { get; set; }
        public System.DateTime DWUpdateDate { get; set; }
        public System.DateTime DWInsertDate { get; set; }
    }
}
