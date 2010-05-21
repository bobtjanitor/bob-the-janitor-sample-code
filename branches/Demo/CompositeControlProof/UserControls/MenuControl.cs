using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControls
{    
    [DefaultProperty("MenuItems"), ParseChildren(true, "MenuItems")]
    [ToolboxData("<{0}:MenuControl runat=\"server\"></{0}:MenuControl>")]
    public class MenuControl : WebControl
    {        
        [Category("Behavior"),Description("The item collection"), 
            DesignerSerializationVisibility (DesignerSerializationVisibility.Content), 
            PersistenceMode(PersistenceMode.InnerDefaultProperty)]
        public MenuItmeControls MenuItems {get; set;}

        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "Menu");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            RenderContents(writer);
            writer.RenderEndTag();
        }
       
        protected override void RenderContents(HtmlTextWriter output)
        {
            foreach (MenuItemControl item in MenuItems)
            {
                item.RenderControl(output);
            }            
        }
    }
}
