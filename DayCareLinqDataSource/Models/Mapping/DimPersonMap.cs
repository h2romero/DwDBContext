using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimPersonMap : EntityTypeConfiguration<DimPerson>
    {
        public DimPersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonKey);

            // Properties
            this.Property(t => t.FirstName)
                .HasMaxLength(50);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .HasMaxLength(50);

            this.Property(t => t.PreferredName)
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .HasMaxLength(102);

            this.Property(t => t.FullNameL)
                .HasMaxLength(102);

            this.Property(t => t.Prefix)
                .HasMaxLength(50);

            this.Property(t => t.Suffix)
                .HasMaxLength(50);

            this.Property(t => t.Ethnicity)
                .HasMaxLength(50);

            this.Property(t => t.BloodType)
                .HasMaxLength(50);

            this.Property(t => t.Employer)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .HasMaxLength(50);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(50);

            this.Property(t => t.PrimaryPhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.MobilePhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.HomePhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.WorkPhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.WorkExtension)
                .HasMaxLength(50);

            this.Property(t => t.Address1)
                .HasMaxLength(50);

            this.Property(t => t.Address2)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.ZipCode)
                .HasMaxLength(50);

            this.Property(t => t.ZipFour)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DimPerson");
            this.Property(t => t.PersonKey).HasColumnName("PersonKey");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.PreferredName).HasColumnName("PreferredName");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.FullNameL).HasColumnName("FullNameL");
            this.Property(t => t.Prefix).HasColumnName("Prefix");
            this.Property(t => t.Suffix).HasColumnName("Suffix");
            this.Property(t => t.Ethnicity).HasColumnName("Ethnicity");
            this.Property(t => t.BloodType).HasColumnName("BloodType");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.BirthDateKey).HasColumnName("BirthDateKey");
            this.Property(t => t.Employer).HasColumnName("Employer");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.PrimaryPhoneNumber).HasColumnName("PrimaryPhoneNumber");
            this.Property(t => t.MobilePhoneNumber).HasColumnName("MobilePhoneNumber");
            this.Property(t => t.HomePhoneNumber).HasColumnName("HomePhoneNumber");
            this.Property(t => t.WorkPhoneNumber).HasColumnName("WorkPhoneNumber");
            this.Property(t => t.WorkExtension).HasColumnName("WorkExtension");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.ZipFour).HasColumnName("ZipFour");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Lon).HasColumnName("Lon");
            this.Property(t => t.Tags).HasColumnName("Tags");
            this.Property(t => t.GeographyKey).HasColumnName("GeographyKey");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.DateInserted).HasColumnName("DateInserted");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
