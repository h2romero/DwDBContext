namespace DayCareQueueProcessing
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DimPersonSCD1
    {
        [Key]
        public int PersonKey { get; set; }

        [StringLength(100)]
        public string PersonID { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string MiddleName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string PreferredName { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Ethnicity { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DWInsertDate { get; set; }

        public DateTime? DWUpdateDate { get; set; }

        [MaxLength(16)]
        public byte[] ChangeHash { get; set; }
    }
}
