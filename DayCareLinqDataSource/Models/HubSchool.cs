using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class HubSchool
    {
        public int SchoolKey { get; set; }
        public string SchoolID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public string RecordSource { get; set; }
    }
}
