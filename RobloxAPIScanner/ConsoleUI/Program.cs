using System;
using APIScanner;
namespace ConsoleUI
{
    class Program
    {
        private static APIScraper Scraper = new APIScraper();
        static void Main(string[] args)
        {
            Scraper.GatherAPI();
            while (true)
            {

            }
        }
    }
}
