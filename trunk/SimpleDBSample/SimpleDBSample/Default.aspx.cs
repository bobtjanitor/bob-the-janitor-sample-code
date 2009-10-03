using System;
using System.Web.UI;
using SimpleDB.BIZ;
using SimpleDB.Objects;

namespace SimpleDBSample
{
    public partial class _Default : Page
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
            gridContacts.DataSource = contactResults;
            gridContacts.DataBind();
        }
    }
}
