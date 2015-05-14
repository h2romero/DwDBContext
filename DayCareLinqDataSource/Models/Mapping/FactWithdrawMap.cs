using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class FactWithdrawMap : EntityTypeConfiguration<FactWithdraw>
    {
        public FactWithdrawMap()
        {
            // Primary Key
            this.HasKey(t => t.WithdrawKey);

            // Properties
            // Table & Column Mappings
            this.ToTable("FactWithdraw");
            this.Property(t => t.WithdrawKey).HasColumnName("WithdrawKey");
            this.Property(t => t.WithdrawDateTime).HasColumnName("WithdrawDateTime");
            this.Property(t => t.WithdrawDateKey).HasColumnName("WithdrawDateKey");
            this.Property(t => t.ChildKey).HasColumnName("ChildKey");
            this.Property(t => t.CreatedByPersonKey).HasColumnName("CreatedByPersonKey");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.YearInSchoolKey).HasColumnName("YearInSchoolKey");
            this.Property(t => t.IsLatest).HasColumnName("IsLatest");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
