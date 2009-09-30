using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SimpleDB.Model;
using SimpleDB.Objects;
using Attribute=Amazon.SimpleDB.Model.Attribute;

namespace SimpleDB.DAL
{
    public class ContactRequests
    {
        private Proxy simpleDBProxy;
        public Proxy SimpleDBProxy
        {
            get
            {
                if (simpleDBProxy==null)
                {
                    simpleDBProxy = new Proxy();
                }
                return simpleDBProxy;
            }
            set
            {
                simpleDBProxy = value;
            }
        }
        const string DomainName = "Contacts";

        public Contacts GetContacts()
        {
            GetAttributesRequest request = new GetAttributesRequest();
            request.DomainName = DomainName;
            GetAttributesResponse response = SimpleDBProxy.service.GetAttributes(request);
            List<Attribute> attributeList = response.GetAttributesResult.Attribute;

            throw new NotImplementedException("still working on this");
        }

        public bool AddContact(Contact contact)
        {
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
                if (!SimpleDBProxy.Domains.Contains(DomainName))
                {
                    SimpleDBProxy.AddDomain(DomainName);
                }
                PutAttributesRequest action = new PutAttributesRequest().WithDomainName(DomainName).WithItemName(contact.ID.ToString());
                action.Attribute = attributeList;
                PutAttributesResponse response = SimpleDBProxy.service.PutAttributes(action);
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
