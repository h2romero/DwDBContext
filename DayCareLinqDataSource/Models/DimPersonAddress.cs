using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimPersonAddress
    {
        public int PersonAddressKey { get; set; }
        public Nullable<int> PersonKey { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Nullable<double> HomePhoneNumber { get; set; }
        public Nullable<double> MobilePhoneNumber { get; set; }
        public Nullable<double> PrimaryPhoneNumber { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<System.DateTime> EffectiveStartDate { get; set; }
        public Nullable<System.DateTime> EffectiveEndDate { get; set; }
        public Nullable<bool> IsCurrent { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
