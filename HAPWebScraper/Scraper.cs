using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HAPWebScraper.Models;
using HtmlAgilityPack;

namespace HAPWebScraper
{
    class Scraper
    {
        private HtmlDocument htmlDoc;
        private readonly List<string> StocksData = new List<string>();

        public void Start()
        {
            LoadWebPage();
            TraverseAndScrapeData();
            SaveData();
        }

        private void SaveData()
        {
            throw new NotImplementedException();
        }

        public void LoadWebPage()
        {
            var html = @"https://money.cnn.com/data/markets/dow/";

            HtmlWeb web = new HtmlWeb();
            htmlDoc = web.Load(html);          
        }

        public List<string> GetStocksData()
        {
            return StocksData;
        }

        private void TraverseAndScrapeData()
        {
            var tableNode = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='wsod_dataTableBorder']//table[@class='wsod_dataTable wsod_dataTableBig']");
            var rowsNodeList = tableNode.SelectNodes("//tbody//tr");
            foreach (var row in rowsNodeList)
            {
                var cells = row.SelectNodes("td");
                var rowData = "";
                for (int i = 0; i < cells.Count; i++)
                {
                    rowData += cells[i].InnerText + "\t";
                }
                StocksData.Add(rowData);
            }
        }
    }
}
