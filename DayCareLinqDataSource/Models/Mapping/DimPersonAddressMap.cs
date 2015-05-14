using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimPersonAddressMap : EntityTypeConfiguration<DimPersonAddress>
    {
        public DimPersonAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonAddressKey);

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
            this.ToTable("DimPersonAddress");
            this.Property(t => t.PersonAddressKey).HasColumnName("PersonAddressKey");
            this.Property(t => t.PersonKey).HasColumnName("PersonKey");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.HomePhoneNumber).HasColumnName("HomePhoneNumber");
            this.Property(t => t.MobilePhoneNumber).HasColumnName("MobilePhoneNumber");
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
