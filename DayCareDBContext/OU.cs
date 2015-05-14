namespace DayCareDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OU
    {
        public OU()
        {
            Addresses = new HashSet<Address>();
            ChildCheckInOuts = new HashSet<ChildCheckInOut>();
            ClassCheckInOuts = new HashSet<ClassCheckInOut>();
            Classes = new HashSet<Class>();
            OUs1 = new HashSet<OU>();
            Schools = new HashSet<School>();
        }

        [Key]
        public Guid Guid { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public Guid? ParentID { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50)]
        public string FederalTaxID { get; set; }

        [StringLength(50)]
        public string StateTaxID { get; set; }

        public Guid TenantID { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public long? Flags { get; set; }

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

        public int? EnrollmentStatus { get; set; }

        public int? Capacity { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        public bool IsArchived { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<ChildCheckInOut> ChildCheckInOuts { get; set; }

        public virtual ICollection<ClassCheckInOut> ClassCheckInOuts { get; set; }

        public virtual ICollection<Class> Classes { get; set; }

        public virtual ICollection<OU> OUs1 { get; set; }

        public virtual OU OU1 { get; set; }

        public virtual Tenant Tenant { get; set; }

        public virtual ICollection<School> Schools { get; set; }
    }
}
