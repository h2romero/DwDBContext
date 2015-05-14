using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimLedgerMap : EntityTypeConfiguration<DimLedger>
    {
        public DimLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.LedgerKey);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LedgerType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OwnerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountStatus)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LedgerStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimLedger");
            this.Property(t => t.LedgerKey).HasColumnName("LedgerKey");
            this.Property(t => t.LedgerID).HasColumnName("LedgerID");
            this.Property(t => t.EffectiveDateFrom).HasColumnName("EffectiveDateFrom");
            this.Property(t => t.EffectiveDateThrough).HasColumnName("EffectiveDateThrough");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LedgerType).HasColumnName("LedgerType");
            this.Property(t => t.AccountKey).HasColumnName("AccountKey");
            this.Property(t => t.AccountID).HasColumnName("AccountID");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.OwnerID).HasColumnName("OwnerID");
            this.Property(t => t.OwnerName).HasColumnName("OwnerName");
            this.Property(t => t.OwnerKey).HasColumnName("OwnerKey");
            this.Property(t => t.AccountStatus).HasColumnName("AccountStatus");
            this.Property(t => t.LedgerStatus).HasColumnName("LedgerStatus");
        }
    }
}
