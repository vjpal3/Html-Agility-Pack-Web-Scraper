using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HAPWebScraper
{
    class Scraper
    {
        private HtmlDocument htmlDoc;

        public void Start()
        {
            LoadWebPage();
            TraverseAndScrapeData();
        }

        public void LoadWebPage()
        {
            var html = @"https://money.cnn.com/data/markets/dow/";

            HtmlWeb web = new HtmlWeb();
            htmlDoc = web.Load(html);          
        }

        private void TraverseAndScrapeData()
        {
            var tableNode = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='wsod_dataTableBorder']//table[@class='wsod_dataTable wsod_dataTableBig']");
            var rowsNodeList = tableNode.SelectNodes("//tbody//tr");
            foreach (var row in rowsNodeList)
            {
                var cells = row.SelectNodes("td");
                for (int i=0; i < cells.Count; i++)
                {
                    Console.Write(cells[i].InnerText + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
