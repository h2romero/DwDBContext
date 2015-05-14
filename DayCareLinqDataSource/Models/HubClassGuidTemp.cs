using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class HubClassGuidTemp
    {
        public int ClassKey { get; set; }
        public long ClassID { get; set; }
        public string GuidClassID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public string RecordSource { get; set; }
    }
}
