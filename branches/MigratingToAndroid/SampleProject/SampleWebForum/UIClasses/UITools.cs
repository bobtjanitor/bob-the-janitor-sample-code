using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using SampleObjects;

namespace SampleWebForum.UIClasses
{
    /// <summary>
    /// Tools for doing tasks in the UI layer
    /// </summary>
    public static class UITools
    {
        /// <summary>
        /// Builds the errors.
        /// </summary>
        /// <param name="pageErrors">The page errors.</param>
        /// <returns></returns>
        public static string BuildErrors(Errors pageErrors)
        {
            StringBuilder errorList = new StringBuilder();
            errorList.Append("<ul class=\"Error\">");
            for (int i = 0; i < pageErrors.Count; i++)
            {
                errorList.Append("<li>");
                errorList.Append(pageErrors[i].Message);
                errorList.Append("</li>");

            }
            errorList.Append("</ul>");

            return errorList.ToString();
        }
    }
}
