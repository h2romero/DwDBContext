namespace DayCareDBContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Class
    {
        public Class()
        {
            ClassCheckInOuts = new HashSet<ClassCheckInOut>();
        }

        [Key]
        public Guid Guid { get; set; }

        public int StartAgeTimeUnit { get; set; }

        public int EndAgeTimeUnit { get; set; }

        public int StartAge { get; set; }

        public int EndAge { get; set; }

        public bool IsActive { get; set; }

        public Guid OUID { get; set; }

        public Guid? DefaultRoomID { get; set; }

        public int Capacity { get; set; }

        public int RequiredRatioChildrenNumber { get; set; }

        public int RequiredRatioTeachersNumber { get; set; }

        public int TargetedRatioChildrenNumber { get; set; }

        public int TargetedRatioTeachersNumber { get; set; }

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

        public virtual ICollection<ClassCheckInOut> ClassCheckInOuts { get; set; }

        public virtual OU OU { get; set; }
    }
}
