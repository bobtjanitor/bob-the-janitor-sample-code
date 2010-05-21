using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControls
{
    
    [ToolboxData("<{0}:MenuItemControl runat=server></{0}:MenuItemControl>")]
    public class MenuItemControl : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string LinkURL
        {
            get
            {
                String s = (String)ViewState["LinkURL"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["LinkURL"] = value;
            }
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue(false)]
        [Localizable(true)]
        public bool Selected
        {
            get
            {
                bool selected = false;
                if (ViewState["Selected"]!=null)
                {
                    selected = (bool)ViewState["Selected"];
                }
                return selected;
            }
            set
            {
                ViewState["Selected"] = value;
            }
        }

        protected override void CreateChildControls()
        {
            Controls.Clear();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, setCssClass());
            writer.RenderBeginTag(HtmlTextWriterTag.Div);            
            RenderContents(writer);
            writer.RenderEndTag();
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            EnsureChildControls();
            
            buildContent(output);                            
        }

        private void buildContent(HtmlTextWriter output)
        {
            if (Selected)
            {
                output.Write(Text);
            }
            else
            {
                output.AddAttribute(HtmlTextWriterAttribute.Style, "Display:Block;Text-decoration:none;color:black;");
                output.AddAttribute(HtmlTextWriterAttribute.Href, LinkURL);
                output.RenderBeginTag(HtmlTextWriterTag.A);                
                output.InnerWriter.Write(Text);
                output.RenderEndTag();
            }
        }

        private string setCssClass()
        {
            string className = "MenuItem";
            if (Selected)
            {
                className = "MenuItemSelected";
            }
            return className;
        }
    }

    public class MenuItmeControls : Collection<MenuItemControl>
    {}
}
