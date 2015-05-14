using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class DimChild
    {
        public int ChildKey { get; set; }
        public string ChildID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public System.DateTime DateCreated { get; set; }
        public byte[] ChangeHash { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public Nullable<System.DateTime> DWUpdateDate { get; set; }
    }
}
