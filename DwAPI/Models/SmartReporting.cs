namespace DwAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SmartReporting : DbContext
    {
        public SmartReporting()
            : base("name=SmartReporting")
        {
        }

        public virtual DbSet<FactCheckInOut> FactCheckInOuts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
