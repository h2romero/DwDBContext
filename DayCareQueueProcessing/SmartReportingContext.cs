namespace DayCareQueueProcessing
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SmartReportingContext : DbContext
    {
        public SmartReportingContext()
            : base("name=SmartReportingContext")
        {
        }

        public virtual DbSet<DimPersonSCD1> DimPersonSCD1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.PreferredName)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.Ethnicity)
                .IsUnicode(false);

            modelBuilder.Entity<DimPersonSCD1>()
                .Property(e => e.ChangeHash)
                .IsFixedLength();
        }
    }
}
