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
    public class Proxy
    {
        private string PublicKey = String.Empty;
        private string SecretKey = String.Empty;
        public AmazonSimpleDBClient service{ get; set;}
        private List<string> domains;
        public List<string> Domains
        {
            get
            {
                if (domains==null)
                {
                    domains = GetDomains();
                }
                return domains;
            }
        }

        public Proxy()
        {
            PublicKey = ConfigurationManager.AppSettings["PublicKey"];
            SecretKey = ConfigurationManager.AppSettings["SecretKey"];
            service = new AmazonSimpleDBClient(PublicKey, SecretKey);
        }

        public List<string> GetDomains()
        {
            ListDomainsRequest ListDomainsAction = new ListDomainsRequest();
            ListDomainsResponse response = service.ListDomains(ListDomainsAction);
            return response.ListDomainsResult.DomainName;
        }

        public void AddDomain(string domainName)
        {
            CreateDomainRequest myCreateDomainRequest = new CreateDomainRequest {DomainName = domainName};
            CreateDomainResponse response = service.CreateDomain(myCreateDomainRequest);
        }

        public void DeleteDomain(string domainName)
        {
            DeleteDomainRequest request = new DeleteDomainRequest {DomainName = domainName};
            DeleteDomainResponse response = service.DeleteDomain(request);
        }
    }
}
