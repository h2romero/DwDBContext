namespace DayCareDBContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DayCareModel : DbContext
    {
        public DayCareModel()
            : base("name=DayCareModel")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ChildCheckInOut> ChildCheckInOuts { get; set; }
        public virtual DbSet<Child> Children { get; set; }
        public virtual DbSet<ClassCheckInOut> ClassCheckInOuts { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<OU> OUs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Schools)
                .WithOptional(e => e.Address)
                .HasForeignKey(e => e.AddressID);

            modelBuilder.Entity<Child>()
                .HasMany(e => e.ChildCheckInOuts)
                .WithRequired(e => e.Child)
                .HasForeignKey(e => e.ChildID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.ClassCheckInOuts)
                .WithRequired(e => e.Class)
                .HasForeignKey(e => e.ClassID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OU>()
                .HasMany(e => e.Addresses)
                .WithOptional(e => e.OU)
                .HasForeignKey(e => e.OUID);

            modelBuilder.Entity<OU>()
                .HasMany(e => e.ChildCheckInOuts)
                .WithRequired(e => e.OU)
                .HasForeignKey(e => e.OUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OU>()
                .HasMany(e => e.ClassCheckInOuts)
                .WithRequired(e => e.OU)
                .HasForeignKey(e => e.OUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OU>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.OU)
                .HasForeignKey(e => e.OUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OU>()
                .HasMany(e => e.OUs1)
                .WithOptional(e => e.OU1)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<OU>()
                .HasMany(e => e.Schools)
                .WithRequired(e => e.OU)
                .HasForeignKey(e => e.OUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Addresses)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.PersonID);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ChildCheckInOuts)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PickUpDropOffPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Child)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.ClassCheckInOuts)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<School>()
                .HasMany(e => e.Children)
                .WithOptional(e => e.School)
                .HasForeignKey(e => e.SchoolID);

            modelBuilder.Entity<Tenant>()
                .HasMany(e => e.OUs)
                .WithRequired(e => e.Tenant)
                .HasForeignKey(e => e.TenantID)
                .WillCascadeOnDelete(false);
        }
    }
}
