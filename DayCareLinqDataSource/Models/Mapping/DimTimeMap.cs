using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimTimeMap : EntityTypeConfiguration<DimTime>
    {
        public DimTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.TimeKey);

            // Properties
            this.Property(t => t.TimeKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Time30)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.HourlyBucket)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.DayTimeBucket)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DimTime");
            this.Property(t => t.TimeKey).HasColumnName("TimeKey");
            this.Property(t => t.TimeAltKey).HasColumnName("TimeAltKey");
            this.Property(t => t.Time30).HasColumnName("Time30");
            this.Property(t => t.Hour30).HasColumnName("Hour30");
            this.Property(t => t.MinuteNumber).HasColumnName("MinuteNumber");
            this.Property(t => t.SecondNumber).HasColumnName("SecondNumber");
            this.Property(t => t.TimeInSecond).HasColumnName("TimeInSecond");
            this.Property(t => t.HourlyBucket).HasColumnName("HourlyBucket");
            this.Property(t => t.DayTimeBucketSortKey).HasColumnName("DayTimeBucketSortKey");
            this.Property(t => t.DayTimeBucket).HasColumnName("DayTimeBucket");
        }
    }
}
