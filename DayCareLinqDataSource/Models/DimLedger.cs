using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimLedger
    {
        public int LedgerKey { get; set; }
        public System.Guid LedgerID { get; set; }
        public System.DateTime EffectiveDateFrom { get; set; }
        public System.DateTime EffectiveDateThrough { get; set; }
        public bool IsCurrent { get; set; }
        public string Name { get; set; }
        public string LedgerType { get; set; }
        public Nullable<int> AccountKey { get; set; }
        public System.Guid AccountID { get; set; }
        public string AccountName { get; set; }
        public System.Guid OwnerID { get; set; }
        public string OwnerName { get; set; }
        public Nullable<int> OwnerKey { get; set; }
        public string AccountStatus { get; set; }
        public string LedgerStatus { get; set; }
    }
}
