using System;
using System.Collections.Generic;

namespace DayCareLinqDataSource.Models
{
    public partial class HubPerson
    {
        public HubPerson()
        {
            this.SatPersonAddresses = new List<SatPersonAddress>();
        }

        public int PersonKey { get; set; }
        public string PersonID { get; set; }
        public Nullable<System.DateTime> DWInsertDate { get; set; }
        public string RecordSource { get; set; }
        public virtual ICollection<SatPersonAddress> SatPersonAddresses { get; set; }
    }
}
