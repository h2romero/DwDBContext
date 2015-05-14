using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class BridgeOrganizationUnitTagMap : EntityTypeConfiguration<BridgeOrganizationUnitTag>
    {
        public BridgeOrganizationUnitTagMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganizationUnitKey);

            // Properties
            this.Property(t => t.OrganizationUnitKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BridgeOrganizationUnitTag");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.TagKey).HasColumnName("TagKey");
            this.Property(t => t.WeightingFactor).HasColumnName("WeightingFactor");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
        }
    }
}
