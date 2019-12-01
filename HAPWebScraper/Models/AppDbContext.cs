using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HAPWebScraper.Models
{
    class AppDbContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\ProjectsV13;Database=HAPScraperDB;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<StockData> StocksData { get; set; }
    }
}
