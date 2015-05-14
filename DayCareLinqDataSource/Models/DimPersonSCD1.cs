using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimPersonSCD1
    {
        public int PersonKey { get; set; }
        public string PersonID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Ethnicity { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
        public byte[] ChangeHash { get; set; }
    }
}
