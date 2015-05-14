using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimPersonSCD1Map : EntityTypeConfiguration<DimPersonSCD1>
    {
        public DimPersonSCD1Map()
        {
            // Primary Key
            this.HasKey(t => t.PersonKey);

            // Properties
            this.Property(t => t.PersonID)
                .HasMaxLength(100);

            this.Property(t => t.FirstName)
                .HasMaxLength(100);

            this.Property(t => t.MiddleName)
                .HasMaxLength(100);

            this.Property(t => t.LastName)
                .HasMaxLength(100);

            this.Property(t => t.PreferredName)
                .HasMaxLength(100);

            this.Property(t => t.Gender)
                .HasMaxLength(10);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Ethnicity)
                .HasMaxLength(50);

            this.Property(t => t.ChangeHash)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("DimPersonSCD1");
            this.Property(t => t.PersonKey).HasColumnName("PersonKey");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.PreferredName).HasColumnName("PreferredName");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Ethnicity).HasColumnName("Ethnicity");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
            this.Property(t => t.ChangeHash).HasColumnName("ChangeHash");
        }
    }
}
