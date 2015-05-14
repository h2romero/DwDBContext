using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimDataCapture
    {
        public int DataCaptureKey { get; set; }
        public string DataCapture { get; set; }
        public System.DateTime DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
