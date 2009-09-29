using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;
using SimpleDB.Objects;

namespace SimpleDB.DAL
{
    public class ContactProxy
    {
        private string PublicKey = String.Empty;
        private string SecretKey = String.Empty;
        private string DomainName = String.Empty;
        public AmazonSimpleDBClient service{ get; set;}

        public ContactProxy()
        {
            PublicKey = ConfigurationManager.AppSettings["PublicKey"];
            SecretKey = ConfigurationManager.AppSettings["SecretKey"];
            DomainName = "Contacts";
            service = new AmazonSimpleDBClient(PublicKey, SecretKey);
        }

        public bool AddContact(Contact contact)
        {
            PutAttributesRequest putRequest = new PutAttributesRequest();
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
                PutAttributesRequest action = new PutAttributesRequest().WithDomainName(DomainName).WithItemName(contact.ID.ToString());
                action.Attribute = attributeList;
                PutAttributesResponse response = service.PutAttributes(action);
                success = true;
            }
            catch 
            {
                success = false;
            }
            
            return success;
        }


    }
}
