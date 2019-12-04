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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Helper.GetConnectionString("HAPScraperDB"));
        }

        public DbSet<StockData> StocksData { get; set; }
    }
}
