namespace DayCareDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Address
    {
        public Address()
        {
            Schools = new HashSet<School>();
        }

        [Key]
        public Guid Guid { get; set; }

        public Guid? OUID { get; set; }

        public Guid? PersonID { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(20)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(5)]
        public string ZipCode { get; set; }

        public string PlusFour { get; set; }

        [StringLength(50)]
        public string County { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

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

        public virtual OU OU { get; set; }

        public virtual Person Person { get; set; }

        public virtual ICollection<School> Schools { get; set; }
    }
}
