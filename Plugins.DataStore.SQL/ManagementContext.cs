using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Plugins.DataStore.SQL
{
    public class ManagementContext : DbContext
    {
        public ManagementContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Projects)
                .WithOne(p => p.Company)
                .HasForeignKey(p => p.CompanyId);

            //data seeding
            modelBuilder.Entity<Company>().HasData(
                    new Company { CompanyId = 1, Name = "NTB", Description = "Bank" },
                    new Company { CompanyId = 2, Name = "HNB", Description = "Bank" },
                    new Company { CompanyId = 3, Name = "AFC", Description = "Finance" }
                );

            modelBuilder.Entity<Project>().HasData(
                   new Project { ProjectId = 1, CompanyId = 1, Name = "Excess Management", Description = "System for managing overdrawn cheques" },
                   new Project { ProjectId = 2, CompanyId = 1, Name = "Loan Origination", Description = "System for loans" },
                   new Project { ProjectId = 2, CompanyId = 2, Name = "FEBA", Description = "Front end for digital banking" }
               );
        }
    }

}