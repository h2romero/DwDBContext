using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class HubClassGuidTempMap : EntityTypeConfiguration<HubClassGuidTemp>
    {
        public HubClassGuidTempMap()
        {
            // Primary Key
            this.HasKey(t => t.ClassKey);

            // Properties
            this.Property(t => t.ClassKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GuidClassID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RecordSource)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HubClassGuidTemp");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.GuidClassID).HasColumnName("GuidClassID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.RecordSource).HasColumnName("RecordSource");
        }
    }
}
