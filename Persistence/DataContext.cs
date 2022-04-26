using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<AZS> AZS { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<NetAZS> NetAzses { get; set; }
        public DbSet<NumberPhone> NumberPhones { get; set; }
        public DbSet<Payed> Payeds { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // payed entity one to many relationship
            builder.Entity<Payed>(x => x.HasKey(p => new {p.CompanyId, p.DriverId, p.AZSId}));

            builder.Entity<Payed>()
                .HasOne(p => p.Company)
                .WithMany(p => p.Payeds)
                .HasForeignKey(p => p.CompanyId);

            builder.Entity<Payed>()
                .HasOne(p => p.Azs)
                .WithMany(p => p.Payeds)
                .HasForeignKey(p => p.AZSId);

            builder.Entity<Payed>()
                .HasOne(p => p.Driver)
                .WithMany(p => p.Payeds)
                .HasForeignKey(p => p.DriverId);


            // AZS one to many relationship
            builder.Entity<AZS>()
                .HasOne(a => a.NetAzs)
                .WithMany(a => a.AZSES)
                .HasForeignKey(a => a.NetAZSId);

            // Driver one to many relationship
            builder.Entity<Driver>()
                .HasOne(a => a.Company)
                .WithMany(a => a.Drivers)
                .HasForeignKey(a => a.CompanyId);

            // NumberPhone one to many relationship
            builder.Entity<NumberPhone>()
                .HasOne(a => a.Driver)
                .WithMany(a => a.Phones)
                .HasForeignKey(a => a.DriverId);
        } 
    }
    
    
}