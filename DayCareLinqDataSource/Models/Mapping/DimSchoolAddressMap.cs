using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimSchoolAddressMap : EntityTypeConfiguration<DimSchoolAddress>
    {
        public DimSchoolAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.SchoolAddressKey);

            // Properties
            this.Property(t => t.Address1)
                .HasMaxLength(100);

            this.Property(t => t.Address2)
                .HasMaxLength(100);

            this.Property(t => t.City)
                .HasMaxLength(100);

            this.Property(t => t.State)
                .HasMaxLength(100);

            this.Property(t => t.ZipCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DimSchoolAddress");
            this.Property(t => t.SchoolAddressKey).HasColumnName("SchoolAddressKey");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.PrimaryPhoneNumber).HasColumnName("PrimaryPhoneNumber");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.EffectiveStartDate).HasColumnName("EffectiveStartDate");
            this.Property(t => t.EffectiveEndDate).HasColumnName("EffectiveEndDate");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
