using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class FactCheckInMap : EntityTypeConfiguration<FactCheckIn>
    {
        public FactCheckInMap()
        {
            // Primary Key
            this.HasKey(t => t.CheckInKey);

            // Properties
            // Table & Column Mappings
            this.ToTable("FactCheckIn");
            this.Property(t => t.CheckInKey).HasColumnName("CheckInKey");
            this.Property(t => t.CheckInDateTime).HasColumnName("CheckInDateTime");
            this.Property(t => t.CheckInDateKey).HasColumnName("CheckInDateKey");
            this.Property(t => t.CheckInTimeKey).HasColumnName("CheckInTimeKey");
            this.Property(t => t.CheckTypeKey).HasColumnName("CheckTypeKey");
            this.Property(t => t.ChildKey).HasColumnName("ChildKey");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.CreatedByPersonKey).HasColumnName("CreatedByPersonKey");
            this.Property(t => t.DataCaptureKey).HasColumnName("DataCaptureKey");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.TransportPersonKey).HasColumnName("TransportPersonKey");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
