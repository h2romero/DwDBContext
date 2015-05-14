using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class SatSchoolAddressMap : EntityTypeConfiguration<SatSchoolAddress>
    {
        public SatSchoolAddressMap()
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

            this.Property(t => t.SatRecordSource)
                .HasMaxLength(100);

            this.Property(t => t.ChangeHash)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("SatSchoolAddress");
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
            this.Property(t => t.EffectiveDate).HasColumnName("EffectiveDate");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.SatRecordSource).HasColumnName("SatRecordSource");
            this.Property(t => t.ChangeHash).HasColumnName("ChangeHash");
        }
    }
}
