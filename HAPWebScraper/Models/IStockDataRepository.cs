using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAPWebScraper.Models
{
    public interface IStockDataRepository
    {
        StockData Add(StockData stockData);
    }
}
