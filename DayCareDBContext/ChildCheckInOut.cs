namespace DayCareDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChildCheckInOut
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid ChildID { get; set; }

        public Guid PickUpDropOffPersonID { get; set; }

        public Guid OUID { get; set; }

        public DateTime RegisteredTime { get; set; }

        public bool IsCheckOut { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public int CaptureMethod { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public long? Flags { get; set; }

        public Guid TenantID { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateLastModified { get; set; }

        public Guid? CreatedByID { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public int Version { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)]
        public string ExternalID { get; set; }

        [StringLength(1000)]
        public string TagString { get; set; }

        public bool IsArchived { get; set; }

        public virtual Child Child { get; set; }

        public virtual OU OU { get; set; }

        public virtual Person Person { get; set; }
    }
}
