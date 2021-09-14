using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using WebScraping.Models;

namespace Webscraping
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb oWeb = new HtmlWeb();
            string url = "https://app.hustlegotreal.com/";

            HtmlNode Body = doc.DocumentNode.CssSelect("value").first();
            string sBody = Body.InnerHTML;
        }
    }
}