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
        }
        public void LoadWebPage()
        {
            var html = @"https://www.google.com/finance";

            HtmlWeb web = new HtmlWeb();
            

            htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//html");
            if(node != null)
            {
                Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);
            }

            


        }


    }
}
