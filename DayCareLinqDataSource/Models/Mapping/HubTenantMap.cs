using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class HubTenantMap : EntityTypeConfiguration<HubTenant>
    {
        public HubTenantMap()
        {
            // Primary Key
            this.HasKey(t => t.TenantKey);

            // Properties
            this.Property(t => t.TenantID)
                .HasMaxLength(100);

            this.Property(t => t.RecordSource)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HubTenant");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.TenantID).HasColumnName("TenantID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.RecordSource).HasColumnName("RecordSource");
        }
    }
}
