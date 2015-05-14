using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimDateMap : EntityTypeConfiguration<DimDate>
    {
        public DimDateMap()
        {
            // Primary Key
            this.HasKey(t => t.DateKey);

            // Properties
            this.Property(t => t.DateKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CalendarHalf)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.CalendarYearHalfName)
                .IsRequired()
                .HasMaxLength(39);

            this.Property(t => t.CalendarQuarter)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.CalendarYearQuarterName)
                .IsRequired()
                .HasMaxLength(65);

            this.Property(t => t.CalendarMonthName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CalendarYearMonthName)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.WeekDayName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.WeekDayType)
                .IsRequired()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("DimDate");
            this.Property(t => t.DateKey).HasColumnName("DateKey");
            this.Property(t => t.CalendarDate).HasColumnName("CalendarDate");
            this.Property(t => t.CalendarYear).HasColumnName("CalendarYear");
            this.Property(t => t.CalendarHalf).HasColumnName("CalendarHalf");
            this.Property(t => t.CalendarHalfNumber).HasColumnName("CalendarHalfNumber");
            this.Property(t => t.CalendarYearHalfName).HasColumnName("CalendarYearHalfName");
            this.Property(t => t.CalendarQuarter).HasColumnName("CalendarQuarter");
            this.Property(t => t.CalendarQuarterNumber).HasColumnName("CalendarQuarterNumber");
            this.Property(t => t.CalendarYearQuarterName).HasColumnName("CalendarYearQuarterName");
            this.Property(t => t.CalendarMonth).HasColumnName("CalendarMonth");
            this.Property(t => t.CalendarMonthNumber).HasColumnName("CalendarMonthNumber");
            this.Property(t => t.CalendarMonthName).HasColumnName("CalendarMonthName");
            this.Property(t => t.CalendarYearMonthName).HasColumnName("CalendarYearMonthName");
            this.Property(t => t.CalendarMonthStart).HasColumnName("CalendarMonthStart");
            this.Property(t => t.CalendarMonthEnd).HasColumnName("CalendarMonthEnd");
            this.Property(t => t.MondayWeekBeginDate).HasColumnName("MondayWeekBeginDate");
            this.Property(t => t.WeekBeginDate).HasColumnName("WeekBeginDate");
            this.Property(t => t.CalendarWeek).HasColumnName("CalendarWeek");
            this.Property(t => t.WeekDay).HasColumnName("WeekDay");
            this.Property(t => t.WeekDayName).HasColumnName("WeekDayName");
            this.Property(t => t.WeekDayType).HasColumnName("WeekDayType");
            this.Property(t => t.DaysInCalendarYear).HasColumnName("DaysInCalendarYear");
            this.Property(t => t.DaysInCalendarMonth).HasColumnName("DaysInCalendarMonth");
            this.Property(t => t.DaysInCalendarWeek).HasColumnName("DaysInCalendarWeek");
            this.Property(t => t.WeeksInCalendarMonth).HasColumnName("WeeksInCalendarMonth");
            this.Property(t => t.MondayWeeksInCalendarMonth).HasColumnName("MondayWeeksInCalendarMonth");
            this.Property(t => t.WeeksInCalendarYear).HasColumnName("WeeksInCalendarYear");
            this.Property(t => t.MondayWeeksInCalendarYear).HasColumnName("MondayWeeksInCalendarYear");
            this.Property(t => t.MondayWeekOfMonth).HasColumnName("MondayWeekOfMonth");
            this.Property(t => t.WeekOfMonth).HasColumnName("WeekOfMonth");
        }
    }
}
