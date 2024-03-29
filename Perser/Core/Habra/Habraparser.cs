﻿using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perser.Core.Habra
{
    class Habraparser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("tm-user-info__username"));
            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
