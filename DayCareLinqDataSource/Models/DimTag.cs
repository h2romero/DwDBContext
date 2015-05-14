using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimTag
    {
        public int TagKey { get; set; }
        public string TagString { get; set; }
        public System.DateTime DWUpdateDate { get; set; }
        public System.DateTime DWInsertDate { get; set; }
    }
}
