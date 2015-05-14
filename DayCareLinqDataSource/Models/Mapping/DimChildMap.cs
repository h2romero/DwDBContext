using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimChildMap : EntityTypeConfiguration<DimChild>
    {
        public DimChildMap()
        {
            // Primary Key
            this.HasKey(t => t.ChildKey);

            // Properties
            this.Property(t => t.ChildKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChildID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FirstName)
                .HasMaxLength(100);

            this.Property(t => t.MiddleName)
                .HasMaxLength(100);

            this.Property(t => t.LastName)
                .HasMaxLength(100);

            this.Property(t => t.PreferredName)
                .HasMaxLength(100);

            this.Property(t => t.ChangeHash)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DimChild");
            this.Property(t => t.ChildKey).HasColumnName("ChildKey");
            this.Property(t => t.ChildID).HasColumnName("ChildID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.PreferredName).HasColumnName("PreferredName");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.ChangeHash).HasColumnName("ChangeHash");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
