using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace usingJavascriptToPopulateDropDown
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setValue();
        }

        protected void buttonGetValue_Click(object sender, EventArgs e)
        {            
            output.Text = Request.Form[dropDownList.ID];
        }

        private void setValue()
        {
            string script = string.Format("setpopulateDropdown('{0}',{1});", dropDownList.ClientID, Request.Form[dropDownList.ID]);
            ClientScript.RegisterStartupScript(typeof(Page),"setDropdownValue",script,true);
            
        }
    }
}
