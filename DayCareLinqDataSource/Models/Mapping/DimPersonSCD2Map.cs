using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimPersonSCD2Map : EntityTypeConfiguration<DimPersonSCD2>
    {
        public DimPersonSCD2Map()
        {
            // Primary Key
            this.HasKey(t => t.PersonKey);

            // Properties
            this.Property(t => t.LastName)
                .HasMaxLength(50);

            this.Property(t => t.Employer)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimPersonSCD2");
            this.Property(t => t.PersonKey).HasColumnName("PersonKey");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.EffectiveDateFrom).HasColumnName("EffectiveDateFrom");
            this.Property(t => t.EffectiveDateThrough).HasColumnName("EffectiveDateThrough");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Employer).HasColumnName("Employer");
            this.Property(t => t.GeographyKey).HasColumnName("GeographyKey");
        }
    }
}
