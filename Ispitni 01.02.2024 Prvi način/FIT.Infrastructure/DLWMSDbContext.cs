using FIT.Data;
using FIT.Data.IB210224;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<DrzaveIB210224> DrzaveIB210224 { get; set; }
        public DbSet<GradoviIB210224> GradoviIB210224 { get; set; }
        public DbSet<PredmetiIB210224> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB210224> PolozeniPredmeti { get; set; }
    }
}