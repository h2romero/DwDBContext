using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimTenantSCD1Map : EntityTypeConfiguration<DimTenantSCD1>
    {
        public DimTenantSCD1Map()
        {
            // Primary Key
            this.HasKey(t => t.TenantKey);

            // Properties
            this.Property(t => t.TenantID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Tags)
                .HasMaxLength(1000);

            this.Property(t => t.ChangeHash)
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("DimTenantSCD1");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.TenantID).HasColumnName("TenantID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Flags).HasColumnName("Flags");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.Tags).HasColumnName("Tags");
            this.Property(t => t.DWDateUpdated).HasColumnName("DWDateUpdated");
            this.Property(t => t.DWDateInserted).HasColumnName("DWDateInserted");
            this.Property(t => t.ChangeHash).HasColumnName("ChangeHash");
        }
    }
}
