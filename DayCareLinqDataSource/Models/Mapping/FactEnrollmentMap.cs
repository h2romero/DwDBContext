using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class FactEnrollmentMap : EntityTypeConfiguration<FactEnrollment>
    {
        public FactEnrollmentMap()
        {
            // Primary Key
            this.HasKey(t => t.EnrollmentKey);

            // Properties
            // Table & Column Mappings
            this.ToTable("FactEnrollment");
            this.Property(t => t.EnrollmentKey).HasColumnName("EnrollmentKey");
            this.Property(t => t.EnrollmentDateTime).HasColumnName("EnrollmentDateTime");
            this.Property(t => t.EnrollmentDateKey).HasColumnName("EnrollmentDateKey");
            this.Property(t => t.ChildKey).HasColumnName("ChildKey");
            this.Property(t => t.CreatedByPersonKey).HasColumnName("CreatedByPersonKey");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.YearInSchoolKey).HasColumnName("YearInSchoolKey");
            this.Property(t => t.IsLatest).HasColumnName("IsLatest");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
