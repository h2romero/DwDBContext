namespace DayCareDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Person
    {
        public Person()
        {
            Addresses = new HashSet<Address>();
            ChildCheckInOuts = new HashSet<ChildCheckInOut>();
            ClassCheckInOuts = new HashSet<ClassCheckInOut>();
        }

        [Key]
        public Guid Guid { get; set; }

        [StringLength(150)]
        public string Languages { get; set; }

        [StringLength(50)]
        public string Height { get; set; }

        [StringLength(50)]
        public string Weight { get; set; }

        [StringLength(50)]
        public string HairColor { get; set; }

        [StringLength(50)]
        public string EyeColor { get; set; }

        public int Ethnicity { get; set; }

        [StringLength(150)]
        public string DistinguishingMarks { get; set; }

        [StringLength(100)]
        public string Employer { get; set; }

        [StringLength(100)]
        public string WorkHours { get; set; }

        public int BloodType { get; set; }

        public DateTime? DateOfLastPhysical { get; set; }

        public string SocialSecurityEntrypted { get; set; }

        public string InterestsString { get; set; }

        [StringLength(15)]
        public string Prefix { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string PreferredName { get; set; }

        [StringLength(10)]
        public string Suffix { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(9)]
        public string SocialSecurity { get; set; }

        public int Gender { get; set; }

        public string EmailAddressString { get; set; }

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

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<ChildCheckInOut> ChildCheckInOuts { get; set; }

        public virtual Child Child { get; set; }

        public virtual ICollection<ClassCheckInOut> ClassCheckInOuts { get; set; }
    }
}
