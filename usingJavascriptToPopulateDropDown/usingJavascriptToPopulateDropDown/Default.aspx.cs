using System;
using System.Web.UI;

namespace usingJavascriptToPopulateDropDown
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setControlValues();
            setValue();
        }

        private void setControlValues()
        {
            selectCitySujest.Attributes["onclick"] = string.Format("getSuggestedCity(document.getElementById('{0}'),this)", textCity.ClientID);
            textCity.Attributes["onkeyup"] = string.Format("setSuggestions(document.getElementById('{0}'), this)", selectCitySujest.ClientID);
            textCity.Attributes["onfocus"] = string.Format("showSuggestions(document.getElementById('{0}'), this)", selectCitySujest.ClientID);
            selectState.Attributes["onfocus"] = string.Format("populateStates(this,document.getElementById('{0}'))",selectCountry.ClientID);
        }

        protected void buttonGetValue_Click(object sender, EventArgs e)
        {            
            output.Text = Request.Form[dropDownList.ID];
        }

        private void setValue()
        {
            //string script = string.Format("setpopulateDropdown('{0}',{1});", dropDownList.ClientID, Request.Form[dropDownList.ID]);
            //ClientScript.RegisterStartupScript(typeof(Page),"setDropdownValue",script,true);
            
        }
    }
}
