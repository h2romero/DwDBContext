namespace DayCareDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Child
    {
        public Child()
        {
            ChildCheckInOuts = new HashSet<ChildCheckInOut>();
        }

        [Key]
        public Guid Guid { get; set; }

        public bool AttendsSchool { get; set; }

        public int SchoolTransportation { get; set; }

        public TimeSpan SchoolDropOffTime { get; set; }

        public TimeSpan SchoolPickupTime { get; set; }

        public int EnrollmentStatus { get; set; }

        [StringLength(50)]
        public string YearInSchool { get; set; }

        public Guid? SchoolID { get; set; }

        public DateTime? DateEnrolled { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? DateWithdrawn { get; set; }

        public Guid? WithdrawalCodeID { get; set; }

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

        public virtual ICollection<ChildCheckInOut> ChildCheckInOuts { get; set; }

        public virtual Person Person { get; set; }

        public virtual School School { get; set; }
    }
}
