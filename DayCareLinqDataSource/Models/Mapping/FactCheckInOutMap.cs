using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class FactCheckInOutMap : EntityTypeConfiguration<FactCheckInOut>
    {
        public FactCheckInOutMap()
        {
            // Primary Key
            this.HasKey(t => t.CheckInOutKey);

            // Properties
            // Table & Column Mappings
            this.ToTable("FactCheckInOut");
            this.Property(t => t.CheckInOutKey).HasColumnName("CheckInOutKey");
            this.Property(t => t.CheckInKey).HasColumnName("CheckInKey");
            this.Property(t => t.CheckOutKey).HasColumnName("CheckOutKey");
            this.Property(t => t.CheckInDateTime).HasColumnName("CheckInDateTime");
            this.Property(t => t.CheckInDateKey).HasColumnName("CheckInDateKey");
            this.Property(t => t.CheckInTimeKey).HasColumnName("CheckInTimeKey");
            this.Property(t => t.CheckOutDateTime).HasColumnName("CheckOutDateTime");
            this.Property(t => t.CheckOutDateKey).HasColumnName("CheckOutDateKey");
            this.Property(t => t.CheckOutTimeKey).HasColumnName("CheckOutTimeKey");
            this.Property(t => t.CheckInOutLag).HasColumnName("CheckInOutLag");
            this.Property(t => t.CheckTypeKey).HasColumnName("CheckTypeKey");
            this.Property(t => t.ChildKey).HasColumnName("ChildKey");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.CheckInCreatedByPersonKey).HasColumnName("CheckInCreatedByPersonKey");
            this.Property(t => t.CheckOutCreatedByPersonKey).HasColumnName("CheckOutCreatedByPersonKey");
            this.Property(t => t.CheckInDataCaptureKey).HasColumnName("CheckInDataCaptureKey");
            this.Property(t => t.CheckOutDataCaptureKey).HasColumnName("CheckOutDataCaptureKey");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.CheckInTransportPersonKey).HasColumnName("CheckInTransportPersonKey");
            this.Property(t => t.CheckOutTransportPersonKey).HasColumnName("CheckOutTransportPersonKey");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
        }
    }
}
