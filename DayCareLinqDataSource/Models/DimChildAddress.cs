using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimChildAddress
    {
        public int ChildAddressKey { get; set; }
        public int ChildKey { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string BusinessPhoneNumber { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public Nullable<float> Latitude { get; set; }
        public Nullable<float> Longitude { get; set; }
        public System.DateTime EffectiveStartDate { get; set; }
        public System.DateTime EffectiveEndDate { get; set; }
        public Nullable<bool> IsCurrent { get; set; }
        public Nullable<int> SequenceID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
