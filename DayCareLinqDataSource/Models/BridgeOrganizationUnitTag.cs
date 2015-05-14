using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class BridgeOrganizationUnitTag
    {
        public int OrganizationUnitKey { get; set; }
        public int TagKey { get; set; }
        public Nullable<int> WeightingFactor { get; set; }
        public System.DateTime DWUpdateDate { get; set; }
        public System.DateTime DWInsertDate { get; set; }
    }
}
