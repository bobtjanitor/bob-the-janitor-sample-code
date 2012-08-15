using System;
using System.Web.UI;
using SimpleDB.BIZ;
using SimpleDB.Objects;

namespace SimpleDBSample
{
    public partial class _Default : Page
    {
        private IContactsRequests contactRequestInterface;

        public IContactsRequests  ContactRequestInterface
        {
            get
            {
                if (contactRequestInterface==null)
                {
                    contactRequestInterface = Factories.GetContactRequests();
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
            if (!IsPostBack)
            {
                GetContactData();
            }         
        }

        public void GetContactData()
        {
            Contacts contactResults = ContactRequestInterface.GetContacts();
            gridContacts.DataSource = contactResults;
            gridContacts.DataBind();
        }

        protected void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchName = textContactName.Text;
            Contacts contactResults = ContactRequestInterface.SearchContactsByName(searchName);
            gridContacts.DataSource = contactResults;
            gridContacts.DataBind();
        }

        protected void buttonAddContact_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            newContact.Name = TextName.Text;
            newContact.Email = TextEmail.Text;
            newContact.Phone = TextPhone.Text;
            ContactRequestInterface.AddContact(newContact);

            GetContactData();

        }

        protected void buttonShowAll_Click(object sender, EventArgs e)
        {
            Contacts contactResults = ContactRequestInterface.GetContacts();
            gridContacts.DataSource = contactResults;            
            gridContacts.DataBind();
        }
    }
}
