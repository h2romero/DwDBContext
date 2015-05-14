using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimYearInSchool
    {
        public int YearInSchoolKey { get; set; }
        public string YearInSchool { get; set; }
        public System.DateTime DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
