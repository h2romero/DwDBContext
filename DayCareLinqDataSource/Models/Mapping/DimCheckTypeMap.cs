using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimCheckTypeMap : EntityTypeConfiguration<DimCheckType>
    {
        public DimCheckTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CheckTypeKey);

            // Properties
            this.Property(t => t.CheckType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimCheckType");
            this.Property(t => t.CheckTypeKey).HasColumnName("CheckTypeKey");
            this.Property(t => t.CheckType).HasColumnName("CheckType");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
