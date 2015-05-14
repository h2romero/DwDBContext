using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimDataCaptureMap : EntityTypeConfiguration<DimDataCapture>
    {
        public DimDataCaptureMap()
        {
            // Primary Key
            this.HasKey(t => t.DataCaptureKey);

            // Properties
            this.Property(t => t.DataCapture)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimDataCapture");
            this.Property(t => t.DataCaptureKey).HasColumnName("DataCaptureKey");
            this.Property(t => t.DataCapture).HasColumnName("DataCapture");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
