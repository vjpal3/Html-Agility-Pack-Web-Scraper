using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAPWebScraper.Models
{
    class DbWriter
    {
        public static void InsertStocksData(List<string> scrapedData)
        {
            using(var db = new AppDbContext())
            {
                var scrapeDate = DateTime.Now;

                foreach (var item in scrapedData)
                {
                    var data = item.Split('\t');

                    var company = data[0].Replace("&nbsp;", " ").Split(); ;
                    var symbol = company[0];
                    var companyName = company[1];
                    var price = ParseDecimalString(data[1].Trim());
                    var change = ParseDecimalString(data[2].Trim());
                    var percentChange = ParseDecimalString(data[3].Trim());
                    var pe = ParseDecimalString(data[4].Trim());
                    var volume = ParseVolume(data[5].Trim());
                    var ytdChange = ParseDecimalString(data[6].Trim());

                    db.Add(new StockData
                    {
                        ScrapeDate = scrapeDate,
                        Symbol = symbol,
                        CompanyName = companyName,
                        Price = price,
                        Change = change,
                        PercentChange = percentChange,
                        PE = pe,
                        Volume = volume,
                        YTDChange = ytdChange
                    });
                }
                db.SaveChanges();
            }
        }

        private static decimal? ParseDecimalString(string decimalString)
        {
            if (decimalString.StartsWith("+"))
            {
                decimalString = decimalString.Replace("+", "");
            }
            if (decimalString.EndsWith("%"))
            {
                decimalString = decimalString.Replace("%", "");
            }
            return decimal.TryParse(decimalString, out decimal result) ? result : (decimal?)null;
        }

        private static decimal? ParseVolume(string volume)
        {
            char volumeUnit = volume[volume.Length - 1];
            decimal? stockVolume;
            switch (volumeUnit)
            {
                case 'K':
                    stockVolume = ParseDecimalString(volume.TrimEnd('K')) * (decimal?)Math.Pow(10.00, 3.00);
                    break;

                case 'M':
                    stockVolume = ParseDecimalString(volume.TrimEnd('M')) * (decimal?)Math.Pow(10.00, 6.00);
                    break;

                case 'B':
                    stockVolume = ParseDecimalString(volume.TrimEnd('B')) * (decimal?)Math.Pow(10.00, 9.00);
                    break;

                case 'T':
                    stockVolume = ParseDecimalString(volume.TrimEnd('T')) * (decimal?)Math.Pow(10.00, 12.00);
                    break;

                default:
                    stockVolume = ParseDecimalString(volume);
                    break;
            }
            return stockVolume;
        }
    }
}
