using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class SatChildAddress
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
        public System.DateTime EffectiveDate { get; set; }
        public string SatRecordSource { get; set; }
        public byte[] ChangeHash { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
    }
}
