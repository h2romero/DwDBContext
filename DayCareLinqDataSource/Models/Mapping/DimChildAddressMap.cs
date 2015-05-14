using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimChildAddressMap : EntityTypeConfiguration<DimChildAddress>
    {
        public DimChildAddressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ChildAddressKey, t.ChildKey, t.EffectiveStartDate, t.EffectiveEndDate });

            // Properties
            this.Property(t => t.ChildAddressKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChildKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.HomePhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.MobilePhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.BusinessPhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.PrimaryPhoneNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimChildAddress");
            this.Property(t => t.ChildAddressKey).HasColumnName("ChildAddressKey");
            this.Property(t => t.ChildKey).HasColumnName("ChildKey");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.HomePhoneNumber).HasColumnName("HomePhoneNumber");
            this.Property(t => t.MobilePhoneNumber).HasColumnName("MobilePhoneNumber");
            this.Property(t => t.BusinessPhoneNumber).HasColumnName("BusinessPhoneNumber");
            this.Property(t => t.PrimaryPhoneNumber).HasColumnName("PrimaryPhoneNumber");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.EffectiveStartDate).HasColumnName("EffectiveStartDate");
            this.Property(t => t.EffectiveEndDate).HasColumnName("EffectiveEndDate");
            this.Property(t => t.IsCurrent).HasColumnName("IsCurrent");
            this.Property(t => t.SequenceID).HasColumnName("SequenceID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
