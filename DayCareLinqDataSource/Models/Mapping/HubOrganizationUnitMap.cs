using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class HubOrganizationUnitMap : EntityTypeConfiguration<HubOrganizationUnit>
    {
        public HubOrganizationUnitMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganizationUnitKey);

            // Properties
            this.Property(t => t.OrganizationUnitID)
                .HasMaxLength(100);

            this.Property(t => t.RecordSource)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HubOrganizationUnit");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.OrganizationUnitID).HasColumnName("OrganizationUnitID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.RecordSource).HasColumnName("RecordSource");
        }
    }
}
