using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimYearInSchoolMap : EntityTypeConfiguration<DimYearInSchool>
    {
        public DimYearInSchoolMap()
        {
            // Primary Key
            this.HasKey(t => t.YearInSchoolKey);

            // Properties
            this.Property(t => t.YearInSchoolKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YearInSchool)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimYearInSchool");
            this.Property(t => t.YearInSchoolKey).HasColumnName("YearInSchoolKey");
            this.Property(t => t.YearInSchool).HasColumnName("YearInSchool");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
