using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleBizLayer;
using SampleObjects;
using SampleWebForum.UIClasses;

namespace SampleWebForum
{    
    /// <summary>
    /// The Code Backend for the Default/Login page
    /// </summary>
    public partial class _Default : Page
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

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the ButtonLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.ImageClickEventArgs"/> instance containing the event data.</param>
        protected void ButtonLogin_Click(object sender, ImageClickEventArgs e)
        {
            if (AuthenticationInterface.AuthenticateUser(TextUserName.Text.Trim(), TextPassword.Text.Trim()))
            {
                //Add forums authentication stuff
            }
            else
            {
                PageErrors.Add("Invalid user name or password");

                LiteralErrors.Text = UITools.BuildErrors(PageErrors);
            }
            
        }
    }
}