using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimOrganizationUnitMap : EntityTypeConfiguration<DimOrganizationUnit>
    {
        public DimOrganizationUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganizationUnitKey);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.ExternalID)
                .HasMaxLength(50);

            this.Property(t => t.WebSite)
                .HasMaxLength(50);

            this.Property(t => t.Tags)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("DimOrganizationUnit");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.OrganizationUnitID).HasColumnName("OrganizationUnitID");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ExternalID).HasColumnName("ExternalID");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CurrentCapacity).HasColumnName("CurrentCapacity");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.WebSite).HasColumnName("WebSite");
            this.Property(t => t.Tags).HasColumnName("Tags");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
        }
    }
}
