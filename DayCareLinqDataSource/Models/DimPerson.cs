using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimPerson
    {
        public int PersonKey { get; set; }
        public System.Guid PersonID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string FullName { get; set; }
        public string FullNameL { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Ethnicity { get; set; }
        public string BloodType { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> BirthDateKey { get; set; }
        public string Employer { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string WorkExtension { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ZipFour { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lon { get; set; }
        public string Tags { get; set; }
        public Nullable<int> GeographyKey { get; set; }
        public Nullable<int> Version { get; set; }
        public Nullable<System.DateTime> DateInserted { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
    }
}
