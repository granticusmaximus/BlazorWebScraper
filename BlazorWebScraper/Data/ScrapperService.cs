using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebScraper.Data
{
    public class ScrapperService
    {
        public async Task<List<string>> TakeOutScrapping()
        {
            List<string> Datalist = new List<string>();
            HttpClient hc = new HttpClient();
            HttpResponseMessage result = await hc.GetAsync($"https://www.likealocalguide.com/denver/restaurants#places_list");
            Stream stream = await result.Content.ReadAsStreamAsync();
            HtmlDocument doc = new HtmlDocument();
            doc.Load(stream);
            var Nodes = doc.DocumentNode.SelectNodes("//h4[@class='hide-if-mobile']");
            if (Nodes != null)
            {
                foreach (var node in Nodes)
                {
                    Datalist.Add(node.InnerText);
                }
            }
               

            return Datalist;
        }

        public async Task<List<string>> CafeScrapping()
        {
            List<string> Datalist = new List<string>();
            HttpClient hc = new HttpClient();
            HttpResponseMessage result = await hc.GetAsync($"https://www.likealocalguide.com/denver/cafes#places_list");
            Stream stream = await result.Content.ReadAsStreamAsync();
            HtmlDocument doc = new HtmlDocument();
            doc.Load(stream);
            var Nodes = doc.DocumentNode.SelectNodes("//h4[@class='hide-if-mobile']");
            if (Nodes != null)
            {
                foreach (var node in Nodes)
                {
                    Datalist.Add(node.InnerText);
                }
            }


            return Datalist;
        }
    }
}
