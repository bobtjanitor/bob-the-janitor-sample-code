using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.SimpleDB.Model;
using SimpleDB.Objects;

namespace SimpleDB.DAL
{
    public class ContactData
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
            Contacts myContacts = new Contacts();

            SelectRequest request = new SelectRequest
            {
                SelectExpression = string.Format("SELECT * FROM {0} ", DomainName)
            };
            SelectResponse response = SimpleDBProxy.Service.Select(request);

            var contacts = from item in response.SelectResult.Item
                             select new Contact()
                                        {
                                            Email = item.Attribute.GetValueByName("Email"),
                                            Name = item.Attribute.GetValueByName("Name"),
                                            Phone = item.Attribute.GetValueByName("Phone"),
                                            ID =  item.Name
                                        };
            myContacts.AddRange(contacts);
            return myContacts;
        }

        public Contacts GetContactsByName(string contactName)
        {
            Contacts myContacts = new Contacts();

            SelectRequest request = new SelectRequest
            {
                SelectExpression = string.Format("SELECT * FROM {0} where Name='{1}' ", DomainName, contactName)
            };
            SelectResponse response = SimpleDBProxy.Service.Select(request);

            var contacts = from item in response.SelectResult.Item
                           select new Contact()
                           {
                               Email = item.Attribute.GetValueByName("Email"),
                               Name = item.Attribute.GetValueByName("Name"),
                               Phone = item.Attribute.GetValueByName("Phone"),
                               ID = item.Name
                           };
            myContacts.AddRange(contacts);
            return myContacts;
        }
       
        public bool SaveContact(Contact contact)
        {
            List<ReplaceableAttribute> attributeList = new List<ReplaceableAttribute>
               {
                   new ReplaceableAttribute().WithName("Email").WithValue(contact.Email),
                   new ReplaceableAttribute().WithName("Name").WithValue(contact.Name),
                   new ReplaceableAttribute().WithName("Phone").WithValue(contact.Phone)
               };
            contact.ID = Guid.NewGuid().ToString();
            bool success = false;
            try
            {
                if (!SimpleDBProxy.Domains.Contains(DomainName))
                {
                    SimpleDBProxy.AddDomain(DomainName);
                }
                PutAttributesRequest action = new PutAttributesRequest
                  {
                      ItemName = contact.ID.ToString(),
                      Attribute = attributeList,
                      DomainName = DomainName
                  };
                PutAttributesResponse response = SimpleDBProxy.Service.PutAttributes(action);
                success = true;
            }
            catch (Exception requestException)
            {
                success = false;
            }

            return success;
        }

        public Contact GetContactsByID(string contactId)
        {
            throw new NotImplementedException();
        }
    }
}
