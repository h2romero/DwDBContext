namespace DayCareDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tenant
    {
        public Tenant()
        {
            OUs = new HashSet<OU>();
        }

        [Key]
        public Guid Guid { get; set; }

        public bool IsDisabled { get; set; }

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

        public virtual ICollection<OU> OUs { get; set; }
    }
}
