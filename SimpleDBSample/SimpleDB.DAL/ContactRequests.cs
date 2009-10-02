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
            Contacts myContacts = new Contacts();

            SelectRequest request = new SelectRequest
            {
                SelectExpression = string.Format("SELECT * FROM {0} ", DomainName)
            };
            SelectResponse response = SimpleDBProxy.service.Select(request);

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

    public static class simpleDBExtedors
    {
        public static string GetValueByName(this IList<Attribute> myAttributes, string name)
        {
            var myValue = from attribute in myAttributes where attribute.Name == name select attribute.Value;

            return myValue.FirstOrDefault();
        }
    }
}
