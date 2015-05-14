using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimTagMap : EntityTypeConfiguration<DimTag>
    {
        public DimTagMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TagKey, t.DWUpdateDate, t.DWInsertDate });

            // Properties
            this.Property(t => t.TagKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TagString)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("DimTag");
            this.Property(t => t.TagKey).HasColumnName("TagKey");
            this.Property(t => t.TagString).HasColumnName("TagString");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
        }
    }
}
