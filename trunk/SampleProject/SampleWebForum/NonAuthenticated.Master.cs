using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleBizLayer;
using SampleObjects;

namespace SampleWebForum
{
    public partial class NonAuthenticated : System.Web.UI.MasterPage
    {
        private IAuthentication _authenticationInterface = new Authentication();
        private Errors PageErrors = new Errors();
        /// <summary>
        /// Gets or sets the authentication interface.
        /// </summary>
        /// <value>The authentication interface.</value>
        public IAuthentication AuthenticationInterface
        {
            get { return _authenticationInterface; }
            set { _authenticationInterface = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SetLoggedinStatus();

        }

        private void SetLoggedinStatus()
        {
            if (!string.IsNullOrEmpty(Request.ServerVariables["AuthUser"]))
            {
                divLoggedIn.Visible = true;
                divLogIn.Visible = false;
                literalAuthenticatedUser.Text = Request.ServerVariables["AuthUser"];                
            }
            else
            {
                divLoggedIn.Visible = false;
                divLogIn.Visible = true;
                
            }
            
           
        }

        protected void buttonLogin_Click(object sender, ImageClickEventArgs e)
        {
            if (AuthenticationInterface.AuthenticateUser(textUserName.Text.Trim(), textPassword.Text.Trim()))
            {                
                FormsAuthentication.RedirectFromLoginPage(textUserName.Text.Trim(), true);
                Response.Redirect("~/Authenticated/Customers.aspx");
                
            }            
        }
    }
}
