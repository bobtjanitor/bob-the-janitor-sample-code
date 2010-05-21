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
    public interface IProxy
    {
        AmazonSimpleDBClient Service { get; set; }
        List<string> Domains { get; }
        List<string> GetDomains();
        void AddDomain(string domainName);
        void DeleteDomain(string domainName);
    }

    public class Proxy : IProxy
    {
        private string PublicKey = String.Empty;
        private string SecretKey = String.Empty;
        public AmazonSimpleDBClient Service{ get; set;}
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
            Service = new AmazonSimpleDBClient(PublicKey, SecretKey);
        }

        public List<string> GetDomains()
        {
            ListDomainsRequest ListDomainsAction = new ListDomainsRequest();
            ListDomainsResponse response = Service.ListDomains(ListDomainsAction);
            return response.ListDomainsResult.DomainName;
        }

        public void AddDomain(string domainName)
        {
            CreateDomainRequest myCreateDomainRequest = new CreateDomainRequest {DomainName = domainName};
            CreateDomainResponse response = Service.CreateDomain(myCreateDomainRequest);
        }

        public void DeleteDomain(string domainName)
        {
            DeleteDomainRequest request = new DeleteDomainRequest {DomainName = domainName};
            DeleteDomainResponse response = Service.DeleteDomain(request);
        }
    }
}
