using System;
using System.Configuration;
using System.Linq;
using Amazon.SimpleDB.Model;
using DomainModels;
using DomainModels.RepositoryInterfaces;
using Amazon.SimpleDB;

namespace CyclingRepository
{
    public class ProfilesRepository : IProfilesRepository
    {
        private readonly string _publicKey = ConfigurationManager.AppSettings["PublicKey"];
        private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];
        public Profiles GetProfileList()
        {
            Profiles profiles = new Profiles();
            using(AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                SelectRequest request = new SelectRequest { SelectExpression = "SELECT * FROM Profiles" };

                SelectResponse response = client.Select(request);

                var list = from item in response.SelectResult.Item
                           select new Profile()
                                      {
                                          Id = Guid.Parse(item.Name), 
                                          Description = item.Attribute.GetValueByName("Description"),
                                          Location = item.Attribute.GetValueByName("Location"),
                                          Name = item.Attribute.GetValueByName("Name")
                                      };
                foreach (Profile profile in list)
                {
                    profiles.Add(profile);
                }
            }

            return profiles;
        }

        public Profile GetProfileById(Guid id)
        {
            Profile profile;
            using (AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                SelectRequest request = new SelectRequest { SelectExpression = string.Format("SELECT * FROM Profiles where Name = '{0}'",id) };
                SelectResponse response = client.Select(request);
                profile = (from item in response.SelectResult.Item
                           select new Profile()
                           {
                               Id = Guid.Parse(item.Name),
                               Description = item.Attribute.GetValueByName("Description"),
                               Location = item.Attribute.GetValueByName("Location"),
                               Name = item.Attribute.GetValueByName("Name")
                           }).First();

            }
            return profile;
        }
    }
}