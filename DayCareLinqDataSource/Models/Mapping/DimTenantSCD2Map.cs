using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimTenantSCD2Map : EntityTypeConfiguration<DimTenantSCD2>
    {
        public DimTenantSCD2Map()
        {
            // Primary Key
            this.HasKey(t => t.TenantKeySCD2);

            // Properties
            this.Property(t => t.TenantKeySCD2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DimTenantSCD2");
            this.Property(t => t.TenantKeySCD2).HasColumnName("TenantKeySCD2");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.TenantID).HasColumnName("TenantID");
            this.Property(t => t.EffectiveDateFrom).HasColumnName("EffectiveDateFrom");
            this.Property(t => t.EffectiveDateThrough).HasColumnName("EffectiveDateThrough");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.EnrollmentCount).HasColumnName("EnrollmentCount");
            this.Property(t => t.EmployeeCount).HasColumnName("EmployeeCount");
        }
    }
}
