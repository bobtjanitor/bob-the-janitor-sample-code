using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class AuthentiactionRepository : SimpleDBRepositoryBase, IAuthentiactionRepository
    {
        public Guid AuthenticatedUser { get; set; }

        public bool CheckAuthentication(string userName, string password)
        {
            bool success = false;
            using (AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                SelectRequest request =
                    new SelectRequest().WithSelectExpression(string.Format("SELECT Id FROM Profiles where Username = '{0}' and Password='{1}'", userName, password));

                SelectResponse response = client.Select(request);
                if (response.SelectResult.Item.Count>0)
                {
                    success = true;
                    AuthenticatedUser = Guid.Parse(response.SelectResult.Item.First().Name);
                }
            }

            return success;
        }
    }
}
