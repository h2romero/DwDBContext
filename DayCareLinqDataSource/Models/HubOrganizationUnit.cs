using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class HubOrganizationUnit
    {
        public int OrganizationUnitKey { get; set; }
        public string OrganizationUnitID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public string RecordSource { get; set; }
    }
}
