using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class HubChildMap : EntityTypeConfiguration<HubChild>
    {
        public HubChildMap()
        {
            // Primary Key
            this.HasKey(t => t.ChildKey);

            // Properties
            this.Property(t => t.ChildID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RecordSource)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HubChild");
            this.Property(t => t.ChildKey).HasColumnName("ChildKey");
            this.Property(t => t.ChildID).HasColumnName("ChildID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.RecordSource).HasColumnName("RecordSource");
        }
    }
}
