using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAPWebScraper.Models
{
    public class StockData
    {
        public int Id { get; set; }
        public DateTime ScrapeDate { get; set; }
        public string Company { get; set; }
        public decimal? Price { get; set; }
        public decimal? Change { get; set; }
        public decimal? PercentChange { get; set; }
        public decimal? PE { get; set; }
        public decimal? Volume { get; set; }
        public decimal? YTDChange { get; set; }
    }
}
