using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimSchoolMap : EntityTypeConfiguration<DimSchool>
    {
        public DimSchoolMap()
        {
            // Primary Key
            this.HasKey(t => t.SchoolKey);

            // Properties
            this.Property(t => t.SchoolID)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.ChangeHash)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("DimSchool");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.SchoolID).HasColumnName("SchoolID");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
            this.Property(t => t.ChangeHash).HasColumnName("ChangeHash");
        }
    }
}
