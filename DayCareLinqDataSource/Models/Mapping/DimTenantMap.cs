using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimTenantMap : EntityTypeConfiguration<DimTenant>
    {
        public DimTenantMap()
        {
            // Primary Key
            this.HasKey(t => t.TenantKey);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Address1)
                .HasMaxLength(50);

            this.Property(t => t.Address2)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.ZipCode)
                .HasMaxLength(50);

            this.Property(t => t.ZipFour)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimTenants");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.TenantID).HasColumnName("TenantID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.ZipFour).HasColumnName("ZipFour");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
        }
    }
}
