using System.IO;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace SampleApplication.Web.CustomViewEngine
{
    public class XsltViewEngine : VirtualPathProviderViewEngine
    {
        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            return new XsltView(controllerContext, partialPath);
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            return new XsltView(controllerContext, viewPath);
        }
    }

    public class XsltView : IView
    {
        private readonly XslCompiledTransform _template;

        public XsltView(ControllerContext controllerContext, string viewPath)
        {
            _template = new XslCompiledTransform();
            _template.Load(controllerContext.HttpContext.Server.MapPath(viewPath));
        }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            var xmlDoc = viewContext.ViewData.Model as XDocument;
            if(xmlDoc==null)
            {
                var xs = new XmlSerializer(viewContext.ViewData.Model.GetType());
                xmlDoc = new XDocument();
                using (var xWriter = xmlDoc.CreateWriter())
                {
                    xs.Serialize(xWriter, viewContext.ViewData.Model);
                }
            }
            _template.Transform(xmlDoc.CreateReader(),null,writer);
        }
    }
}