using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class HubPersonMap : EntityTypeConfiguration<HubPerson>
    {
        public HubPersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonKey);

            // Properties
            this.Property(t => t.PersonID)
                .HasMaxLength(100);

            this.Property(t => t.RecordSource)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HubPerson");
            this.Property(t => t.PersonKey).HasColumnName("PersonKey");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
            this.Property(t => t.RecordSource).HasColumnName("RecordSource");
        }
    }
}
