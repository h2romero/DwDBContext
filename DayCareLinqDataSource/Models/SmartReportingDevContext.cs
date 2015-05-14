using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DayCareLinqDataSource.Models.Mapping;

namespace DayCareLinqDataSource.Models
{
    public partial class SmartReportingDevContext : DbContext
    {
        static SmartReportingDevContext()
        {
            Database.SetInitializer<SmartReportingDevContext>(null);
        }

        public SmartReportingDevContext()
            : base("Name=SmartReportingDevContext")
        {
        }

        public DbSet<BridgeOrganizationUnitTag> BridgeOrganizationUnitTags { get; set; }
        public DbSet<DimCheckType> DimCheckTypes { get; set; }
        public DbSet<DimChild> DimChilds { get; set; }
        public DbSet<DimChildAddress> DimChildAddresses { get; set; }
        public DbSet<DimClass> DimClasses { get; set; }
        public DbSet<DimDataCapture> DimDataCaptures { get; set; }
        public DbSet<DimDate> DimDates { get; set; }
        public DbSet<DimLedger> DimLedgers { get; set; }
        public DbSet<DimOrganizationUnit> DimOrganizationUnits { get; set; }
        public DbSet<DimPerson> DimPersons { get; set; }
        public DbSet<DimPersonAddress> DimPersonAddresses { get; set; }
        public DbSet<DimPersonSCD1> DimPersonSCD1 { get; set; }
        public DbSet<DimPersonSCD2> DimPersonSCD2 { get; set; }
        public DbSet<DimSchool> DimSchools { get; set; }
        public DbSet<DimSchoolAddress> DimSchoolAddresses { get; set; }
        public DbSet<DimTag> DimTags { get; set; }
        public DbSet<DimTenant> DimTenants { get; set; }
        public DbSet<DimTenantSCD1> DimTenantSCD1 { get; set; }
        public DbSet<DimTenantSCD2> DimTenantSCD2 { get; set; }
        public DbSet<DimTime> DimTimes { get; set; }
        public DbSet<DimYearInSchool> DimYearInSchools { get; set; }
        public DbSet<FactCheckIn> FactCheckIns { get; set; }
        public DbSet<FactCheckInOut> FactCheckInOuts { get; set; }
        public DbSet<FactCheckOut> FactCheckOuts { get; set; }
        public DbSet<FactEnrollment> FactEnrollments { get; set; }
        public DbSet<FactLedgerBalance> FactLedgerBalances { get; set; }
        public DbSet<FactWithdraw> FactWithdraws { get; set; }
        public DbSet<HubChild> HubChilds { get; set; }
        public DbSet<HubClass> HubClasses { get; set; }
        public DbSet<HubClassGuidTemp> HubClassGuidTemps { get; set; }
        public DbSet<HubOrganizationUnit> HubOrganizationUnits { get; set; }
        public DbSet<HubPerson> HubPersons { get; set; }
        public DbSet<HubSchool> HubSchools { get; set; }
        public DbSet<HubTenant> HubTenants { get; set; }
        public DbSet<SatChildAddress> SatChildAddresses { get; set; }
        public DbSet<SatPersonAddress> SatPersonAddresses { get; set; }
        public DbSet<SatSchoolAddress> SatSchoolAddresses { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BridgeOrganizationUnitTagMap());
            modelBuilder.Configurations.Add(new DimCheckTypeMap());
            modelBuilder.Configurations.Add(new DimChildMap());
            modelBuilder.Configurations.Add(new DimChildAddressMap());
            modelBuilder.Configurations.Add(new DimClassMap());
            modelBuilder.Configurations.Add(new DimDataCaptureMap());
            modelBuilder.Configurations.Add(new DimDateMap());
            modelBuilder.Configurations.Add(new DimLedgerMap());
            modelBuilder.Configurations.Add(new DimOrganizationUnitMap());
            modelBuilder.Configurations.Add(new DimPersonMap());
            modelBuilder.Configurations.Add(new DimPersonAddressMap());
            modelBuilder.Configurations.Add(new DimPersonSCD1Map());
            modelBuilder.Configurations.Add(new DimPersonSCD2Map());
            modelBuilder.Configurations.Add(new DimSchoolMap());
            modelBuilder.Configurations.Add(new DimSchoolAddressMap());
            modelBuilder.Configurations.Add(new DimTagMap());
            modelBuilder.Configurations.Add(new DimTenantMap());
            modelBuilder.Configurations.Add(new DimTenantSCD1Map());
            modelBuilder.Configurations.Add(new DimTenantSCD2Map());
            modelBuilder.Configurations.Add(new DimTimeMap());
            modelBuilder.Configurations.Add(new DimYearInSchoolMap());
            modelBuilder.Configurations.Add(new FactCheckInMap());
            modelBuilder.Configurations.Add(new FactCheckInOutMap());
            modelBuilder.Configurations.Add(new FactCheckOutMap());
            modelBuilder.Configurations.Add(new FactEnrollmentMap());
            modelBuilder.Configurations.Add(new FactLedgerBalanceMap());
            modelBuilder.Configurations.Add(new FactWithdrawMap());
            modelBuilder.Configurations.Add(new HubChildMap());
            modelBuilder.Configurations.Add(new HubClassMap());
            modelBuilder.Configurations.Add(new HubClassGuidTempMap());
            modelBuilder.Configurations.Add(new HubOrganizationUnitMap());
            modelBuilder.Configurations.Add(new HubPersonMap());
            modelBuilder.Configurations.Add(new HubSchoolMap());
            modelBuilder.Configurations.Add(new HubTenantMap());
            modelBuilder.Configurations.Add(new SatChildAddressMap());
            modelBuilder.Configurations.Add(new SatPersonAddressMap());
            modelBuilder.Configurations.Add(new SatSchoolAddressMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
