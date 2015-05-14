using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class HubClass
    {
        public int ClassKey { get; set; }
        public string ClassID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public string RecordSource { get; set; }
    }
}
