using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class FactLedgerBalance
    {
        public int FactKey { get; set; }
        public int LedgerKey { get; set; }
        public System.DateTime Date { get; set; }
        public int OwnerSCD2Key { get; set; }
        public int ChildKeySCD2Key { get; set; }
        public int OrgUnitKey { get; set; }
        public int TenantSCD2Key { get; set; }
        public int Count { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal StatementBalance { get; set; }
        public int DaysOverdue { get; set; }
        public decimal BalanceBin1 { get; set; }
        public decimal BalanceBin2 { get; set; }
        public decimal BalanceBin3 { get; set; }
        public decimal BalanceBin4 { get; set; }
    }
}
