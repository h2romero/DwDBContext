using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimCheckType
    {
        public int CheckTypeKey { get; set; }
        public string CheckType { get; set; }
        public System.DateTime DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
