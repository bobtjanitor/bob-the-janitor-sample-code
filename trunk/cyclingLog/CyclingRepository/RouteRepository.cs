using System;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;
using DomainModels;
using DomainModels.RepositoryInterfaces;

namespace CyclingRepository
{
    public class RouteRepository :SimpleDBRepositoryBase, IRouteRepository
    {
        public const string DomainName= "Routes";

        public bool AddUpdateRoute(Route route)
        {
            bool success = true;
            using (AmazonSimpleDBClient client = new AmazonSimpleDBClient(_publicKey, _secretKey))
            {
                PutAttributesRequest request = new PutAttributesRequest
                                                   {
                                                       DomainName = DomainName,
                                                       ItemName = route.Id.ToString()
                                                   };
                request.Attribute.Add(new ReplaceableAttribute() { Name = "Name", Replace = true, Value = route.Name });
                request.Attribute.Add(new ReplaceableAttribute() { Name = "Distance", Replace = true, Value = route.Distance.ToString() });
                request.Attribute.Add(new ReplaceableAttribute() { Name = "Id", Replace = true, Value = route.Id.ToString() });
                request.Attribute.Add(new ReplaceableAttribute() { Name = "LastTimeRidden", Replace = true, Value = route.LastTimeRidden.ToShortDateString() });
                request.Attribute.Add(new ReplaceableAttribute() { Name = "Location", Replace = true, Value = route.Location });
                try
                {
                    PutAttributesResponse response = client.PutAttributes(request);
                }
                catch(Exception repositoryError)
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
