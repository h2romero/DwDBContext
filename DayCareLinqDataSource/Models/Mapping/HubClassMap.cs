using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class HubClassMap : EntityTypeConfiguration<HubClass>
    {
        public HubClassMap()
        {
            // Primary Key
            this.HasKey(t => t.ClassKey);

            // Properties
            this.Property(t => t.ClassID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RecordSource)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HubClass");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.ClassID).HasColumnName("ClassID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.RecordSource).HasColumnName("RecordSource");
        }
    }
}
