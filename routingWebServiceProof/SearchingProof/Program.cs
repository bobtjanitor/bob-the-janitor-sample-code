using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SearchingProof.Searching;

namespace SearchingProof
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadSearchClient client = new LoadSearchClient();
            LoadSearchRequest request = new LoadSearchRequest();
            request.Criteria = new LoadSearchCriteria(){OriginCity = "Boise",OriginState = "ID",EquipmentType = "V"};
            request.Criteria.LoadType = LoadType.All;
            request.IntegrationId = 4;
            request.UserName = "TestUser";
            request.Password = "tupass123";

            LoadSearchReturn result = client.GetLoadSearchResults(request);
            Console.WriteLine(result.Errors.Count());
            Console.WriteLine(result.SearchResults.Count());
        }
    }
}
