using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cyclingLog.Tests
{
    [TestClass]
    public class PagingHelper_Tests
    {
        [TestMethod]
        public void PageLinks_Test()
        {
            HtmlHelper html = null;
            html.PageLinks(0, 0, null);
        }
    }
}


