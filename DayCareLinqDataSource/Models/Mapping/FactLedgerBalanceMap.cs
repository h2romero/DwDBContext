using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class FactLedgerBalanceMap : EntityTypeConfiguration<FactLedgerBalance>
    {
        public FactLedgerBalanceMap()
        {
            // Primary Key
            this.HasKey(t => t.FactKey);

            // Properties
            this.Property(t => t.FactKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FactLedgerBalance");
            this.Property(t => t.FactKey).HasColumnName("FactKey");
            this.Property(t => t.LedgerKey).HasColumnName("LedgerKey");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.OwnerSCD2Key).HasColumnName("OwnerSCD2Key");
            this.Property(t => t.ChildKeySCD2Key).HasColumnName("ChildKeySCD2Key");
            this.Property(t => t.OrgUnitKey).HasColumnName("OrgUnitKey");
            this.Property(t => t.TenantSCD2Key).HasColumnName("TenantSCD2Key");
            this.Property(t => t.Count).HasColumnName("Count");
            this.Property(t => t.CurrentBalance).HasColumnName("CurrentBalance");
            this.Property(t => t.StatementBalance).HasColumnName("StatementBalance");
            this.Property(t => t.DaysOverdue).HasColumnName("DaysOverdue");
            this.Property(t => t.BalanceBin1).HasColumnName("BalanceBin1");
            this.Property(t => t.BalanceBin2).HasColumnName("BalanceBin2");
            this.Property(t => t.BalanceBin3).HasColumnName("BalanceBin3");
            this.Property(t => t.BalanceBin4).HasColumnName("BalanceBin4");
        }
    }
}
