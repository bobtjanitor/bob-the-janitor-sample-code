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
    [DefaultProperty("Text")]
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
                bool selected = (bool)ViewState["Selected"];
                return selected;
            }
            set
            {
                ViewState["Selected"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.RenderBeginTag(HtmlTextWriterTag.Div);
            output.AddAttribute(HtmlTextWriterAttribute.Class, isSelected(Selected));    
           
            
            output.Write(Text);
        }

        private string isSelected(bool selected)
        {
            string className = "MenuItem";
            if (selected)
            {
                className = "MenuItemSelected";
            }
            return className;
        }
    }

    public class MenuItmeControls : Collection<MenuItemControl>
    {}
}
