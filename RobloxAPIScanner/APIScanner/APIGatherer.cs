using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Text;
using APIScanner.Internal;
using System.Threading.Tasks;

namespace APIScanner
{
    public class APIScraper
    {
        public APIScraper()
        {

        }

        public void GatherAPI()
        {
            Task<List<string>> DataTypesIndexURLS = GetItemsFromIndex(WebsiteLocations.DataTypeIndex, WebsiteLocations.DataTypesIndexPath);
            Task<List<string>> LUADOCIndexURLS = GetItemsFromIndex(WebsiteLocations.LUADocIndex, WebsiteLocations.LUADocumentsIndexPath);
            
        }

        private async Task<List<string>> GetItemsFromIndex(string IndexPage, string IndexPath)
        {
            var HTTPResponse = await CentralClient.Client.GetAsync(IndexPage);
            Console.WriteLine(HTTPResponse.StatusCode);
            if (HTTPResponse.StatusCode == HttpStatusCode.OK)
            {
                var URLS = new List<string>();
                string HTMLData = await HTTPResponse.Content.ReadAsStringAsync();

                if (IndexPath == "data-types/")
                {
                    IndexPath = "data-type/";
                }

                bool MoreItems = true;
                while (MoreItems)
                {
                    int PathIndex = HTMLData.IndexOf(IndexPath);
                    int StartIndex = PathIndex + IndexPath.Length;
                    int EndIndex = HTMLData.IndexOf("\"", StartIndex) - StartIndex- 1;
                    
                    if (PathIndex == -1)
                    {
                        MoreItems = false;
                    }
                    else
                    {
                        string ItemName = HTMLData.Substring(StartIndex, EndIndex);
                        HTMLData = HTMLData.Substring(EndIndex, HTMLData.Length - EndIndex);
                        Console.WriteLine(ItemName);
                    }
                    Console.WriteLine(StartIndex);
                }
                return URLS;
            }
            else
            {
                return null;
            }
        } 
    }
}
