using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimPersonSCD2
    {
        public int PersonKey { get; set; }
        public System.Guid PersonID { get; set; }
        public System.DateTime EffectiveDateFrom { get; set; }
        public System.DateTime EffectiveDateThrough { get; set; }
        public bool IsCurrent { get; set; }
        public string LastName { get; set; }
        public string Employer { get; set; }
        public Nullable<int> GeographyKey { get; set; }
    }
}
