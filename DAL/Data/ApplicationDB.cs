using ColorOasisSystem.DAL.Entities;
using ColorOasisSystem.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace ColorOasisSystem
{
    public class ApplicationDB : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ColorOasisSystem.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public ApplicationDB()
            : base(Properties.Settings.Default.ConnectionString)
        {
            this.Database.CommandTimeout = 180;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //todo:Uncomment
            modelBuilder.Entity<Service>()
           .Property(p => p.Photo)
           .HasColumnType("image");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CompanyInfo> CompanyInfo { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermissions> UserPermissions { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<QuotationDetails> QuotationDetails { get; set;}
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCategory> ServiceCategories {  get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ClientPayment> ClientPayments { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionDetails> InspectionDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}