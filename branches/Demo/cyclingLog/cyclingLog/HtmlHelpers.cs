using System;
using System.Text;
using System.Web.Mvc;

namespace cyclingLog
{
    public static class HtmlHelpers
    {
        public static string PageLinks(this HtmlHelper html, int currentPage, int totalPages, Func<int,string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= totalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href",pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i==currentPage)
                {
                    tag.AddCssClass("selected");
                }
                result.AppendLine(tag.ToString());
            }
            return result.ToString();
        }
    }
}