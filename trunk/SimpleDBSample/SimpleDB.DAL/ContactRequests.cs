using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SimpleDB.Model;
using SimpleDB.Objects;

namespace SimpleDB.DAL
{
    public class ContactRequests
    {
        private Proxy proxy;
        public Proxy myProxy
        {
            get
            {
                if (proxy==null)
                {
                    proxy = new Proxy();
                }
                return proxy;
            }
            set
            {
                proxy = value;
            }
        }
        public bool AddContact(Contact contact)
        {
            PutAttributesRequest putRequest = new PutAttributesRequest();
            string DomainName = "Contacts";
            List<ReplaceableAttribute> attributeList = new List<ReplaceableAttribute>
               {
                   new ReplaceableAttribute().WithName("Email").WithValue(contact.Email),
                   new ReplaceableAttribute().WithName("Name").WithValue(contact.Name),
                   new ReplaceableAttribute().WithName("Phone").WithValue(contact.Phone)
               };
            contact.ID = Guid.NewGuid();
            bool success = false;
            try
            {
                if (!myProxy.Domains.Contains(DomainName))
                {
                    myProxy.AddDomain(DomainName);
                }
                PutAttributesRequest action = new PutAttributesRequest().WithDomainName(DomainName).WithItemName(contact.ID.ToString());
                action.Attribute = attributeList;
                PutAttributesResponse response = myProxy.service.PutAttributes(action);
                success = true;
            }
            catch (Exception requestException)
            {
                success = false;
            }

            return success;
        }
    }
}
