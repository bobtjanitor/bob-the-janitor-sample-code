using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleDB.BIZ;
using SimpleDB.Objects;

namespace SimpleDBSample
{
    public partial class _Default : System.Web.UI.Page
    {
        private ContactsRequests contactRequestInterface;

        public ContactsRequests  ContactRequestInterface
        {
            get
            {
                if (contactRequestInterface==null)
                {
                    contactRequestInterface = new ContactsRequests();
                }
                return contactRequestInterface;
            }
            set
            {
                contactRequestInterface = ContactRequestInterface;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchName = textContactName.Text;
            Contacts contactResults = ContactRequestInterface.SearchContactsByName(searchName);
        }
    }
}
