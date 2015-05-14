using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class HubChild
    {
        public int ChildKey { get; set; }
        public string ChildID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public string RecordSource { get; set; }
    }
}
