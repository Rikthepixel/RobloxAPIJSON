using System;
using System.Collections.Generic;
using System.Text;

namespace APIScanner
{
    public static class WebsiteLocations
    {
        public const string MainPage = "https://developer.roblox.com/en-us/";
        public const string APIReferencePath = "api-reference/";
        public const string ClassIndexPath = "index/";
        public const string EnumIndexPath = "enum/";
        public const string DataTypesIndexPath = "data-types/";
        public const string LUADocumentsIndexPath = "lua-docs/";
        public static string APIReference = MainPage + APIReferencePath;
        public static string ClassIndex = APIReference + ClassIndexPath;
        public static string EnumIndex = APIReference + EnumIndexPath;
        public static string DataTypeIndex = APIReference + DataTypesIndexPath;
        public static string LUADocIndex = APIReference + LUADocumentsIndexPath;

    }
}
