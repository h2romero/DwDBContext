using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DayCareLinqDataSource.Models.Mapping
{
    public class DimClassMap : EntityTypeConfiguration<DimClass>
    {
        public DimClassMap()
        {
            // Primary Key
            this.HasKey(t => t.ClassKey);

            // Properties
            this.Property(t => t.ClassKey)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClassId)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DimClass");
            this.Property(t => t.ClassKey).HasColumnName("ClassKey");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.SchoolKey).HasColumnName("SchoolKey");
            this.Property(t => t.DefaultRoomKey).HasColumnName("DefaultRoomKey");
            this.Property(t => t.TenantKey).HasColumnName("TenantKey");
            this.Property(t => t.OrganizationUnitKey).HasColumnName("OrganizationUnitKey");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CurrentCapacity).HasColumnName("CurrentCapacity");
            this.Property(t => t.CurrentRequiredRatioChildrenNumber).HasColumnName("CurrentRequiredRatioChildrenNumber");
            this.Property(t => t.CurrentRequiredRatioTeachersNumber).HasColumnName("CurrentRequiredRatioTeachersNumber");
            this.Property(t => t.CurrentTargetedRatioChildrenNumber).HasColumnName("CurrentTargetedRatioChildrenNumber");
            this.Property(t => t.CurrentTargetedRatioTeachersNumber).HasColumnName("CurrentTargetedRatioTeachersNumber");
            this.Property(t => t.CurrentStartAgeTimeUnit).HasColumnName("CurrentStartAgeTimeUnit");
            this.Property(t => t.CurrentEndAgeTimeUnit).HasColumnName("CurrentEndAgeTimeUnit");
            this.Property(t => t.CurrentStartAge).HasColumnName("CurrentStartAge");
            this.Property(t => t.CurrentEndAge).HasColumnName("CurrentEndAge");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DWUpdateDate).HasColumnName("DWUpdateDate");
            this.Property(t => t.DWInsertDate).HasColumnName("DWInsertDate");
        }
    }
}
