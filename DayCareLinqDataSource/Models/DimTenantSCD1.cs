using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimTenantSCD1
    {
        public int TenantKey { get; set; }
        public string TenantID { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<long> Flags { get; set; }
        public bool IsDeleted { get; set; }
        public string Tags { get; set; }
        public Nullable<System.DateTime> DWDateUpdated { get; set; }
        public Nullable<System.DateTime> DWDateInserted { get; set; }
        public byte[] ChangeHash { get; set; }
    }
}
