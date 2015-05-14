namespace DwAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FactCheckInOut")]
    public partial class FactCheckInOut
    {
        [Key]
        public long CheckInOutKey { get; set; }

        public long? CheckInKey { get; set; }

        public long? CheckOutKey { get; set; }

        public DateTime? CheckInDateTime { get; set; }

        public int? CheckInDateKey { get; set; }

        public int? CheckInTimeKey { get; set; }

        public DateTime? CheckOutDateTime { get; set; }

        public int? CheckOutDateKey { get; set; }

        public int? CheckOutTimeKey { get; set; }

        public int? CheckInOutLag { get; set; }

        public int? CheckTypeKey { get; set; }

        public int? ChildKey { get; set; }

        public int? ClassKey { get; set; }

        public int? CheckInCreatedByPersonKey { get; set; }

        public int? CheckOutCreatedByPersonKey { get; set; }

        public int? CheckInDataCaptureKey { get; set; }

        public int? CheckOutDataCaptureKey { get; set; }

        public int? OrganizationUnitKey { get; set; }

        public int? SchoolKey { get; set; }

        public int? TenantKey { get; set; }

        public int? CheckInTransportPersonKey { get; set; }

        public int? CheckOutTransportPersonKey { get; set; }

        public DateTime? DWInsertDate { get; set; }

        public DateTime? DWUpdateDate { get; set; }
    }
}
