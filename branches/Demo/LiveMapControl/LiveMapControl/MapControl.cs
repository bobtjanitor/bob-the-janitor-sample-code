using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveMapControl
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:MapControl runat=server></{0}:ServerControl1>")]
    public class MapControl : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public MapPoints MapPoints
        {
            get
            {
                MapPoints points = (MapPoints)ViewState["MapPoints"];
                if (points == null)
                {
                    points = new MapPoints();
                }
                return points;
            }

            set
            {
                ViewState["MapPoints"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            //output.Write(Text);
        }
    }
}
