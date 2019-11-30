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
            var html = @"https://money.cnn.com/data/markets/dow/";

            HtmlWeb web = new HtmlWeb();
            htmlDoc = web.Load(html);          
        }

    }
}
