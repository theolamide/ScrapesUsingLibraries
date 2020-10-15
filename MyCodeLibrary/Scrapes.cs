using System;
using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebPage(url);

            File.WriteAllText(filepath, reply);
            return reply;

        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }

}
