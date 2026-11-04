using DataEntity.Data;
using Microsoft.EntityFrameworkCore;

namespace DataEntity
{
    public class SkladContext : DbContext
    {
        public DbSet<Material> Materialy => Set<Material>();
        public DbSet<MernaJednotka> MerneJednotky => Set<MernaJednotka>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                   .UseSqlServer(                                 // Provider pro SQL Server / LocalDB
                       "Data Source=(localdb)\MSSQLLocalDB;" +   // (a) jméno LocalDB instance
                       "Initial Catalog=Sklad2026;" +              // (b) název databáze
                       "Integrated Security=True;" +               // (c) Windows autentizace
                       "TrustServerCertificate=True")              // (d) potlačí varování s certifikátem u LocalDB
                   .UseLazyLoadingProxies();
            }    
        }
    }
}
