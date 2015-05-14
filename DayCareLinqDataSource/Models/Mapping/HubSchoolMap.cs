using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class HubSchoolMap : EntityTypeConfiguration<HubSchool>
    {
        public HubSchoolMap()
        {
            // Primary Key
            this.HasKey(t => t.SchoolKey);

            // Properties
            this.Property(t => t.SchoolID)
                .HasMaxLength(100);

            this.Property(t => t.RecordSource)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HubSchool");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.SchoolID).HasColumnName("SchoolID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.RecordSource).HasColumnName("RecordSource");
        }
    }
}
