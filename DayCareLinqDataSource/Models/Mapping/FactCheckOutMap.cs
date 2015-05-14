using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class FactCheckOutMap : EntityTypeConfiguration<FactCheckOut>
    {
        public FactCheckOutMap()
        {
            // Primary Key
            this.HasKey(t => t.CheckOutKey);

            // Properties
            // Table & Column Mappings
            this.ToTable("FactCheckOut");
            this.Property(t => t.CheckOutKey).HasColumnName("CheckOutKey");
            this.Property(t => t.CheckOutDateTime).HasColumnName("CheckOutDateTime");
            this.Property(t => t.CheckOutDateKey).HasColumnName("CheckOutDateKey");
            this.Property(t => t.CheckOutTimeKey).HasColumnName("CheckOutTimeKey");
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
