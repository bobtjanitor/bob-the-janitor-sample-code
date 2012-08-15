using System;
using System.Linq;
using Amazon.SimpleDB.Model;
using DomainModels;
using DomainModels.RepositoryInterfaces;
using Amazon.SimpleDB;

namespace CyclingRepository
{
    public class ProfilesRepository :SimpleDBRepositoryBase, IProfilesRepository
    {
        
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
                                          Id = Guid.Parse(item.Attribute.GetValueByName("Id")), 
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
                SelectRequest request =
                    new SelectRequest().WithSelectExpression(string.Format("SELECT * FROM Profiles where Id = '{0}'",id));

                SelectResponse response = client.Select(request);
                profile = (from item in response.SelectResult.Item
                           select new Profile()
                           {
                               Id = Guid.Parse(item.Attribute.GetValueByName("Id")),
                               Description = item.Attribute.GetValueByName("Description"),
                               Location = item.Attribute.GetValueByName("Location"),
                               Name = item.Attribute.GetValueByName("Name")
                           }).First();

            }
            return profile;
        }
    }
}